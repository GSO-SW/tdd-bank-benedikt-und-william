using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buecherei
{
    public class Konto
    {
        private int kontonummer;
        private int bankleitzahl;
        private int iBAN;

        public int Kontonummer
        {
            get
            {
                return kontonummer;
            }
        }

        public int Bankleitzahl
        {
            get
            {
                return bankleitzahl;
            }
        }

        public int IBAN
        {
            get
            {
                return iBAN;
            }
        }
        public Konto(int kontonummer)
        {
            this.kontonummer = kontonummer;

        }

        public void BankleitzahlZuweisung(int ZuweisungBank)
        {
            bankleitzahl = ZuweisungBank;
        }

        public void WrongInput(int Kontonummer, int Bankleitzahl)
        {

        }

    }
}
