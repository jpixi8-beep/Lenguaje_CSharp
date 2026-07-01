using Microsoft.EntityFrameworkCore;
using ChatApp.Models;

namespace ChatApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Mensaje> Mensajes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Datos iniciales (seeding)
            modelBuilder.Entity<Mensaje>().HasData(
                new Mensaje
                {
                    Id = 1,
                    Usuario = "LechuDev",
                    Texto = "Bienvenido al chat en tiempo real 🚀",
                    Fecha = DateTime.Now
                },
                new Mensaje
                {
                    Id = 2,
                    Usuario = "Sistema",
                    Texto = "Este es un mensaje precargado para probar la base.",
                    Fecha = DateTime.Now
                }
            );
        }
    }
}