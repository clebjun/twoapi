/* GREEN TEST */
using NUnit.Framework;
using TwoAPI;

namespace APITest
{
    [TestFixture]
    public class API2ControllerTestRefactor
    {

        [Test]
        public void ReturnTheCode()
        {
            var api2Controller = new TwoAPI.Controllers.API2Controller();
            Assert.AreEqual("https://github.com/clebjun/twoapi.git", api2Controller.ShowMeTheCode());
        }

        [Test]
        [TestCase(100, 5, "105,10")]
        [TestCase(1000, 10, "1104,62")] 
        [TestCase(500, 20, "610,10")] 
        public void CalcularJuros(double valorInicial, int meses, string resultadoEsperado)
        {
            var api2Controller = new TwoAPI.Controllers.API2Controller().GetCalculoJuros(valorInicial, meses);
            Assert.AreEqual(resultadoEsperado, api2Controller.ToString());
        }
    }
}