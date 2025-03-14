using Microsoft.EntityFrameworkCore;

namespace ITMApi.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoComputador> TipoComputadores { get; set; }
        public DbSet<Computador> Computadores { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencia>().ToTable("Agencia");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<TipoComputador>().ToTable("TipoComputador");
            modelBuilder.Entity<Computador>().ToTable("Computador");
            modelBuilder.Entity<Venta>().ToTable("Venta");
        }
    }
}