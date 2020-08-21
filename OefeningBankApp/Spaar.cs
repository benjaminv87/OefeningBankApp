using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankApp
{
    class Spaar :Rekening
    {
        public Spaar(string rekNummer,double saldo) : base(rekNummer, saldo)
        {
            TypeRekening = "Spaar Rekening";
        }
    }
}
