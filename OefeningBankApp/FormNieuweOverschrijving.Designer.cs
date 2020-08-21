namespace OefeningBankApp
{
    partial class FormNieuweOverschrijving
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
            this.components = new System.ComponentModel.Container();
            this.cbRekeningen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnderRekeningNummer = new System.Windows.Forms.MaskedTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numBedrag = new System.Windows.Forms.NumericUpDown();
            this.epTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEigenRekening = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBedrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRekeningen
            // 
            this.cbRekeningen.FormattingEnabled = true;
            this.cbRekeningen.Location = new System.Drawing.Point(12, 47);
            this.cbRekeningen.Name = "cbRekeningen";
            this.cbRekeningen.Size = new System.Drawing.Size(153, 21);
            this.cbRekeningen.TabIndex = 2;
            this.cbRekeningen.SelectedIndexChanged += new System.EventHandler(this.cbRekeningen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bedrag: ";
            // 
            // tbAnderRekeningNummer
            // 
            this.tbAnderRekeningNummer.Location = new System.Drawing.Point(12, 47);
            this.tbAnderRekeningNummer.Mask = "BE00 0000 0000 0000";
            this.tbAnderRekeningNummer.Name = "tbAnderRekeningNummer";
            this.tbAnderRekeningNummer.Size = new System.Drawing.Size(153, 20);
            this.tbAnderRekeningNummer.TabIndex = 4;
            this.tbAnderRekeningNummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 105);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(127, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // numBedrag
            // 
            this.numBedrag.Location = new System.Drawing.Point(65, 79);
            this.numBedrag.Name = "numBedrag";
            this.numBedrag.Size = new System.Drawing.Size(137, 20);
            this.numBedrag.TabIndex = 7;
            this.numBedrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // epTextBox
            // 
            this.epTextBox.ContainerControl = this;
            // 
            // cbEigenRekening
            // 
            this.cbEigenRekening.AutoSize = true;
            this.cbEigenRekening.Location = new System.Drawing.Point(12, 12);
            this.cbEigenRekening.Name = "cbEigenRekening";
            this.cbEigenRekening.Size = new System.Drawing.Size(190, 17);
            this.cbEigenRekening.TabIndex = 8;
            this.cbEigenRekening.Text = "Overschrijving naar eigen rekening";
            this.cbEigenRekening.UseVisualStyleBackColor = true;
            this.cbEigenRekening.CheckedChanged += new System.EventHandler(this.cbEigenRekening_CheckedChanged);
            // 
            // FormNieuweOverschrijving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 138);
            this.Controls.Add(this.cbEigenRekening);
            this.Controls.Add(this.numBedrag);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbAnderRekeningNummer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRekeningen);
            this.Name = "FormNieuweOverschrijving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNieuweOverschrijving";
            this.Load += new System.EventHandler(this.FormNieuweOverschrijving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBedrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbRekeningen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbAnderRekeningNummer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numBedrag;
        private System.Windows.Forms.ErrorProvider epTextBox;
        private System.Windows.Forms.CheckBox cbEigenRekening;
    }
}