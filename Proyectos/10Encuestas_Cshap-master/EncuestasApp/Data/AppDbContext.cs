using Microsoft.EntityFrameworkCore;
using EncuestasApp.Models;

namespace EncuestasApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Encuesta> Encuestas { get; set; }
        public DbSet<Opcion> Opciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Datos iniciales
            modelBuilder.Entity<Encuesta>().HasData(
                new Encuesta { Id = 1, Titulo = "¿Cuál es tu lenguaje favorito?" },
                new Encuesta { Id = 2, Titulo = "¿Qué framework prefieres?" }
            );

            modelBuilder.Entity<Opcion>().HasData(
                new Opcion { Id = 1, Texto = "C#", Votos = 0, EncuestaId = 1 },
                new Opcion { Id = 2, Texto = "Python", Votos = 0, EncuestaId = 1 },
                new Opcion { Id = 3, Texto = "JavaScript", Votos = 0, EncuestaId = 1 },

                new Opcion { Id = 4, Texto = "ASP.NET Core", Votos = 0, EncuestaId = 2 },
                new Opcion { Id = 5, Texto = "Django", Votos = 0, EncuestaId = 2 },
                new Opcion { Id = 6, Texto = "React", Votos = 0, EncuestaId = 2 }
            );
        }
    }
}