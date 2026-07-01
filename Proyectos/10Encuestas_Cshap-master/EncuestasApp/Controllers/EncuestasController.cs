using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EncuestasApp.Data;
using EncuestasApp.Models;
using EncuestasApp.Hubs;
using Microsoft.AspNetCore.SignalR;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestasApp.Controllers
{
    public class EncuestasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHubContext<EncuestaHub> _hubContext;

        public EncuestasController(AppDbContext context, IHubContext<EncuestaHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        // GET: Encuestas
        public async Task<IActionResult> Index()
        {
            var encuestas = await _context.Encuestas
                .Include(e => e.Opciones)
                .ToListAsync();
            return View(encuestas);
        }

        // GET: Encuestas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Encuestas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Encuesta encuesta, string[] opciones)
        {
            if (ModelState.IsValid)
            {
                encuesta.Opciones = opciones
                    .Where(o => !string.IsNullOrWhiteSpace(o))
                    .Select(o => new Opcion { Texto = o })
                    .ToList();

                _context.Add(encuesta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(encuesta);
        }

        // GET: Encuestas/Votar/5
        [HttpGet]
        public async Task<IActionResult> Votar(int id)
        {
            var encuesta = await _context.Encuestas
                .Include(e => e.Opciones)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (encuesta == null)
                return NotFound();

            return View(encuesta);
        }

        // POST: Encuestas/Votar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VotarPost(int opcionId)
        {
            var opcion = await _context.Opciones.FindAsync(opcionId);
            if (opcion == null)
                return NotFound();

            opcion.Votos++;
            _context.Update(opcion);
            await _context.SaveChangesAsync();

            // Notificar a todos los clientes conectados vía SignalR
            await _hubContext.Clients.All.SendAsync("RecibirActualizacion", opcion.EncuestaId);

            return RedirectToAction(nameof(Resultados), new { id = opcion.EncuestaId });
        }

        // GET: Encuestas/Resultados/5
        public async Task<IActionResult> Resultados(int id)
        {
            var encuesta = await _context.Encuestas
                .Include(e => e.Opciones)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (encuesta == null)
                return NotFound();

            return View(encuesta);
        }

        // 🚀 NUEVO MÉTODO JSON
        // GET: api/encuestas/{id}
        [HttpGet("/api/encuestas/{id}")]
        public async Task<IActionResult> ResultadosJson(int id)
        {
            var encuesta = await _context.Encuestas
                .Include(e => e.Opciones)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (encuesta == null)
                return NotFound();

            var resultado = new
            {
                id = encuesta.Id,
                titulo = encuesta.Titulo,
                opciones = encuesta.Opciones.Select(o => new
                {
                    id = o.Id,
                    texto = o.Texto,
                    votos = o.Votos
                })
            };

            return Json(resultado);
        }
    }
}