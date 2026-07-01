using ChatApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private readonly AppDbContext _context;

        public ChatController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Sala()
        {
            var mensajes = await _context.Mensajes
                .OrderBy(m => m.Fecha)
                .ToListAsync();

            return View(mensajes);
        }
    }
}