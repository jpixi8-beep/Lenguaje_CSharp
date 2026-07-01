using HtmlAgilityPack;
using WebScraper.Data;
using WebScraper.Models;

namespace WebScraper.Services
{
    public class ScraperService
    {
        private readonly AppDbContext _context;

        public ScraperService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Registro>> ScrapingAsync(string url)
        {
            var web = new HtmlWeb();
            var doc = await web.LoadFromWebAsync(url);

            var registros = new List<Registro>();

            // Ejemplo: obtener todos los títulos <h2>
            var titulos = doc.DocumentNode.SelectNodes("//h2");
            if (titulos != null)
            {
                foreach (var t in titulos)
                {
                    var registro = new Registro
                    {
                        Titulo = t.InnerText.Trim(),
                        Url = url,
                        Contenido = t.InnerHtml,
                        Fecha = DateTime.Now
                    };
                    registros.Add(registro);
                    _context.Registros.Add(registro);
                }
                await _context.SaveChangesAsync();
            }

            return registros;
        }
    }
}