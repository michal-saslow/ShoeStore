
using Microsoft.EntityFrameworkCore;
using ShoeStore.Core.Entities;

namespace ShoeStore.Date
{
    public class DataContext: DbContext
    {
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Provider> providers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ShoeStore_db");
        }
    }
}
