using LojaDeCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaDeCarros.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        { 
        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Nota> Notas { get; set; }

    }
}
