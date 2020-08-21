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
            Rekening nieuweRekening = new Credit(GenereerRekeningNummer(),10000) ;
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
    }
}
