using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaMVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly BibliotecaContext _context;

        public LivrosController(BibliotecaContext context)
        {
            _context = context;
        }

        // Verifica se está logado
        private bool AdminLogado()
        {
            return HttpContext.Session.GetString("AdminLogado") == "true";
        }

        // GET: Livros - Listagem com pesquisa
        public async Task<IActionResult> Index(string busca)
        {
            if (!AdminLogado()) return RedirectToAction("Login", "Admin");

            var livros = _context.Livros.AsQueryable();

            if (!string.IsNullOrEmpty(busca))
                livros = livros.Where(l =>
                    l.Titulo.Contains(busca) ||
                    l.Autor.Contains(busca) ||
                    l.Categoria.Contains(busca));

            ViewBag.Busca = busca;
            return View(await livros.ToListAsync());
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            if (!AdminLogado()) return RedirectToAction("Login", "Admin");
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Livro livro)
        {
            if (!AdminLogado()) return RedirectToAction("Login", "Admin");

            if (ModelState.IsValid)
            {
                _context.Livros.Add(livro);
                await _context.SaveChangesAsync();
                TempData["Sucesso"] = "Livro cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }

            return View(livro);
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (!AdminLogado()) return RedirectToAction("Login", "Admin");

            var livro = await _context.Livros.FindAsync(id);
            if (livro == null) return NotFound();

            return View(livro);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Livro livro)
        {
            if (!AdminLogado()) return RedirectToAction("Login", "Admin");

            if (id != livro.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Livros.Update(livro);
                await _context.SaveChangesAsync();
                TempData["Sucesso"] = "Livro atualizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }

            return View(livro);
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (!AdminLogado()) return RedirectToAction("Login", "Admin");

            var livro = await _context.Livros.FindAsync(id);
            if (livro == null) return NotFound();

            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!AdminLogado()) return RedirectToAction("Login", "Admin");

            var livro = await _context.Livros.FindAsync(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
                TempData["Sucesso"] = "Livro excluído com sucesso!";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}