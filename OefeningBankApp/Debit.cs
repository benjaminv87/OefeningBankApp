using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankApp
{
    class Debit : Rekening
    {

        public Debit(string rekNummer,int saldo,string typeRekening):base(rekNummer, saldo)
        {
            TypeRekening = "Debit Rekening";
        }
    }
}
