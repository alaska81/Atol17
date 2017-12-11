namespace Atol
{
    partial class FormKKM
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
            this.groupBoxCOMPort = new System.Windows.Forms.GroupBox();
            this.textBoxCOMPort = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxCOMPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCOMPort
            // 
            this.groupBoxCOMPort.Controls.Add(this.textBoxCOMPort);
            this.groupBoxCOMPort.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCOMPort.Name = "groupBoxCOMPort";
            this.groupBoxCOMPort.Size = new System.Drawing.Size(260, 54);
            this.groupBoxCOMPort.TabIndex = 0;
            this.groupBoxCOMPort.TabStop = false;
            this.groupBoxCOMPort.Text = "COM Порт:";
            // 
            // textBoxCOMPort
            // 
            this.textBoxCOMPort.Location = new System.Drawing.Point(6, 19);
            this.textBoxCOMPort.Name = "textBoxCOMPort";
            this.textBoxCOMPort.Size = new System.Drawing.Size(248, 20);
            this.textBoxCOMPort.TabIndex = 0;
            this.textBoxCOMPort.Text = "0";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(61, 100);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(162, 35);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // FormKKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxCOMPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKKM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormKKM";
            this.groupBoxCOMPort.ResumeLayout(false);
            this.groupBoxCOMPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCOMPort;
        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.TextBox textBoxCOMPort;
    }
}