using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buecherei
{
    public class Konto
    {
        private string kundennummer;
        private string bankleitzahl;
        private int iBAN;

        public string Kundennummer
        {
            get
            {
                return kundennummer;
            }
        }

        public string Bankleitzahl
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
        public Konto(string kundennummer, string bankleitzahl)
        {
            this.kundennummer = kundennummer;
            this.bankleitzahl = bankleitzahl;
        }

        public void StatischeKundennummer(string Kundennummer)
        {
            if (!this.kundennummer.Equals(Kundennummer))
            {
                throw new ArgumentOutOfRangeException("Kundennummer kann nicht geändert werden");
            }

        }

        public void VergebungVonBankleitzahl(string Standardleitzahl)
        {
            bankleitzahl = Standardleitzahl;
        }

        public void KorrekterSyntaxKonto(string Kundennummer, string Bankleitzahl)
        {
            if (Kundennummer.Any(char.IsLetter) || Bankleitzahl.Any(char.IsLetter) || Kundennummer.Length > 10)
            {
                throw new ArgumentOutOfRangeException("Kundennummer entspricht nicht dem Syntax");
            }
            else
            {
                kundennummer = Kundennummer;
                bankleitzahl = Bankleitzahl;
            }
        }

        public int IBANVergabe()
        {
            int IBAN = int.Parse(this.kundennummer + this.bankleitzahl);

            if (IBAN.Equals(this.kundennummer + this.bankleitzahl))
            {
                return IBAN;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Fehlgeschlagene Zusammentsetung von IBAN");
            }



        }


    }
}
