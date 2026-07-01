namespace WebScraper.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Contenido { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}