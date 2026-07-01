namespace MiniEcommerce.Models
{
    public class Product
    {
        public int Id { get; set; }          // Clave primaria
        public string Name { get; set; } = string.Empty;
   // Nombre del producto
        public decimal Price { get; set; }   // Precio
        public int Stock { get; set; }       // Cantidad disponible
       public string ImageUrl { get; set; } = string.Empty;
 // URL de la imagen
    }
}