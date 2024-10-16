﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockUp.Models;

namespace StockUp.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Produtos.Include(p => p.Fornecedor).Include(p => p.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Fornecedor)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "Nome");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Preco,Quantidade,Descricao,EstoqueMinimo,Categoria")] Produto produto, string nomeFornecedor)
        {
            if (string.IsNullOrEmpty(nomeFornecedor))
            {
                ModelState.AddModelError("NomeFornecedor", "O nome do fornecedor é obrigatório.");
                ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", produto.UsuarioId);
                return View(produto);
            }

            var fornecedor = await _context.Fornecedores.FirstOrDefaultAsync(f => f.Nome == nomeFornecedor);

            if (fornecedor == null)
            {
                fornecedor = new Fornecedor
                {
                    Id = Guid.NewGuid(),
                    Nome = nomeFornecedor,
                    CriadoEm = DateTime.Now,
                };
                _context.Fornecedores.Add(fornecedor);
                await _context.SaveChangesAsync();
            }

            produto.FornecedorId = fornecedor.Id;
            ModelState.Remove("Fornecedor");

            if (ModelState.IsValid)
            {
                produto.Id = Guid.NewGuid();
                produto.CriadoEm = DateTime.Now;
                produto.AtualizadoEm = DateTime.Now;
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", produto.UsuarioId);
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (produto == null)
            {
                return NotFound();
            }
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "Nome", produto.FornecedorId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", produto.UsuarioId);
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nome,Preco,Quantidade,Descricao,EstoqueMinimo,Categoria")] Produto produto, string nomeFornecedor)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (string.IsNullOrEmpty(nomeFornecedor))
            {
                ModelState.AddModelError("NomeFornecedor", "O nome do fornecedor é obrigatório.");
                ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", produto.UsuarioId);
                return View(produto);
            }

            var fornecedor = await _context.Fornecedores.FirstOrDefaultAsync(f => f.Nome == nomeFornecedor);

            if (fornecedor == null)
            {
                fornecedor = new Fornecedor
                {
                    Id = Guid.NewGuid(),
                    Nome = nomeFornecedor,
                    CriadoEm = DateTime.Now,
                };
                _context.Fornecedores.Add(fornecedor);
                await _context.SaveChangesAsync();
            }

            produto.FornecedorId = fornecedor.Id;
            ModelState.Remove("Fornecedor");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
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
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "Nome", produto.FornecedorId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", produto.UsuarioId);
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Fornecedor)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(Guid id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
