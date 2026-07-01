using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EncuestasApp.Models
{
    public class Encuesta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(200)]
        public string Titulo { get; set; }

        public ICollection<Opcion> Opciones { get; set; }
    }
}