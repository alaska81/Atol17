using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atol
{
    public partial class FormReestrChecks : Form
    {
        public FormReestrChecks()
        {
            InitializeComponent();
        }

        private void FormReestrChecks_Load(object sender, EventArgs e)
        {
            dateTimePickerChecks.Value = DateTime.Now;

            LoadChecks(DateTime.Now);
            dataGridViewChecks.DataSource = dataSetChecks.Tables["Чеки"];
            SumChecks();
        }

        private void dateTimePickerChecks_ValueChanged(object sender, EventArgs e)
        {
            LoadChecks(dateTimePickerChecks.Value);
        }

        private void LoadChecks(DateTime datetime)
        {
            dataSetChecks.Clear();

            string dateMask = "*" + datetime.ToString("ddMMyyyy") + "*.xml";
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, dateMask);
            //string fileName = AppDomain.CurrentDomain.BaseDirectory + @"checks.xml";
            foreach (string fileName in files)
            {
                if (File.Exists(fileName))
                {
                    dataSetChecks.ReadXml(fileName);

                }
            }

            SumChecks();
        }

        private void SumChecks()
        {
            DataTable dtChecks = dataSetChecks.Tables["Чеки"];
            double summaCash = dtChecks.AsEnumerable().Select(x => double.Parse(x.Field<string>("СуммаНаличными"))).Sum();
            textBoxSumCash.Text = Math.Round(summaCash, 2, MidpointRounding.AwayFromZero).ToString();
        }
    }
}
