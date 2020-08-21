using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningBankApp
{
    public partial class FormNieuweRekening : Form
    {
        public FormNieuweRekening()
        {
            InitializeComponent();
        }
        List<string> typesRekening = new List<string>() { "Debit Rekening", "Spaar Rekening", "Credit Rekening" };
        public string typeRekening;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbTypeRekening.SelectedIndex > -1)
            {
                typeRekening = cbTypeRekening.Text;
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Selecteer een type rekening");
        }

        private void FormNieuweRekening_Load(object sender, EventArgs e)
        {
            cbTypeRekening.DataSource = typesRekening;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
