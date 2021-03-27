using E_Store2021.Data;
using E_Store2021.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDbContext _context;

        public CheckoutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(Order order)
        {
            var coupon = _context.Coupons.FirstOrDefault(c => c.Name == ShoppingCartModel.CouponName);
            if (coupon != null)
            {
                _context.Coupons.Remove(coupon);
            }
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}