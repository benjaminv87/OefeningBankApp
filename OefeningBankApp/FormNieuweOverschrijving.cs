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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tbBedrag.Text) <= mijnRekening.Saldo || mijnRekening.TypeRekening == "Credit Rekening")
            {
                if (rekeningNummer != "" && Convert.ToDouble(tbBedrag.Text) > 0)
                {
                    DialogResult = DialogResult.OK;
                    if (!rbEigenRekening.Checked) rekeningNummer = tbAnderRekeningNummer.Text;
                    bedrag = Convert.ToDouble(tbBedrag.Text);
                }
                else MessageBox.Show("Geef geldige waarden voor over te schrijven bedrag en rekeningnummer");
            }
            else
            {
                MessageBox.Show($"Je kan maximum €{mijnRekening.Saldo} overschrijven");
            }
        }

        private void rbEigenRekening_Click(object sender, EventArgs e)
        {
            if (!rbEigenRekening.Checked)
            {
                tbAnderRekeningNummer.Visible = false;
                cbRekeningen.Visible = true;
                rbEigenRekening.Checked = true;
            }
            else
            {
                tbAnderRekeningNummer.Visible = true;
                cbRekeningen.Visible = false;
                rbEigenRekening.Checked = false;
            }
        }
    }
}
