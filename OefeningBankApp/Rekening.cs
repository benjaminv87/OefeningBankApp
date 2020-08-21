using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankApp
{
    class Rekening
    {
        public string RekNummer;
        public int Saldo;
        public string TypeRekening;
        public Rekening(string rekNummer, int saldo)
        {
            RekNummer = rekNummer;
            Saldo = saldo;
        }

        public override string ToString()
        {
            return RekNummer;
        }
    }
}
