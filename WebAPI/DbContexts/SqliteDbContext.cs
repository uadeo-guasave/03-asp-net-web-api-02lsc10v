using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.DbContexts
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/mypayments.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}