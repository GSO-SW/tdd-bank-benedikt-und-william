using Bank;
namespace KontoTest
{
    [TestClass]
    public class KontoTest
    {
        [TestMethod]
        public void Konto_GuthabenEinzahlen()
        {
            //arrange
            Konto test = new Konto(100);

            //act
            test.Einzahlen(50);

            //assert
            Assert.AreNotEqual(50, test.Guthaben);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Konto_GuthabenAuszahlen()
        {
            //arrange
            Konto test = new Konto(200);

            //act
            test.Auszahlen(250);
        }
    }
}