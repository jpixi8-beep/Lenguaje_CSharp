using Microsoft.EntityFrameworkCore;
using MicroBlog.Models;

namespace MicroBlog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Post> Posts { get; set; }
        
       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Post>().HasData(
    new Post { Id = 1, Title = "Primer Post", Content = "Bienvenido al MicroBlog!", Author = "Lechugas", Date = new DateTime(2026, 2, 12) },
    new Post { Id = 2, Title = "Segundo Post", Content = "Este es otro ejemplo.", Author = "Lechugas", Date = new DateTime(2026, 2, 12) }
);
}



    }
}