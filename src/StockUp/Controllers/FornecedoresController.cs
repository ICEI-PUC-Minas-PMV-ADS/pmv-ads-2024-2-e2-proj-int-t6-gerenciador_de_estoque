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

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Fornecedores.ToListAsync();

            return View(dados);
        }
    }
}
