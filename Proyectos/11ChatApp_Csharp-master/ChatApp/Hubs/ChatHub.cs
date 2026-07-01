using ChatApp.Data;
using ChatApp.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        private readonly AppDbContext _context;

        public ChatHub(AppDbContext context)
        {
            _context = context;
        }

        public async Task EnviarMensaje(string usuario, string mensaje)
        {
            var nuevoMensaje = new Mensaje
            {
                Usuario = usuario,
                Texto = mensaje,
                Fecha = DateTime.Now
            };

            _context.Mensajes.Add(nuevoMensaje);
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("RecibirMensaje", usuario, mensaje, nuevoMensaje.Fecha.ToString("HH:mm"));
        }
    }
}