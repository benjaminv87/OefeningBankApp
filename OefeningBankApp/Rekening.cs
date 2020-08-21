using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankApp
{
    public class Rekening
    {
        public string RekNummer;
        public double Saldo;
        public string TypeRekening;
        public Rekening(string rekNummer, double saldo)
        {
            RekNummer = rekNummer;
            Saldo = saldo;
        }

        public override string ToString()
        {
            return RekNummer;
        }

        public double overSchrijven(double bedrag)
        {
            Saldo -= bedrag;
            return bedrag;
        }
    }
}
