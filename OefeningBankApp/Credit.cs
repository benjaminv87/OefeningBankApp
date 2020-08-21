using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankApp
{
    class Credit : Rekening
    {
        public int CvcCode;

        public Credit(string rekNummer, int saldo) : base(rekNummer, saldo)
        {
            CvcCode = GenerateCVC();
            TypeRekening = "Credit Rekening";
        }
        public int GenerateCVC()
        {
            int cvc= 0;
            Random rnd = new Random();
            cvc = Convert.ToInt32(cvc.ToString() + rnd.Next(0, 9).ToString());
            return cvc;
        }
    }
}
