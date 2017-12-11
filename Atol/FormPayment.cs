using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atol
{
    public partial class FormPayment : Form
    {
        public double summa = 0;

        public FormPayment()
        {
            InitializeComponent();
        }

        private void buttonAddCash_Click(object sender, EventArgs e)
        {
            textBoxCash.Text = summa.ToString();
            textBoxCard.Text = "0";
            labelSdacha.Text = "0";
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            textBoxCash.Text = "0";
            textBoxCard.Text = summa.ToString();
            labelSdacha.Text = "0";
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            labelSumma.Text = summa.ToString();
            labelSdacha.Text = (-summa).ToString();
        }

        private void textBoxCash_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxCash.SelectAll();
        }

        private void textBoxCard_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxCard.SelectAll();
        }

        private void textBoxCash_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxCash.Text != "")
            {
                textBoxCard.Text = "0";

                double cash = double.Parse(textBoxCash.Text.Replace('.', ','));
                cash = Math.Round(cash, 2, MidpointRounding.AwayFromZero);
                labelSdacha.Text = (cash - summa).ToString();
            }
            else
            {
                labelSdacha.Text = (-summa).ToString();       
            }

            if (e.KeyCode == Keys.Enter)
            {
                buttonPay.Focus();
            }
        }

        private void textBoxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Запрет на ввод более одной десятичной точки.
                if ((e.KeyChar != '.' || textBoxCash.Text.IndexOf(".") != -1) && (e.KeyChar != ',' || textBoxCash.Text.IndexOf(",") != -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void FormPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK &&  !(Double.Parse(labelSdacha.Text) >= 0))

            {
                MessageBox.Show("Недостаточно средств от клиента!");
                e.Cancel = true;
            }
        }

        private void radioButtonPaymentPrihod_CheckedChanged(object sender, EventArgs e)
        {
            buttonPay.Text = "ОПЛАТА";
        }

        private void radioButtonPaymentVozvrat_CheckedChanged(object sender, EventArgs e)
        {
            buttonPay.Text = "ВОЗВРАТ";
        }
    }
}
