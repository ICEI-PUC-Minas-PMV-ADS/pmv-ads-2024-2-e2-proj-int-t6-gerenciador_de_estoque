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

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            
                return NotFound();
          
            var dados = await _context.Entradas.FindAsync(id);

            if (dados == null)
                return NotFound();


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Entrada entrada)
        {
            if (id != entrada.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Entradas.Update(entrada);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details (Guid? id)
        {
            if (id == null) 
                return NotFound();

            var dados = await _context.Entradas.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados); 
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Entradas.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Entradas.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Entradas.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


    }

}
