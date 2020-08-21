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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Rekening> mijnRekeningen = new List<Rekening>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Rekening nieuweRekening = new Debit(GenereerRekeningNummer(),10000) ;
            mijnRekeningen.Add(nieuweRekening);
            lbMijnRekeningen.DataSource = mijnRekeningen;
        }
        private void lbMijnRekeningen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMijnRekeningen.SelectedIndex > -1)
            {
                Rekening mijnRekening = (Rekening)lbMijnRekeningen.SelectedItem;
                lblAccountType.Text = mijnRekening.TypeRekening;
                lblSaldo.Text = Convert.ToString(mijnRekening.Saldo);
                btnOverschrijven.Enabled = mijnRekening.Saldo == 0 && mijnRekening.TypeRekening.ToLower() != "credit rekening" ?  false :true ;
                btnVerwijderen.Visible = mijnRekening.Saldo == 0 ?true : false;
                lbTransacties.DataSource = mijnRekening.transacties;
            }
        }

        private string GenereerRekeningNummer()
        {
            string rekNummer = "BE";
            Random rnd = new Random();
            while (rekNummer.Length<16)
            {
                rekNummer += rnd.Next(0,9).ToString();
            }

            for (int i = 4; i <rekNummer.Length; i+=5)
            {
                rekNummer = rekNummer.Insert(i, " ");
            }


            return rekNummer;
        }

        private void btnMaakNieuweRekening_Click(object sender, EventArgs e)
        {
            using(FormNieuweRekening nieuweForm = new FormNieuweRekening())
            {
                if (nieuweForm.ShowDialog() == DialogResult.OK)
                {
                    string typeRekening = nieuweForm.typeRekening;
                    Rekening mijnRekening;
                    switch (typeRekening)
                    {
                        case "Debit Rekening":
                            mijnRekening = new Debit(GenereerRekeningNummer(),0) ;
                            break;
                        case "Spaar Rekening":
                            mijnRekening = new Spaar(GenereerRekeningNummer(), 0);
                            break;
                        case "Credit Rekening":
                            mijnRekening = new Credit(GenereerRekeningNummer(), 0);
                            break;
                        default:
                            mijnRekening = new Rekening("ERROR",-1);
                            break;
                    }
                    mijnRekeningen.Add(mijnRekening);
                }
                lbMijnRekeningen.DataSource = null;
                lbMijnRekeningen.DataSource = mijnRekeningen;
            }
        }

        private void btnOverschrijven_Click(object sender, EventArgs e)
        {
             if (lbMijnRekeningen.SelectedIndex > -1)
            {
                Rekening mijnRekening = (Rekening)lbMijnRekeningen.SelectedItem;
                using (FormNieuweOverschrijving nieuweForm = new FormNieuweOverschrijving(mijnRekeningen,mijnRekening))
                {
                    if (nieuweForm.ShowDialog() == DialogResult.OK)
                    {
                        Rekening andereRekening = new Rekening(nieuweForm.rekeningNummer,0);

                            foreach (var item in mijnRekeningen)
                            {
                                if(item.RekNummer == nieuweForm.rekeningNummer)
                                {
                                   andereRekening = item;
                                } 
                            }
                        DialogResult result = (MessageBox.Show($"Wil je {nieuweForm.bedrag} overschrijven naar {andereRekening.RekNummer}?", "Overschrijving uitvoeren", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));
                       if (result == DialogResult.OK)
                        {
                            mijnRekening.overSchrijven(-nieuweForm.bedrag);
                            mijnRekening.voegTransactieToe(true, nieuweForm.bedrag, andereRekening.RekNummer);
                            andereRekening.overSchrijven(nieuweForm.bedrag);
                            andereRekening.voegTransactieToe(false, nieuweForm.bedrag, mijnRekening.RekNummer);
                            lbTransacties.DataSource = null;
                            lbTransacties.DataSource = mijnRekening.transacties;
                        }

                    }
                }
            }
            else epTextBox.SetError(lbMijnRekeningen, "Selecteer een rekeningnummer");
            lbMijnRekeningen.DataSource = null;
            lbMijnRekeningen.DataSource = mijnRekeningen;
            
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ben je zeker dat je wil verwijderen?","Verwijderen?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                mijnRekeningen.RemoveAt(lbMijnRekeningen.SelectedIndex);
                lbMijnRekeningen.DataSource = null;
                lbMijnRekeningen.DataSource = mijnRekeningen;
            }
            lbMijnRekeningen.DataSource = null;
            lbMijnRekeningen.DataSource = mijnRekeningen;
        }
    }
}
