
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace EncuestasApp.Hubs
{
    public class EncuestaHub : Hub
    {
        // Método que notifica a todos los clientes que hubo un voto
        public async Task ActualizarResultados(int encuestaId)
        {
            await Clients.All.SendAsync("RecibirActualizacion", encuestaId);
        }
    }
}