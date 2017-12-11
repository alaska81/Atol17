using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Atol
{
    public partial class FormMain : Form
    {
        private FprnM1C.IFprnM45 ECR;
        private int COMPort;

        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            String strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "АТОЛ - печать чеков v" + strVersion;

            timerDateTime.Start();

            LoadSettingsXML();
            LoadChecks();

            try
            {
                ECR = new FprnM1C.FprnM45Class();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось создать объект общего драйвера ККМ!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void LoadSettingsXML()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"settings.xml";

            //XmlDocument doc = new XmlDocument();
            //doc.Load(fileName);
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Отсутствует файл настроек settings.xml");
                Application.Exit();
            }

            dataSetProducts.Clear();
            dataSetProducts.ReadXml(fileName);

            comboBoxNDS.DataSource = dataSetProducts.Tables["НДС"];
            comboBoxNDS.DisplayMember = "Наименование";
            comboBoxNDS.ValueMember = "id";
            //comboBoxNDS.Refresh();

            comboBoxDiscount.DataSource = dataSetProducts.Tables["Скидка"];
            comboBoxDiscount.DisplayMember = "Наименование";
            comboBoxDiscount.ValueMember = "Значение";
            //comboBoxDiscount.Refresh();

            comboBoxProduct.DataSource = dataSetProducts.Tables["Продукт"];
            comboBoxProduct.DisplayMember = "Наименование";
            //comboBoxProduct.ValueMember = "id";
            //comboBoxProduct.Refresh();

            //dataSetProducts.WriteXml(fileName);

            //dataSetChecks.dataSetChecks.Clear();
            //dataSetChecks.Tables.Add("Checks").Rows.Add("Номер", "Наименование");

            DataTable dtKKM = dataSetProducts.Tables["ККМ"];
            COMPort = dtKKM.AsEnumerable().Select(x => int.Parse(x.Field<string>("COMPort"))).First();

        }

        private void textBoxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Запрет на ввод более одной десятичной точки.
                if ((e.KeyChar != '.' || textBoxPrice.Text.IndexOf(".") != -1) && (e.KeyChar != ',' || textBoxPrice.Text.IndexOf(",") != -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxPrice.Text == "")
            {
                MessageBox.Show("Цена не может быть пустой");
            }
            else
            {
                double price = double.Parse(textBoxPrice.Text.Replace('.', ','));
                price = price * (1 - double.Parse(comboBoxDiscount.SelectedValue.ToString())/100);
                price = Math.Round(price, 2, MidpointRounding.AwayFromZero);
                double kolvo = Math.Round(double.Parse(numericUpDownQty.Value.ToString()), 2, MidpointRounding.AwayFromZero);
                double summa = Math.Round(price * kolvo, 2, MidpointRounding.AwayFromZero);
                dataGridViewChecks.Rows.Add(comboBoxProduct.Text, price, kolvo, summa, comboBoxNDS.Text, comboBoxDiscount.Text, comboBoxNDS.SelectedValue, comboBoxDiscount.SelectedValue);
            }

            //textBoxPrice.Text = "";
            textBoxPrice.Focus();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewChecks.SelectedRows)
            {
                dataGridViewChecks.Rows.RemoveAt(item.Index);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewChecks.Rows.Clear();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            double summa = 0;
            foreach (DataGridViewRow item in dataGridViewChecks.Rows)
            {
                //double qty = double.Parse(item.Cells["ColumnQty"].Value.ToString());
                //double price = double.Parse(item.Cells["ColumnPrice"].Value.ToString());
                //double discount = double.Parse(item.Cells["ColumnDiscount"].Value.ToString());

                //summa += (qty * price * (1 - discount / 100));
                summa += double.Parse(item.Cells["ColumnSumma"].Value.ToString());
            }

            using (FormPayment fp = new FormPayment())
            {
                summa = Math.Round(summa, 2, MidpointRounding.AwayFromZero);
                fp.summa = summa;

                if (fp.ShowDialog(this) == DialogResult.OK)
                {
                    double summaCash = 0;
                    double summaCard = 0;

                    if (fp.textBoxCash.Text != "0")
                    {
                        summaCash = double.Parse(fp.textBoxCash.Text.Replace('.', ','));
                        summaCash = Math.Round(summaCash, 2, MidpointRounding.AwayFromZero);
                    }

                    if (fp.textBoxCard.Text != "0")
                    {
                        summaCard = double.Parse(fp.textBoxCard.Text.Replace('.', ','));
                        summaCard = Math.Round(summaCard, 2, MidpointRounding.AwayFromZero);
                    }

                    string cashier = "Кассир";
                    int numCheck = -1;
                    int numSession = 0;

                    bool vozvrat = fp.radioButtonPaymentVozvrat.Checked;

                    if (PayAtol(summaCash, summaCard, cashier, numCheck, numSession, vozvrat)) {
                        if (numCheck > 0)
                        {
                            AddCheck(numCheck.ToString(), summaCash.ToString(), summaCard.ToString(), cashier, numSession.ToString());
                        }
                    }

                    dataGridViewChecks.Rows.Clear();
                }
            }

        }

        private void buttonZReport_Click(object sender, EventArgs e)
        {
            if (!SetDevice()) return;

            ECR.Mode = 3;
            if (ECR.SetMode() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return;
            }

            ECR.ReportType = 1;
            if (ECR.Report() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return;
            }

            CloseChecks();
        }


        private void buttonXReport_Click(object sender, EventArgs e)
        {
            if (!SetDevice()) return;

            ECR.Mode = 2;
            if (ECR.SetMode() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return;
            }

            ECR.ReportType = 2;
            if (ECR.Report() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return;
            }
        }

        private bool PayAtol(double cash, double card, string cashier = "Кассир", int numCheck = -1, int numSession = 0, bool vozvrat = false)
        {
            if (!SetDevice()) return false;

            ECR.Mode = 1;
            if (ECR.SetMode() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return false;
            }

            ECR.AttrNumber = 1021;
            ECR.AttrValue = cashier;
            if (ECR.WriteAttribute() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return false;
            }

            numCheck = ECR.CheckNumber;
            numSession = ECR.Session;

            int num = 1;
            foreach (DataGridViewRow item in dataGridViewChecks.Rows)
            {
                ECR.Name = num.ToString() + ". " + item.Cells["ColumnProduct"].Value.ToString();
                ECR.Quantity = double.Parse(item.Cells["ColumnQty"].Value.ToString());
                //ECR.Department = Отдел;
                ECR.TaxTypeNumber = int.Parse(item.Cells["ColumnNDSValue"].Value.ToString());
                ECR.Price = double.Parse(item.Cells["ColumnPrice"].Value.ToString());

                ECR.Percents = double.Parse(item.Cells["ColumnDiscountValue"].Value.ToString());
                ECR.DiscountValue = double.Parse(item.Cells["ColumnDiscountValue"].Value.ToString());
                ECR.DiscountType = 1;
                ECR.DiscountTypeNumber = 1;

                if (!vozvrat)
                {
                    if (ECR.Registration() != 0)
                    {
                        MessageBox.Show(ECR.ResultDescription);
                        return false;
                    }
                } else
                {
                    if (ECR.Return() != 0)
                    {
                        MessageBox.Show(ECR.ResultDescription);
                        return false;
                    }
                }

                num++;
            }

            if (cash > 0)
            {
                ECR.Summ = cash;
                ECR.TypeClose = 0;
                ECR.Payment();
            }

            if (card > 0)
            {
                ECR.Summ = card;
                ECR.TypeClose = 3;
                ECR.Payment();
            }

            if (ECR.CloseCheck() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return false;
            }


            if (ECR.ResetMode() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return false;
            }

            ECR.DeviceEnabled = false;
            if (ECR.ResultCode != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return false;
            }

            return true;

        }

        private bool SetDevice()
        {
            ECR.PortNumber = COMPort;

            ECR.DeviceEnabled = true;

            if (ECR.ResultCode != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return false;
            }

            if (ECR.GetStatus() != 0)
            {
                MessageBox.Show(ECR.ResultDescription);
                return false;
            }

            if (ECR.CheckState != 0)
                if (ECR.CancelCheck() != 0)
                {
                    MessageBox.Show(ECR.ResultDescription);
                    return false;
                }

            ECR.Password = "30";

            return true;
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void номенклатураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormProducts fp = new FormProducts())
            {

                if (fp.ShowDialog(this) == DialogResult.OK)
                {
                    LoadSettingsXML();

                    DataRowView dv = (DataRowView)comboBoxProduct.SelectedItem;

                    ProductChange(dv);
                }
            }
        }
        
        private void реестрЧековToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormReestrChecks fp = new FormReestrChecks())
            {

                if (fp.ShowDialog(this) == DialogResult.OK)
                {

                }
            }
        }

        private void кКТToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormKKM fp = new FormKKM())
            {
                fp.textBoxCOMPort.Text = COMPort.ToString();

                if (fp.ShowDialog(this) == DialogResult.OK)
                {
                    COMPort = int.Parse(fp.textBoxCOMPort.Text);

                    try
                    {
                        if (!dataSetProducts.Tables.Contains("ККМ"))
                        {
                            dataSetProducts.Tables.Add("ККМ").Columns.Add("COMPort");
                        }
                        dataSetProducts.Tables["ККМ"].Rows.Clear();
                        dataSetProducts.Tables["ККМ"].Rows.Add(COMPort);

                        string fileNameOld = AppDomain.CurrentDomain.BaseDirectory + @"settings.old.xml";
                        string fileName = AppDomain.CurrentDomain.BaseDirectory + @"settings.xml";
                        System.IO.File.Copy(fileName, fileNameOld, true);
                        dataSetProducts.WriteXml(fileName);
                    }
                    catch (Exception)
                    {

                    }
                    
                }
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem != null)
            {
                DataRowView dv = (DataRowView)comboBoxProduct.SelectedItem;

                ProductChange(dv);
            }
        }

        private void ProductChange(DataRowView dv)
        {
            if (!DBNull.Value.Equals(dv.Row["НДС"]))
            {
                comboBoxNDS.SelectedValue = GetNDSValueToId(dv.Row["НДС"].ToString());
            }
            else
            {
                comboBoxNDS.SelectedValue = 1;
            }

            if (!DBNull.Value.Equals(dv.Row["Цена"]))
            {
                textBoxPrice.Text = dv.Row["Цена"].ToString();
            }
            else
            {
                textBoxPrice.Text = "";
            }
        }

        private int GetNDSValueToId(string value)
        {
            int result = 1;

            switch (value)
            {
                case "0":
                    result = 1;
                    break;
                case "10":
                    result = 2;
                    break;
                case "18":
                    result = 3;
                    break;
                default:
                    result = 4;
                    break;

            }

            return result;
        }

        private int GetNDSIdToValue(int id)
        {
            int result = 0;

            switch (id)
            {
                case 1:
                    result = 0;
                    break;
                case 2:
                    result = 10;
                    break;
                case 3:
                    result = 18;
                    break;
                default:
                    result = 0;
                    break;

            }

            return result;
        }

        private void LoadChecks()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"checks.xml";
            if (File.Exists(fileName))
            {
                dataSetChecks.Clear();
                dataSetChecks.ReadXml(fileName);
            }
        }

        private void SaveChecks()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"checks.xml";
            dataSetChecks.WriteXml(fileName);
        }

        private void CloseChecks()
        {
            SaveChecks();
            string oldFileName = AppDomain.CurrentDomain.BaseDirectory + @"checks.xml";
            string newFileName = AppDomain.CurrentDomain.BaseDirectory + @"checks_" + DateTime.Now.ToString().Replace(".", "").Replace(":", "").Replace(" ", "_") +  @".xml";
            File.Move(oldFileName, newFileName);

            dataSetChecks.Clear();
        }

        private void AddCheck(string numCheck, string summaCash, string summaCard, string cashier, string numSession)
        {
            DataTable dtChecks = dataSetChecks.Tables["Чеки"];
            DataTable dtProducts = dataSetChecks.Tables["Товары"];

            string date = DateTime.Now.ToString();
            dtChecks.Rows.Add(numCheck, date, summaCash, summaCard, cashier, numSession);

            foreach (DataGridViewRow item in dataGridViewChecks.Rows)
            {
                string сolumnProduct = item.Cells["ColumnProduct"].Value.ToString();
                string сolumnPrice = item.Cells["ColumnPrice"].Value.ToString();
                string сolumnQty = item.Cells["ColumnQty"].Value.ToString();
                string ColumnNDSValue = item.Cells["ColumnNDSValue"].Value.ToString();
                string ColumnDiscountValue = item.Cells["ColumnDiscountValue"].Value.ToString();

                dtProducts.Rows.Add(numCheck, сolumnProduct, сolumnPrice, сolumnQty, ColumnNDSValue, ColumnDiscountValue);
            }

            SaveChecks();
        }

    }
}
