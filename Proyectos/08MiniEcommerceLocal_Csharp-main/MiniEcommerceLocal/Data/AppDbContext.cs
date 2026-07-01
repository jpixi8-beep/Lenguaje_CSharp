using Microsoft.EntityFrameworkCore;
using MiniEcommerce.Models;

namespace MiniEcommerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Datos iniciales (seeding)
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 10000, Stock = 25, ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 2, Name = "Mouse", Price = 500, Stock = 100, ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 3, Name = "Teclado", Price = 800, Stock = 50, ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 4, Name = "Monitor", Price = 3000, Stock = 20, ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 5, Name = "Celular", Price = 7000, Stock = 15, ImageUrl = "https://via.placeholder.com/150" }
            );
        }
    }
}