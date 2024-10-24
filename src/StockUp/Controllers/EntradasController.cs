using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockUp.Models;
using System.Security.Claims;

namespace StockUp.Controllers
{
    [Authorize]
    public class EntradasController : Controller
    {
        private readonly AppDbContext _context;

        public EntradasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var UsuarioId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (UsuarioId == null) return Unauthorized();

            var entradas = await _context.Entradas.Include(e => e.Produto).Where(e => e.Produto.UsuarioId == Guid.Parse(UsuarioId)).
                ToListAsync();
            

            return View(entradas);
        }

        public async Task<IActionResult> Create()
        {
            List<Produto> produtos = await _context.Produtos.ToListAsync();

            ViewBag.ProductsId = produtos;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Entrada entrada)
        {
            if (!ModelState.IsValid)
            {
                _context.Entradas.Add(entrada);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(entrada);
        }

        public async Task<IActionResult> Edit(String id)
        {
            if (id == null)
                return NotFound();

            var UsuarioId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (UsuarioId == null) return Unauthorized();

            List<Produto> produtos = await _context.Produtos.Include(p => p.Fornecedor)
                .Include(p => p.Usuario)
                .Where(p => p.UsuarioId == Guid.Parse(UsuarioId))
                .ToListAsync();

            var entrada = await _context.Entradas.FindAsync(Guid.Parse(id));

            if (entrada == null)
                return NotFound();

            ViewBag.Produtos = new SelectList(produtos, "Id", "Nome", entrada.ProdutoId);

            return View(entrada);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Entrada entrada)
        {
            if (id != entrada.Id)
                return NotFound();

            if (!ModelState.IsValid)
            {
                _context.Entradas.Update(entrada);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            return View();
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
                return NotFound();

            var entrada = await _context.Entradas
                .Include(e => e.Produto)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (entrada == null)
                return NotFound();

            return View(entrada);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
                return NotFound();

            var entrada = await _context.Entradas
                .Include(e => e.Produto)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (entrada == null)
                return NotFound();

            return View(entrada);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (id == null)
                return NotFound();

            var entrada = await _context.Entradas
                .Include(e => e.Produto)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (entrada == null)
                return NotFound();

            _context.Entradas.Remove(entrada);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
