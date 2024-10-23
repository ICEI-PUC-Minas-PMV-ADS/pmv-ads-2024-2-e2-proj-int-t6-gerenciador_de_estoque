using Microsoft.EntityFrameworkCore;

namespace StockUp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Saida> Saidas { get; set; }

        public DbSet<Entrada> Entradas { get; set; }
    }
}
