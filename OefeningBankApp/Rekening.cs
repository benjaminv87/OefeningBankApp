using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankApp
{
    public class Rekening
    {
        public List<string> transacties = new List<string>();
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

        public void overSchrijven(double bedrag)
        {
            Saldo += bedrag;
        }
        public void voegTransactieToe(bool zender, double bedrag, string rekeningNummer)
        {
            transacties.Add(((zender == true) ? "Verstuurd:" : "Ontvangen:")+$" {bedrag}€ " +((zender==true)?"naar": "van")+$" {rekeningNummer}.");
        }
    }
}
