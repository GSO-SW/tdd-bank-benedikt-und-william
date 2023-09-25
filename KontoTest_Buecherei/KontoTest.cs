using Buecherei;
namespace KontoTest_Buecherei
{
    [TestClass]
    public class KontoTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StatischeKontonummer_Konto()
        {
            //arrange
            string Kundennummer = "1";
            string StandardBankleitzahl = "1023";
            string NeueKundennummer = "2";

            Konto test = new Konto(Kundennummer, StandardBankleitzahl);

            //act
            test.StatischeKundennummer(NeueKundennummer);

        }




        [TestMethod]
        public void IdentischeBankleitzahl_Konto()
        {
            //arrange
            string Kundennummer = "1";
            string StandardBankleitzahl = "1023";
            string KontoBankleitzahl = "1023";

            Konto test = new Konto(Kundennummer, KontoBankleitzahl);

            //act
            test.VergebungVonBankleitzahl(KontoBankleitzahl);

            //assert
            Assert.AreEqual(StandardBankleitzahl, KontoBankleitzahl);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GültigerSyntaxInDerErstellung_Konto()
        {
            //arrange
            string Kundennummer = "1000000000";
            string KontoBankleitzahl = "111B";

            Konto test = new Konto(Kundennummer, KontoBankleitzahl);

            //act
            test.KorrekterSyntaxKonto(Kundennummer, KontoBankleitzahl);

        }

        [TestMethod]
        public void EnthältSyntaxGemässEineIBAN()
        {
            //arrange
            string Kundennummer = "9";
            string KontoBankleitzahl = "123";

            Konto test = new Konto(Kundennummer, KontoBankleitzahl);

            //act
            test.IBANVergabe();




        }
    }
}