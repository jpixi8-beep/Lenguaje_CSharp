namespace MiniEcommerce.Models
{
    public class CartItem
    {
        public int Id { get; set; }              // Clave primaria
        public int ProductId { get; set; }       // Relación con Producto
        public int Quantity { get; set; }        // Cantidad en el carrito

        // Relación de navegación
        public Product Product { get; set; } = new Product();

    }
}