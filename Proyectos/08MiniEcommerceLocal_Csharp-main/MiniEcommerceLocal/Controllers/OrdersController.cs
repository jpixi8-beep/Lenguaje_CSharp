using Microsoft.AspNetCore.Mvc;
using MiniEcommerce.Data;
using MiniEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace MiniEcommerce.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders/Create
        public async Task<IActionResult> Create()
        {
            var cartItems = await _context.CartItems.Include(c => c.Product).ToListAsync();
            if (!cartItems.Any()) return RedirectToAction("Index", "Cart");

            var order = new Order
            {
                Date = DateTime.Now,
                Status = "Pagado",
                Total = cartItems.Sum(i => i.Product.Price * i.Quantity)
            };

            _context.Orders.Add(order);
            _context.CartItems.RemoveRange(cartItems);
            await _context.SaveChangesAsync();

            return View(order);
        }
    }
}