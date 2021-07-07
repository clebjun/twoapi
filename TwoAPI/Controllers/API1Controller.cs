using Microsoft.AspNetCore.Mvc;

namespace TwoAPI.Controllers
{
    public class API1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		[HttpGet("taxaJuros")]
		public string GetTaxaJuros()
		{
            return string.Format("{0:N}", 0.01); 
		}
	}
}
