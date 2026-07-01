using Microsoft.AspNetCore.Mvc;
using MiniEcommerce.Data;
using MiniEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace MiniEcommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cart
        public async Task<IActionResult> Index()
        {
            var items = await _context.CartItems.Include(c => c.Product).ToListAsync();
            decimal total = items.Sum(i => i.Product.Price * i.Quantity);

            ViewBag.Total = total;
            return View(items);
        }

        // GET: Cart/Add/5
        public async Task<IActionResult> Add(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return NotFound();

            var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.ProductId == productId);
            if (cartItem == null)
            {
                cartItem = new CartItem { ProductId = productId, Quantity = 1 };
                _context.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
                _context.CartItems.Update(cartItem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Cart/Remove/5
        public async Task<IActionResult> Remove(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem == null) return NotFound();

            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}                                                                                                                       