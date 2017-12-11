using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atol
{
    public partial class FormProducts : Form
    {
        private DataSet dataSetProducts = new DataSet();

        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProduction_Load(object sender, EventArgs e)
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"settings.xml";
            dataSetProducts.ReadXml(fileName);

            //dataSetProducts.Tables["Product"].Columns["title"].ColumnName = "Наименование";
            //dataSetProducts.Tables["Product"].Columns["NDS"].ColumnName = "НДС";
            //dataSetProducts.Tables["Product"].Columns["price"].ColumnName = "Цена";

            dataGridViewProducts.DataSource = dataSetProducts.Tables["Продукт"];

            dataGridViewProducts.Columns["Наименование"].Width = 400;
            dataGridViewProducts.Columns["НДС"].Width = 50;
            dataGridViewProducts.Columns["НДС"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewProducts.Columns["Цена"].DefaultCellStyle.Format = "#####.00";
            dataGridViewProducts.Columns["Цена"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewProducts.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridViewProducts_CellFormatting);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ProductsSave();
        }

        private void FormProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                ProductsSave();
            }
        }

        private void ProductsSave()
        {
            string fileNameOld = AppDomain.CurrentDomain.BaseDirectory + @"settings.old.xml";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"settings.xml";
            System.IO.File.Copy(fileName, fileNameOld, true);
            dataSetProducts.WriteXml(fileName);
        }

        private void dataGridViewProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                nextCell();
            }
        }

        private void buttonRowDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow.Index > 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[dataGridViewProducts.CurrentRow.Index];
                if (MessageBox.Show(row.Cells["Наименование"].Value.ToString(), "Удалить?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    dataGridViewProducts.Rows.Remove(row);
                }
            }
        }

        private void nextCell(int row = 0)
        {
            try
            {

                int iColumn = dataGridViewProducts.CurrentCell.ColumnIndex;
                int iRow = dataGridViewProducts.CurrentCell.RowIndex;
                if (iColumn == dataGridViewProducts.ColumnCount - 1)
                {
                    if (dataGridViewProducts.RowCount > (iRow + 1))
                    {
                        dataGridViewProducts.CurrentCell = dataGridViewProducts[0, iRow + 1];
                    }
                    else
                    {
                        //focus next control
                    }
                }
                else
                {
                    dataGridViewProducts.CurrentCell = dataGridViewProducts[iColumn + 1, iRow];
                    if (row == 1)
                        SendKeys.Send("{up}");
                }

            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            nextCell(1);
            var cell = dataGridViewProducts[e.ColumnIndex, e.RowIndex];
            cell.Value = cell.FormattedValue;
        }

        private void dataGridViewProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    try
                    {
                        var  str = e.Value.ToString().Replace('.', ',');
                        double value = double.Parse(str);
                        e.Value = value.ToString("#####.00", CultureInfo.CurrentCulture).ToString();
                        e.FormattingApplied = true;
                    }
                    catch (Exception)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }

                }
            }
        }

    }
}
