namespace Atol
{
    partial class FormReestrChecks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerDown = new System.Windows.Forms.SplitContainer();
            this.splitContainerUp = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSumElectron = new System.Windows.Forms.TextBox();
            this.textBoxSumCash = new System.Windows.Forms.TextBox();
            this.labelSumElectron = new System.Windows.Forms.Label();
            this.labelSumCash = new System.Windows.Forms.Label();
            this.dateTimePickerChecks = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewChecks = new System.Windows.Forms.DataGridView();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dataSetChecks = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.splitContainerDown.Panel1.SuspendLayout();
            this.splitContainerDown.Panel2.SuspendLayout();
            this.splitContainerDown.SuspendLayout();
            this.splitContainerUp.Panel1.SuspendLayout();
            this.splitContainerUp.Panel2.SuspendLayout();
            this.splitContainerUp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerDown
            // 
            this.splitContainerDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDown.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerDown.IsSplitterFixed = true;
            this.splitContainerDown.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDown.Name = "splitContainerDown";
            this.splitContainerDown.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDown.Panel1
            // 
            this.splitContainerDown.Panel1.Controls.Add(this.splitContainerUp);
            // 
            // splitContainerDown.Panel2
            // 
            this.splitContainerDown.Panel2.Controls.Add(this.buttonOk);
            this.splitContainerDown.Size = new System.Drawing.Size(696, 383);
            this.splitContainerDown.SplitterDistance = 318;
            this.splitContainerDown.TabIndex = 15;
            // 
            // splitContainerUp
            // 
            this.splitContainerUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUp.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerUp.IsSplitterFixed = true;
            this.splitContainerUp.Location = new System.Drawing.Point(0, 0);
            this.splitContainerUp.Name = "splitContainerUp";
            this.splitContainerUp.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerUp.Panel1
            // 
            this.splitContainerUp.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerUp.Panel1.Controls.Add(this.dateTimePickerChecks);
            // 
            // splitContainerUp.Panel2
            // 
            this.splitContainerUp.Panel2.Controls.Add(this.dataGridViewChecks);
            this.splitContainerUp.Size = new System.Drawing.Size(696, 318);
            this.splitContainerUp.SplitterDistance = 72;
            this.splitContainerUp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSumElectron);
            this.groupBox1.Controls.Add(this.textBoxSumCash);
            this.groupBox1.Controls.Add(this.labelSumElectron);
            this.groupBox1.Controls.Add(this.labelSumCash);
            this.groupBox1.Location = new System.Drawing.Point(231, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBoxSumElectron
            // 
            this.textBoxSumElectron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumElectron.Location = new System.Drawing.Point(347, 13);
            this.textBoxSumElectron.Name = "textBoxSumElectron";
            this.textBoxSumElectron.ReadOnly = true;
            this.textBoxSumElectron.Size = new System.Drawing.Size(100, 26);
            this.textBoxSumElectron.TabIndex = 3;
            this.textBoxSumElectron.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSumCash
            // 
            this.textBoxSumCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumCash.Location = new System.Drawing.Point(114, 13);
            this.textBoxSumCash.Name = "textBoxSumCash";
            this.textBoxSumCash.ReadOnly = true;
            this.textBoxSumCash.Size = new System.Drawing.Size(100, 26);
            this.textBoxSumCash.TabIndex = 2;
            this.textBoxSumCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSumElectron
            // 
            this.labelSumElectron.AutoSize = true;
            this.labelSumElectron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumElectron.Location = new System.Drawing.Point(220, 18);
            this.labelSumElectron.Name = "labelSumElectron";
            this.labelSumElectron.Size = new System.Drawing.Size(128, 20);
            this.labelSumElectron.TabIndex = 1;
            this.labelSumElectron.Text = "Электронными:";
            // 
            // labelSumCash
            // 
            this.labelSumCash.AutoSize = true;
            this.labelSumCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumCash.Location = new System.Drawing.Point(6, 16);
            this.labelSumCash.Name = "labelSumCash";
            this.labelSumCash.Size = new System.Drawing.Size(102, 20);
            this.labelSumCash.TabIndex = 0;
            this.labelSumCash.Text = "Наличными:";
            // 
            // dateTimePickerChecks
            // 
            this.dateTimePickerChecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerChecks.Location = new System.Drawing.Point(12, 23);
            this.dateTimePickerChecks.Name = "dateTimePickerChecks";
            this.dateTimePickerChecks.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerChecks.TabIndex = 0;
            this.dateTimePickerChecks.ValueChanged += new System.EventHandler(this.dateTimePickerChecks_ValueChanged);
            // 
            // dataGridViewChecks
            // 
            this.dataGridViewChecks.AllowUserToAddRows = false;
            this.dataGridViewChecks.AllowUserToDeleteRows = false;
            this.dataGridViewChecks.AllowUserToResizeRows = false;
            this.dataGridViewChecks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChecks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChecks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChecks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewChecks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewChecks.MultiSelect = false;
            this.dataGridViewChecks.Name = "dataGridViewChecks";
            this.dataGridViewChecks.RowHeadersVisible = false;
            this.dataGridViewChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChecks.Size = new System.Drawing.Size(696, 242);
            this.dataGridViewChecks.TabIndex = 15;
            this.dataGridViewChecks.TabStop = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(266, 14);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(162, 35);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // dataSetChecks
            // 
            this.dataSetChecks.DataSetName = "dataSetChecks";
            this.dataSetChecks.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn10,
            this.dataColumn3,
            this.dataColumn11,
            this.dataColumn12});
            this.dataTable1.TableName = "Чеки";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Номер Чека";
            this.dataColumn1.ColumnName = "НомерЧека";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Дата";
            this.dataColumn2.ColumnName = "Дата";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "СуммаНаличными";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "СуммаКартой";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Кассир";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "НомерСессии";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn4,
            this.dataColumn5});
            this.dataTable2.TableName = "Товары";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "НомерЧека";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Наименование";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Цена";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Количество";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "НДС";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Скидка";
            // 
            // FormReestrChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 383);
            this.Controls.Add(this.splitContainerDown);
            this.Name = "FormReestrChecks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Реестр чеков";
            this.Load += new System.EventHandler(this.FormReestrChecks_Load);
            this.splitContainerDown.Panel1.ResumeLayout(false);
            this.splitContainerDown.Panel2.ResumeLayout(false);
            this.splitContainerDown.ResumeLayout(false);
            this.splitContainerUp.Panel1.ResumeLayout(false);
            this.splitContainerUp.Panel2.ResumeLayout(false);
            this.splitContainerUp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerDown;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.SplitContainer splitContainerUp;
        private System.Windows.Forms.DataGridView dataGridViewChecks;
        private System.Windows.Forms.DateTimePicker dateTimePickerChecks;
        private System.Data.DataSet dataSetChecks;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSumElectron;
        private System.Windows.Forms.TextBox textBoxSumCash;
        private System.Windows.Forms.Label labelSumElectron;
        private System.Windows.Forms.Label labelSumCash;
    }
}