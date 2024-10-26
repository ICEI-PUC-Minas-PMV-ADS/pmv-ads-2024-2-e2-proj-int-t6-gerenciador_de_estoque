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
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Fornecedores.ToListAsync();

            return View(dados);
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
