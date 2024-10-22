using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockUp.Models;

namespace StockUp.Controllers
{
    public class EntradasController1 : Controller
    {
        private readonly AppDbContext _context;
        
        public List<ListaEntradas> dados {  get; set; }

        public ListaEntradas data { get; set; }
        
        public EntradasController1(AppDbContext context) 
        { 
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            
            dados = await _context.ListaEntradas.ToListAsync();

            return View(dados);
        }

        public async Task<IActionResult> Create()
        {
            List<Produto> produtos = await _context.Produtos.ToListAsync();

            string[] productsArray = new string[] { "Product1", "Product2", "Product3" };

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

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            
                return NotFound();

            var data = await _context.ListaEntradas.FindAsync(id);
            //var lista = await _context.ListaEntradas.FindAsync(id);

            if (data == null)
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

            var dados = await _context.ListaEntradas.FindAsync(id);

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
