namespace OefeningBankApp
{
    partial class Form1
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
            this.lbMijnRekeningen = new System.Windows.Forms.ListBox();
            this.btnMaakNieuweRekening = new System.Windows.Forms.Button();
            this.btnOverschrijven = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lbTransacties = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMijnRekeningen
            // 
            this.lbMijnRekeningen.FormattingEnabled = true;
            this.lbMijnRekeningen.Location = new System.Drawing.Point(12, 41);
            this.lbMijnRekeningen.Name = "lbMijnRekeningen";
            this.lbMijnRekeningen.Size = new System.Drawing.Size(172, 95);
            this.lbMijnRekeningen.TabIndex = 0;
            this.lbMijnRekeningen.SelectedIndexChanged += new System.EventHandler(this.lbMijnRekeningen_SelectedIndexChanged);
            // 
            // btnMaakNieuweRekening
            // 
            this.btnMaakNieuweRekening.Location = new System.Drawing.Point(12, 12);
            this.btnMaakNieuweRekening.Name = "btnMaakNieuweRekening";
            this.btnMaakNieuweRekening.Size = new System.Drawing.Size(120, 23);
            this.btnMaakNieuweRekening.TabIndex = 1;
            this.btnMaakNieuweRekening.Text = "Nieuwe rekening";
            this.btnMaakNieuweRekening.UseVisualStyleBackColor = true;
            this.btnMaakNieuweRekening.Click += new System.EventHandler(this.btnMaakNieuweRekening_Click);
            // 
            // btnOverschrijven
            // 
            this.btnOverschrijven.Location = new System.Drawing.Point(190, 41);
            this.btnOverschrijven.Name = "btnOverschrijven";
            this.btnOverschrijven.Size = new System.Drawing.Size(82, 23);
            this.btnOverschrijven.TabIndex = 2;
            this.btnOverschrijven.Text = "Overschrijven";
            this.btnOverschrijven.UseVisualStyleBackColor = true;
            this.btnOverschrijven.Click += new System.EventHandler(this.btnOverschrijven_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Gegevens";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(83, 48);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblSaldo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saldo :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(83, 26);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(0, 13);
            this.lblAccountType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Type :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(190, 70);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(82, 23);
            this.btnVerwijderen.TabIndex = 7;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lbTransacties
            // 
            this.lbTransacties.FormattingEnabled = true;
            this.lbTransacties.Location = new System.Drawing.Point(18, 242);
            this.lbTransacties.Name = "lbTransacties";
            this.lbTransacties.Size = new System.Drawing.Size(259, 186);
            this.lbTransacties.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "TRANSACTIE GESCHIEDENIS";
            // 
            // epTextBox
            // 
            this.epTextBox.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTransacties);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOverschrijven);
            this.Controls.Add(this.btnMaakNieuweRekening);
            this.Controls.Add(this.lbMijnRekeningen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMijnRekeningen;
        private System.Windows.Forms.Button btnMaakNieuweRekening;
        private System.Windows.Forms.Button btnOverschrijven;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.ListBox lbTransacties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epTextBox;
    }
}