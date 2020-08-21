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
    public partial class FormNieuweOverschrijving : Form
    {

        public FormNieuweOverschrijving(List<Rekening> MijnLijst,Rekening MijnRekening)
        {
            InitializeComponent();
            this.mijnRekening = MijnRekening;
            this.mijnLijst = MijnLijst;
        }

        public string rekeningNummer;
        public double bedrag;
        public List<Rekening> mijnLijst;
        public Rekening mijnRekening;

        private void cbRekeningen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRekeningen.SelectedIndex > -1)
            {
                rekeningNummer = cbRekeningen.SelectedItem.ToString();
            }
        }

        private void FormNieuweOverschrijving_Load(object sender, EventArgs e)
        {
            foreach (Rekening item in mijnLijst)
            {
                if (item.RekNummer != mijnRekening.RekNummer) cbRekeningen.Items.Add(item.RekNummer);
            }
            numBedrag.Maximum = 100000;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
 
            if (Convert.ToDouble(numBedrag.Value) <= mijnRekening.Saldo || mijnRekening.TypeRekening == "Credit Rekening")
            {
                if (rekeningNummer != "" && Convert.ToDouble(numBedrag.Value) > 0)
                {
                    DialogResult = DialogResult.OK;
                    if (!cbEigenRekening.Checked) rekeningNummer = tbAnderRekeningNummer.Text;
                    bedrag = Convert.ToDouble(numBedrag.Value);
                }
                else if (numBedrag.Value == 0) epTextBox.SetError(btnOK, "Geef een bedrag groter dan 0");
                else if (rekeningNummer == "") epTextBox.SetError(btnOK, "Geef een bedrag groter dan 0");
            }
            else
            {
                MessageBox.Show($"Je kan maximum €{mijnRekening.Saldo} overschrijven");
            }
        }



        private void cbEigenRekening_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEigenRekening.Checked)
            {
                tbAnderRekeningNummer.Visible = false;
                cbRekeningen.Visible = true;
            }
            else
            {
                tbAnderRekeningNummer.Visible = true;
                cbRekeningen.Visible = false;
            }
        }
    }
}
