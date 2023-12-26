using Imobiliaria.Models;
using Microsoft.EntityFrameworkCore;

namespace ImobiliariaThiago.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
    }
}
