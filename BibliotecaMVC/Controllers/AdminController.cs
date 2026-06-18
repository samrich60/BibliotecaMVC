using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly BibliotecaContext _context;

        public AdminController(BibliotecaContext context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Login()
        {
            // Se já estiver logado, vai pro dashboard
            if (HttpContext.Session.GetString("AdminLogado") == "true")
                return RedirectToAction("Dashboard");

            return View();
        }

        // POST: Login
        [HttpPost]
        public IActionResult Login(string usuario, string senha)
        {
            var admin = _context.Admins
                .FirstOrDefault(a => a.Usuario == usuario && a.Senha == senha);

            if (admin != null)
            {
                HttpContext.Session.SetString("AdminLogado", "true");
                HttpContext.Session.SetString("AdminUsuario", admin.Usuario);
                return RedirectToAction("Dashboard");
            }

            ViewBag.Erro = "Usuário ou senha incorretos!";
            return View();
        }

        // Dashboard
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("AdminLogado") != "true")
                return RedirectToAction("Login");

            ViewBag.TotalLivros = _context.Livros.Count();
            ViewBag.LivrosDisponiveis = _context.Livros.Count(l => l.Disponivel);
            ViewBag.LivrosEmprestados = _context.Livros.Count(l => !l.Disponivel);
            ViewBag.Usuario = HttpContext.Session.GetString("AdminUsuario");

            return View();
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}