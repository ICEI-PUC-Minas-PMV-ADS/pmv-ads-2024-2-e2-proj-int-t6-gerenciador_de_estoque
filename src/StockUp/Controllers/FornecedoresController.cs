using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StockUp.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StockUp.Controllers
{
    [Authorize]
    public class FornecedoresController : Controller
    {

        private readonly AppDbContext _context;

        public FornecedoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Fornecedores/Index
        public async Task<IActionResult> Index(string keyword)
        {
            var fornecedoresQuery = _context.Fornecedores.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                fornecedoresQuery = fornecedoresQuery.Where(p => p.Nome.Contains(keyword));
            }

            var fornecedores = await fornecedoresQuery.ToListAsync();

            return View(fornecedores);
        }


        // GET: Fornecedores/Details/id
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.Fornecedores.FirstOrDefaultAsync(m => m.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {

            if(id == null)
            {
                return NotFound();
            }

            var dados = await _context.Fornecedores.FindAsync(id);

            if(dados == null)  
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Fornecedor fornecedor)
        {
            if (id != fornecedor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var fornecedorOriginal = await _context.Fornecedores.FindAsync(id);
                if (fornecedorOriginal == null)
                {
                    return NotFound();
                }

                fornecedor.CriadoEm = fornecedorOriginal.CriadoEm;

                _context.Entry(fornecedorOriginal).CurrentValues.SetValues(fornecedor);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(fornecedor);
        }



        // GET: Fornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                fornecedor.Id = Guid.NewGuid();
                fornecedor.CriadoEm = DateTime.Now;
                _context.Add(fornecedor);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }
    }
}
