namespace Atol
{
    partial class FormPayment
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
            this.groupBoxSumma = new System.Windows.Forms.GroupBox();
            this.labelSumma = new System.Windows.Forms.Label();
            this.groupBoxCash = new System.Windows.Forms.GroupBox();
            this.buttonAddCash = new System.Windows.Forms.Button();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.groupBoxCard = new System.Windows.Forms.GroupBox();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.textBoxCard = new System.Windows.Forms.TextBox();
            this.groupBoxSdacha = new System.Windows.Forms.GroupBox();
            this.labelSdacha = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.groupBoxPaymentType = new System.Windows.Forms.GroupBox();
            this.radioButtonPaymentPrihod = new System.Windows.Forms.RadioButton();
            this.radioButtonPaymentVozvrat = new System.Windows.Forms.RadioButton();
            this.groupBoxSumma.SuspendLayout();
            this.groupBoxCash.SuspendLayout();
            this.groupBoxCard.SuspendLayout();
            this.groupBoxSdacha.SuspendLayout();
            this.groupBoxPaymentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSumma
            // 
            this.groupBoxSumma.Controls.Add(this.labelSumma);
            this.groupBoxSumma.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSumma.Name = "groupBoxSumma";
            this.groupBoxSumma.Size = new System.Drawing.Size(260, 51);
            this.groupBoxSumma.TabIndex = 0;
            this.groupBoxSumma.TabStop = false;
            this.groupBoxSumma.Text = "Сумма к оплате:";
            // 
            // labelSumma
            // 
            this.labelSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumma.Location = new System.Drawing.Point(6, 16);
            this.labelSumma.Name = "labelSumma";
            this.labelSumma.Size = new System.Drawing.Size(248, 23);
            this.labelSumma.TabIndex = 0;
            this.labelSumma.Text = "0";
            this.labelSumma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxCash
            // 
            this.groupBoxCash.Controls.Add(this.buttonAddCash);
            this.groupBoxCash.Controls.Add(this.textBoxCash);
            this.groupBoxCash.Location = new System.Drawing.Point(12, 69);
            this.groupBoxCash.Name = "groupBoxCash";
            this.groupBoxCash.Size = new System.Drawing.Size(260, 51);
            this.groupBoxCash.TabIndex = 1;
            this.groupBoxCash.TabStop = false;
            this.groupBoxCash.Text = "Наличными:";
            // 
            // buttonAddCash
            // 
            this.buttonAddCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCash.Location = new System.Drawing.Point(6, 16);
            this.buttonAddCash.Name = "buttonAddCash";
            this.buttonAddCash.Size = new System.Drawing.Size(36, 29);
            this.buttonAddCash.TabIndex = 1;
            this.buttonAddCash.Text = ">>";
            this.buttonAddCash.UseVisualStyleBackColor = true;
            this.buttonAddCash.Click += new System.EventHandler(this.buttonAddCash_Click);
            // 
            // textBoxCash
            // 
            this.textBoxCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCash.Location = new System.Drawing.Point(48, 16);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(206, 29);
            this.textBoxCash.TabIndex = 0;
            this.textBoxCash.Text = "0";
            this.textBoxCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCash_KeyPress);
            this.textBoxCash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCash_KeyUp);
            this.textBoxCash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCash_MouseDown);
            // 
            // groupBoxCard
            // 
            this.groupBoxCard.Controls.Add(this.buttonAddCard);
            this.groupBoxCard.Controls.Add(this.textBoxCard);
            this.groupBoxCard.Location = new System.Drawing.Point(12, 126);
            this.groupBoxCard.Name = "groupBoxCard";
            this.groupBoxCard.Size = new System.Drawing.Size(260, 51);
            this.groupBoxCard.TabIndex = 2;
            this.groupBoxCard.TabStop = false;
            this.groupBoxCard.Text = "Плат. картой:";
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCard.Location = new System.Drawing.Point(6, 16);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(36, 29);
            this.buttonAddCard.TabIndex = 1;
            this.buttonAddCard.Text = ">>";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // textBoxCard
            // 
            this.textBoxCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCard.Location = new System.Drawing.Point(48, 16);
            this.textBoxCard.Name = "textBoxCard";
            this.textBoxCard.ReadOnly = true;
            this.textBoxCard.Size = new System.Drawing.Size(206, 29);
            this.textBoxCard.TabIndex = 0;
            this.textBoxCard.Text = "0";
            this.textBoxCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCard_MouseDown);
            // 
            // groupBoxSdacha
            // 
            this.groupBoxSdacha.Controls.Add(this.labelSdacha);
            this.groupBoxSdacha.Location = new System.Drawing.Point(12, 183);
            this.groupBoxSdacha.Name = "groupBoxSdacha";
            this.groupBoxSdacha.Size = new System.Drawing.Size(260, 51);
            this.groupBoxSdacha.TabIndex = 3;
            this.groupBoxSdacha.TabStop = false;
            this.groupBoxSdacha.Text = "Сдача:";
            // 
            // labelSdacha
            // 
            this.labelSdacha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSdacha.Location = new System.Drawing.Point(6, 16);
            this.labelSdacha.Name = "labelSdacha";
            this.labelSdacha.Size = new System.Drawing.Size(248, 23);
            this.labelSdacha.TabIndex = 0;
            this.labelSdacha.Text = "0";
            this.labelSdacha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPay
            // 
            this.buttonPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPay.Location = new System.Drawing.Point(12, 297);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(260, 37);
            this.buttonPay.TabIndex = 4;
            this.buttonPay.Text = "Оплата";
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // groupBoxPaymentType
            // 
            this.groupBoxPaymentType.Controls.Add(this.radioButtonPaymentVozvrat);
            this.groupBoxPaymentType.Controls.Add(this.radioButtonPaymentPrihod);
            this.groupBoxPaymentType.Location = new System.Drawing.Point(12, 240);
            this.groupBoxPaymentType.Name = "groupBoxPaymentType";
            this.groupBoxPaymentType.Size = new System.Drawing.Size(260, 51);
            this.groupBoxPaymentType.TabIndex = 6;
            this.groupBoxPaymentType.TabStop = false;
            // 
            // radioButtonPaymentPrihod
            // 
            this.radioButtonPaymentPrihod.AutoSize = true;
            this.radioButtonPaymentPrihod.Checked = true;
            this.radioButtonPaymentPrihod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPaymentPrihod.Location = new System.Drawing.Point(10, 19);
            this.radioButtonPaymentPrihod.Name = "radioButtonPaymentPrihod";
            this.radioButtonPaymentPrihod.Size = new System.Drawing.Size(72, 20);
            this.radioButtonPaymentPrihod.TabIndex = 6;
            this.radioButtonPaymentPrihod.TabStop = true;
            this.radioButtonPaymentPrihod.Text = "приход";
            this.radioButtonPaymentPrihod.UseVisualStyleBackColor = true;
            this.radioButtonPaymentPrihod.CheckedChanged += new System.EventHandler(this.radioButtonPaymentPrihod_CheckedChanged);
            // 
            // radioButtonPaymentVozvrat
            // 
            this.radioButtonPaymentVozvrat.AutoSize = true;
            this.radioButtonPaymentVozvrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPaymentVozvrat.Location = new System.Drawing.Point(146, 19);
            this.radioButtonPaymentVozvrat.Name = "radioButtonPaymentVozvrat";
            this.radioButtonPaymentVozvrat.Size = new System.Drawing.Size(81, 20);
            this.radioButtonPaymentVozvrat.TabIndex = 7;
            this.radioButtonPaymentVozvrat.Text = "возврат";
            this.radioButtonPaymentVozvrat.UseVisualStyleBackColor = true;
            this.radioButtonPaymentVozvrat.CheckedChanged += new System.EventHandler(this.radioButtonPaymentVozvrat_CheckedChanged);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 346);
            this.Controls.Add(this.groupBoxPaymentType);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.groupBoxSdacha);
            this.Controls.Add(this.groupBoxCard);
            this.Controls.Add(this.groupBoxCash);
            this.Controls.Add(this.groupBoxSumma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оплата";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPayment_FormClosing);
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.groupBoxSumma.ResumeLayout(false);
            this.groupBoxCash.ResumeLayout(false);
            this.groupBoxCash.PerformLayout();
            this.groupBoxCard.ResumeLayout(false);
            this.groupBoxCard.PerformLayout();
            this.groupBoxSdacha.ResumeLayout(false);
            this.groupBoxPaymentType.ResumeLayout(false);
            this.groupBoxPaymentType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSumma;
        private System.Windows.Forms.Label labelSumma;
        private System.Windows.Forms.GroupBox groupBoxCash;
        private System.Windows.Forms.Button buttonAddCash;
        private System.Windows.Forms.GroupBox groupBoxCard;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.GroupBox groupBoxSdacha;
        private System.Windows.Forms.Label labelSdacha;
        private System.Windows.Forms.Button buttonPay;
        public System.Windows.Forms.TextBox textBoxCash;
        public System.Windows.Forms.TextBox textBoxCard;
        private System.Windows.Forms.GroupBox groupBoxPaymentType;
        private System.Windows.Forms.RadioButton radioButtonPaymentPrihod;
        public System.Windows.Forms.RadioButton radioButtonPaymentVozvrat;
    }
}