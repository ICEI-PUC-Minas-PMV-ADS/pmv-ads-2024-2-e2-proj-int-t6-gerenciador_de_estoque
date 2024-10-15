using Microsoft.AspNetCore.Mvc;
using StockUp.Models;
using System.Diagnostics;

namespace StockUp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Comments to commit
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Privacy2()
        {
            return View();
        }

        public IActionResult DashboardTabela()
        {
            return View();

        }

        public IActionResult EditarProduto()
        {
            return View();

        }

        public IActionResult InformacoesDoProduto()
        {
            return View();

        }

        public IActionResult Templates()
        {
            return View();

        }
		public IActionResult CadastrarSenha()
		{
			return View();

		}




		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
