using Microsoft.EntityFrameworkCore;
using OnlineBookStoreWithASPNETCore.Configurations;
using OnlineBookStoreWithASPNETCore.Entities;

namespace OnlineBookStoreWithASPNETCore.Contexts
{
    public class OnlineBookStoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = DESKTOP-EVASO6B; Database = OnlineBookStore2025; Trusted_Connection = true; TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new OrderBookConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Entities.Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderBook> OrderBooks { get; set; }
        public DbSet<Entities.Category> Categories { get; set; }
    }
}
