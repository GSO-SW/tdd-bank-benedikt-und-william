using System.ComponentModel.DataAnnotations;

namespace UnitTests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Konto_InputLength()
        {

        Konto_InputLength();

        int maxLength = 10;
      
        //arrange 

        Eingaben test = new (10);



        //act 

        
            test.Zeichen(25); 

        
    

        //assert

        }







        [TestMethod]
        public void Konto_UnerlaubteZeichen()
        {
            //arrange


            //act


            //assert


        }
    }
}