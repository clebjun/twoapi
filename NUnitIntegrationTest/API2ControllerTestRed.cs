/* RED TEST */
using NUnit.Framework;
using TwoAPI;

namespace APITest
{
    [TestFixture]
    public class API2ControllerTestRed
    {

        [Test]
        public void ReturnTheCode()
        {
            var api2Controller = new TwoAPI.Controllers.API2Controller();
            var result = api2Controller.ShowMeTheCode();

            Assert.AreEqual("https://github.com/clebjun/twoapi.git", result);
        }

        [Test]
        [TestCase(100, 5, "106,10")]
        [TestCase(1000, 10, "1115,62")] 
        [TestCase(500, 20, "650,10")] 
        public void CalcularJuros(double valorInicial, int meses, string resultadoEsperado)
        {
            var api2Controller = new TwoAPI.Controllers.API2Controller();
            var result = api2Controller.GetCalculoJuros(valorInicial, meses);

            Assert.AreEqual(resultadoEsperado, result.ToString());
        }
    }
}