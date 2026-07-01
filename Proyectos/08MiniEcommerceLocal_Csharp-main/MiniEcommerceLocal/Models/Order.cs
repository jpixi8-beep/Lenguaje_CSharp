using System;
using System.Collections.Generic;

namespace MiniEcommerce.Models
{
    public class Order
    {
        public int Id { get; set; }                  // Clave primaria
        public DateTime Date { get; set; } = DateTime.Now; // Fecha de la orden
        public decimal Total { get; set; }           // Total de la compra
        public string Status { get; set; } = "Pagado"; // Estado (Pagado, Cancelado, Pendiente)

        // Relación con los ítems del carrito
        public List<CartItem> Items { get; set; } = new();
    }
}