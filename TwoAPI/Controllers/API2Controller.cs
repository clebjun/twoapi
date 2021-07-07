using Microsoft.AspNetCore.Mvc;
using System;

namespace TwoAPI.Controllers
{
    public class API2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("calculaJuros")]
        public string GetCalculoJuros(double valorInicial, int meses)
        {
            // Recupera juros da API 1
            double valorJuros = Convert.ToDouble(new API1Controller().GetTaxaJuros());
            double valorFinal = valorInicial * (Math.Pow(1 + valorJuros, meses));
            
            return string.Format("{0:0.00}", valorFinal);
        }

        [HttpGet("showMeTheCode")]
        public string ShowMeTheCode()
        {
            return "https://github.com/clebjun/twoapi.git";
        }
    }
}
