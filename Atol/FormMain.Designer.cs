namespace Atol
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxsQty = new System.Windows.Forms.GroupBox();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDateTime = new System.Windows.Forms.GroupBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonZReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNDS = new System.Windows.Forms.ComboBox();
            this.dataSetProducts = new System.Data.DataSet();
            this.groupBoxDiscount = new System.Windows.Forms.GroupBox();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
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
            this.dataGridViewChecks = new System.Windows.Forms.DataGridView();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.buttonXReport = new System.Windows.Forms.Button();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.номенклатураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрЧековToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.кКТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNDSValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxsQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.groupBoxDateTime.SuspendLayout();
            this.groupBoxTitle.SuspendLayout();
            this.groupBoxPrice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProducts)).BeginInit();
            this.groupBoxDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChecks)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(12, 478);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(910, 34);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxsQty
            // 
            this.groupBoxsQty.Controls.Add(this.numericUpDownQty);
            this.groupBoxsQty.Location = new System.Drawing.Point(12, 147);
            this.groupBoxsQty.Name = "groupBoxsQty";
            this.groupBoxsQty.Size = new System.Drawing.Size(133, 55);
            this.groupBoxsQty.TabIndex = 1;
            this.groupBoxsQty.TabStop = false;
            this.groupBoxsQty.Text = "Количество:";
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.DecimalPlaces = 1;
            this.numericUpDownQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownQty.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(121, 26);
            this.numericUpDownQty.TabIndex = 2;
            this.numericUpDownQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxDateTime
            // 
            this.groupBoxDateTime.Controls.Add(this.labelDateTime);
            this.groupBoxDateTime.Location = new System.Drawing.Point(12, 32);
            this.groupBoxDateTime.Name = "groupBoxDateTime";
            this.groupBoxDateTime.Size = new System.Drawing.Size(910, 48);
            this.groupBoxDateTime.TabIndex = 2;
            this.groupBoxDateTime.TabStop = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateTime.Location = new System.Drawing.Point(6, 10);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(898, 32);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "00:00";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(6, 17);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(898, 28);
            this.comboBoxProduct.Sorted = true;
            this.comboBoxProduct.TabIndex = 1;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.Controls.Add(this.comboBoxProduct);
            this.groupBoxTitle.Location = new System.Drawing.Point(12, 86);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(910, 55);
            this.groupBoxTitle.TabIndex = 0;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Наименование:";
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.textBoxPrice);
            this.groupBoxPrice.Location = new System.Drawing.Point(151, 147);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(133, 55);
            this.groupBoxPrice.TabIndex = 2;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Цена c НДС:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(6, 19);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(119, 26);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPrice_KeyDown);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(670, 147);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(252, 55);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(803, 218);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(119, 30);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(803, 254);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 30);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.Location = new System.Drawing.Point(803, 313);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(119, 54);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Чек";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonZReport
            // 
            this.buttonZReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZReport.Location = new System.Drawing.Point(803, 433);
            this.buttonZReport.Name = "buttonZReport";
            this.buttonZReport.Size = new System.Drawing.Size(119, 30);
            this.buttonZReport.TabIndex = 10;
            this.buttonZReport.Text = "Z отчет";
            this.buttonZReport.UseVisualStyleBackColor = true;
            this.buttonZReport.Click += new System.EventHandler(this.buttonZReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxNDS);
            this.groupBox1.Location = new System.Drawing.Point(290, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "НДС:";
            // 
            // comboBoxNDS
            // 
            this.comboBoxNDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNDS.FormattingEnabled = true;
            this.comboBoxNDS.Items.AddRange(new object[] {
            "НДС 0%",
            "НДС 10%",
            "НДС 18%",
            "Без НДС"});
            this.comboBoxNDS.Location = new System.Drawing.Point(6, 17);
            this.comboBoxNDS.Name = "comboBoxNDS";
            this.comboBoxNDS.Size = new System.Drawing.Size(172, 28);
            this.comboBoxNDS.TabIndex = 4;
            // 
            // dataSetProducts
            // 
            this.dataSetProducts.DataSetName = "dataSetProducts";
            // 
            // groupBoxDiscount
            // 
            this.groupBoxDiscount.Controls.Add(this.comboBoxDiscount);
            this.groupBoxDiscount.Location = new System.Drawing.Point(480, 147);
            this.groupBoxDiscount.Name = "groupBoxDiscount";
            this.groupBoxDiscount.Size = new System.Drawing.Size(184, 55);
            this.groupBoxDiscount.TabIndex = 4;
            this.groupBoxDiscount.TabStop = false;
            this.groupBoxDiscount.Text = "Скидка:";
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Items.AddRange(new object[] {
            "НДС 0%",
            "НДС 10%",
            "НДС 18%",
            "Без НДС"});
            this.comboBoxDiscount.Location = new System.Drawing.Point(6, 17);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(172, 28);
            this.comboBoxDiscount.TabIndex = 5;
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
            // dataGridViewChecks
            // 
            this.dataGridViewChecks.AllowUserToAddRows = false;
            this.dataGridViewChecks.AllowUserToDeleteRows = false;
            this.dataGridViewChecks.AllowUserToResizeRows = false;
            this.dataGridViewChecks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChecks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChecks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChecks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduct,
            this.ColumnPrice,
            this.ColumnQty,
            this.ColumnSumma,
            this.ColumnNDS,
            this.ColumnDiscount,
            this.ColumnNDSValue,
            this.ColumnDiscountValue});
            this.dataGridViewChecks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewChecks.Location = new System.Drawing.Point(12, 218);
            this.dataGridViewChecks.MultiSelect = false;
            this.dataGridViewChecks.Name = "dataGridViewChecks";
            this.dataGridViewChecks.RowHeadersVisible = false;
            this.dataGridViewChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChecks.Size = new System.Drawing.Size(785, 245);
            this.dataGridViewChecks.TabIndex = 12;
            this.dataGridViewChecks.TabStop = false;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // buttonXReport
            // 
            this.buttonXReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXReport.Location = new System.Drawing.Point(803, 397);
            this.buttonXReport.Name = "buttonXReport";
            this.buttonXReport.Size = new System.Drawing.Size(119, 30);
            this.buttonXReport.TabIndex = 14;
            this.buttonXReport.Text = "X отчет";
            this.buttonXReport.UseVisualStyleBackColor = true;
            this.buttonXReport.Click += new System.EventHandler(this.buttonXReport_Click);
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItemFile.Text = "Файл";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItemExit.Text = "Выход";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номенклатураToolStripMenuItem,
            this.реестрЧековToolStripMenuItem,
            this.кКТToolStripMenuItem});
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(79, 20);
            this.ToolStripMenuItemSettings.Text = "Настройки";
            // 
            // номенклатураToolStripMenuItem
            // 
            this.номенклатураToolStripMenuItem.Name = "номенклатураToolStripMenuItem";
            this.номенклатураToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.номенклатураToolStripMenuItem.Text = "Номенклатура";
            this.номенклатураToolStripMenuItem.Click += new System.EventHandler(this.номенклатураToolStripMenuItem_Click);
            // 
            // реестрЧековToolStripMenuItem
            // 
            this.реестрЧековToolStripMenuItem.Name = "реестрЧековToolStripMenuItem";
            this.реестрЧековToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.реестрЧековToolStripMenuItem.Text = "Реестр чеков";
            this.реестрЧековToolStripMenuItem.Click += new System.EventHandler(this.реестрЧековToolStripMenuItem_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemSettings});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(932, 24);
            this.menuStripMain.TabIndex = 13;
            this.menuStripMain.Text = "Меню";
            // 
            // кКТToolStripMenuItem
            // 
            this.кКТToolStripMenuItem.Name = "кКТToolStripMenuItem";
            this.кКТToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.кКТToolStripMenuItem.Text = "ККТ";
            this.кКТToolStripMenuItem.Click += new System.EventHandler(this.кКТToolStripMenuItem_Click);
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProduct.FillWeight = 274.5371F;
            this.ColumnProduct.HeaderText = "Наименование";
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPrice.FillWeight = 60.00393F;
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnQty
            // 
            this.ColumnQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnQty.FillWeight = 60.3604F;
            this.ColumnQty.HeaderText = "Количество";
            this.ColumnQty.Name = "ColumnQty";
            this.ColumnQty.ReadOnly = true;
            this.ColumnQty.Width = 80;
            // 
            // ColumnSumma
            // 
            this.ColumnSumma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSumma.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnSumma.FillWeight = 76.14214F;
            this.ColumnSumma.HeaderText = "Сумма";
            this.ColumnSumma.Name = "ColumnSumma";
            this.ColumnSumma.ReadOnly = true;
            // 
            // ColumnNDS
            // 
            this.ColumnNDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnNDS.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnNDS.FillWeight = 67.24332F;
            this.ColumnNDS.HeaderText = "НДС";
            this.ColumnNDS.Name = "ColumnNDS";
            this.ColumnNDS.ReadOnly = true;
            this.ColumnNDS.Width = 80;
            // 
            // ColumnDiscount
            // 
            this.ColumnDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnDiscount.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnDiscount.FillWeight = 61.71318F;
            this.ColumnDiscount.HeaderText = "Скидка";
            this.ColumnDiscount.Name = "ColumnDiscount";
            this.ColumnDiscount.ReadOnly = true;
            this.ColumnDiscount.Width = 80;
            // 
            // ColumnNDSValue
            // 
            this.ColumnNDSValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnNDSValue.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnNDSValue.HeaderText = "НДС-значение";
            this.ColumnNDSValue.Name = "ColumnNDSValue";
            this.ColumnNDSValue.ReadOnly = true;
            this.ColumnNDSValue.Visible = false;
            // 
            // ColumnDiscountValue
            // 
            this.ColumnDiscountValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnDiscountValue.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnDiscountValue.HeaderText = "Скидка-значение";
            this.ColumnDiscountValue.Name = "ColumnDiscountValue";
            this.ColumnDiscountValue.ReadOnly = true;
            this.ColumnDiscountValue.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.buttonXReport);
            this.Controls.Add(this.dataGridViewChecks);
            this.Controls.Add(this.groupBoxDiscount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonZReport);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxPrice);
            this.Controls.Add(this.groupBoxTitle);
            this.Controls.Add(this.groupBoxDateTime);
            this.Controls.Add(this.groupBoxsQty);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АТОЛ - печать чеков";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxsQty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.groupBoxDateTime.ResumeLayout(false);
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProducts)).EndInit();
            this.groupBoxDiscount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChecks)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxsQty;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.GroupBox groupBoxDateTime;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.GroupBox groupBoxTitle;
        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonZReport;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxNDS;
        private System.Data.DataSet dataSetProducts;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.GroupBox groupBoxDiscount;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Data.DataSet dataSetChecks;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridView dataGridViewChecks;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Button buttonXReport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem номенклатураToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.ToolStripMenuItem реестрЧековToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кКТToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNDSValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscountValue;
    }
}

