using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.DbContexts
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Recibo> Recibos { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/mypayments.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(cte =>
            {
                cte.HasOne(c => c.Domicilio).WithOne(d => d.Cliente);
                cte.HasMany(c => c.Recibos).WithOne(r => r.Cliente);
            });

            modelBuilder.Entity<Domicilio>(dom =>
            {
                dom.HasOne(d => d.Cliente).WithOne(c => c.Domicilio);
            });

            modelBuilder.Entity<Recibo>(rec =>
            {
                rec.HasOne(r => r.Cliente).WithMany(c => c.Recibos);
                rec.HasOne(r => r.Pago).WithOne(p => p.Recibo);
            });

            modelBuilder.Entity<Pago>(pago =>
            {
                pago.HasOne(p => p.Recibo).WithOne(r => r.Pago);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}