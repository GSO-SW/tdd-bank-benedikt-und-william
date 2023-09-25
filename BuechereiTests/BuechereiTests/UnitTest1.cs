using Buecherei;
namespace BuechereiTests
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void IdentischeBankleitzahl_Konto()
        {
            //arrange
            int BankleitzahlStandard = 1;
            int Kontonummer = 10;


            Konto test = new Konto(Kontonummer);

            //act
            test.BankleitzahlZuweisung(1);


            //assert 
            Assert.AreEqual(BankleitzahlStandard, test.Bankleitzahl);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UnerlaubtOderZuVieleZeichen_Konto()
        {
            //arrange
            Konto test = new Konto(12);

            //act
            test.

        }

    }
}