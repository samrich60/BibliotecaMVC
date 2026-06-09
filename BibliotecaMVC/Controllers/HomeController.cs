using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Acervo()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}