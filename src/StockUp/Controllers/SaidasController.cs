using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockUp.Models;

namespace StockUp.Controllers
{
    [Authorize]
    public class SaidasController : Controller
    {
        private readonly AppDbContext _context;

        public SaidasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Saidas
        public async Task<IActionResult> Index()
        {
            var UsuarioId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (UsuarioId == null) return Unauthorized();

            var saidas = await _context.Saidas
                .Include(s => s.Produto)
                .Where(s => s.Produto.UsuarioId == Guid.Parse(UsuarioId))
                .ToListAsync();

            return View(saidas);
        }

        // GET: Saidas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saida = await _context.Saidas
                .Include(s => s.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saida == null)
            {
                return NotFound();
            }

            return View(saida);
        }

        // GET: Saidas/Create
        public async Task<IActionResult> Create()
        {
            var UsuarioId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (UsuarioId == null) return Unauthorized();

            List<Produto> produtos = await _context.Produtos
                .Where(s => s.UsuarioId == Guid.Parse(UsuarioId))
                .ToListAsync();

            ViewBag.ProductsId = produtos;

            return View();
        }

        // POST: Saidas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Saida saida)
        {
            Produto produto = await _context.Produtos.FindAsync(saida.ProdutoId);
            if (produto == null) return NotFound();

            saida.Produto = produto;
            ModelState.Remove("Produto");

            if (ModelState.IsValid)
            {
                saida.Id = Guid.NewGuid();
                saida.CriadoEm = DateTime.Now;
                _context.Add(saida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Descricao", saida.ProdutoId);
            return View(saida);
        }

        // GET: Saidas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var UsuarioId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (UsuarioId == null) return Unauthorized();

            List<Produto> produtos = await _context.Produtos.Include(p => p.Fornecedor)
                .Include(p => p.Usuario)
                .Where(p => p.UsuarioId == Guid.Parse(UsuarioId))
                .ToListAsync();

            var saida = await _context.Saidas.FindAsync(id);

            if (saida == null)
            {
                return NotFound();
            }

            ViewBag.Produtos = new SelectList(produtos, "Id", "Nome", saida.ProdutoId);

            return View(saida);
        }

        // POST: Saidas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Saida saida)
        {
            if (id != saida.Id)
            {
                return NotFound();
            }

            Produto produto = await _context.Produtos.FindAsync(saida.ProdutoId);
            if (produto == null) return NotFound();
            

            saida.Produto = produto;
            ModelState.Remove("Produto");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaidaExists(saida.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Descricao", saida.ProdutoId);
            return View(saida);
        }

        // GET: Saidas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saida = await _context.Saidas
                .Include(s => s.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saida == null)
            {
                return NotFound();
            }

            return View(saida);
        }

        // POST: Saidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var saida = await _context.Saidas
                .Include(e => e.Produto)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (saida != null)
            {
                _context.Saidas.Remove(saida);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaidaExists(Guid id)
        {
            return _context.Saidas.Any(e => e.Id == id);
        }
    }
}
