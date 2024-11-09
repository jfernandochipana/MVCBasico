using Microsoft.EntityFrameworkCore;
using MVCBasico.Models;

namespace MVCBasico.Context
{
    public class ElectronicaDatabaseContext : DbContext
    {
        public ElectronicaDatabaseContext(DbContextOptions<ElectronicaDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Auricular> Auriculares { get; set; }
        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Computadora> Computadoras { get; set; }

    }
}
