using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly BibliotecaContext _context;

        public HomeController(BibliotecaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public async Task<IActionResult> Acervo(string busca, string categoria)
        {
            var livros = _context.Livros.AsQueryable();

            if (!string.IsNullOrEmpty(busca))
                livros = livros.Where(l =>
                    l.Titulo.Contains(busca) ||
                    l.Autor.Contains(busca) ||
                    l.Categoria.Contains(busca));

            if (!string.IsNullOrEmpty(categoria))
                livros = livros.Where(l => l.Categoria == categoria);

            ViewBag.Busca = busca;
            ViewBag.Categoria = categoria;
            ViewBag.Categorias = await _context.Livros
                .Select(l => l.Categoria)
                .Distinct()
                .ToListAsync();

            return View(await livros.ToListAsync());
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}