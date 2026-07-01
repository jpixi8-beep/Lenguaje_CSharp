using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public IActionResult GetAll()
        {
            var productos = _context.Products.ToList();
            return Ok(new { mensaje = "Lista de productos obtenida correctamente", productos });
        }

        // GET: api/Products/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var producto = _context.Products.Find(id);
            if (producto == null)
                return NotFound(new { mensaje = "Producto no encontrado" });

            return Ok(new { mensaje = "Producto encontrado", producto });
        }

        // POST: api/Products
        [HttpPost]
        public IActionResult Create(Product producto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Products.Add(producto);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = producto.Id },
                new { mensaje = "Producto creado con éxito", producto });
        }

        // PUT: api/Products/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product producto)
        {
            var existente = _context.Products.Find(id);
            if (existente == null)
                return NotFound(new { mensaje = "Producto no encontrado" });

            existente.Name = producto.Name;
            existente.Price = producto.Price;
            existente.Stock = producto.Stock;
            _context.SaveChanges();

            return Ok(new { mensaje = "Producto actualizado correctamente", producto = existente });
        }

        // DELETE: api/Products/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = _context.Products.Find(id);
            if (producto == null)
                return NotFound(new { mensaje = "Producto no encontrado" });

            _context.Products.Remove(producto);
            _context.SaveChanges();

            return Ok(new { mensaje = "Producto eliminado con éxito", producto });
        }
    }
}