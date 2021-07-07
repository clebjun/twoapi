/* RED TEST */
using NUnit.Framework;

namespace APITest
{
    [TestFixture]
    public class API1ControllerTestRed
    {
        [Test]
        public void RetornoTaxaJuros()
        {
            var api1Controller = new TwoAPI.Controllers.API1Controller();
            var result = api1Controller.GetTaxaJuros();

            Assert.AreEqual(result, "0,10");
        }

    }
}