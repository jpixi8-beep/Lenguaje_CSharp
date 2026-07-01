using Microsoft.AspNetCore.Mvc;
using WebScraper.Services;

namespace WebScraper.Controllers
{
    public class ScraperController : Controller
    {
        private readonly ScraperService _service;

        public ScraperController(ScraperService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Resultados(string url)
        {
            var registros = await _service.ScrapingAsync(url);
            return View(registros);
        }
    }
}