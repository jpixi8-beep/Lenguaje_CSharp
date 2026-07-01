using Microsoft.EntityFrameworkCore;
using WebScraper.Models;

namespace WebScraper.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Registro> Registros { get; set; }
    }
}