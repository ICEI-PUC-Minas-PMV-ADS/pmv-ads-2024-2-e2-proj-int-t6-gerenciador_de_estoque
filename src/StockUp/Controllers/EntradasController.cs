using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockUp.Models;

namespace StockUp.Controllers
{
    public class EntradasController : Controller
    {
        private readonly AppDbContext _context;
        public EntradasController(AppDbContext context) 
        { 
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Entradas.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Entrada entrada) 
        {
            if (ModelState.IsValid) 
            {
                _context.Entradas.Add(entrada);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(entrada);
        }
    }
}
