/* GREEN TEST */
using NUnit.Framework;

namespace APITest
{
    [TestFixture]
    public class API1ControllerTestRefactor
    {
        [Test]
        public void RetornoTaxaJuros()
        {
            var api1Controller = new TwoAPI.Controllers.API1Controller();
            Assert.AreEqual(api1Controller.GetTaxaJuros(), "0,01");
        }

    }
}