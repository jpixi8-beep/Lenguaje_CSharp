using System.ComponentModel.DataAnnotations;

namespace EncuestasApp.Models
{
    public class Opcion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El texto de la opción es obligatorio")]
        [StringLength(100)]
        public string Texto { get; set; }

        public int Votos { get; set; } = 0;

        // Relación con Encuesta
        public int EncuestaId { get; set; }
        public Encuesta Encuesta { get; set; }
    }
}