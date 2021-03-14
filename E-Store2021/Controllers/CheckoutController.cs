using E_Store2021.Data;
using E_Store2021.Helpers;
using E_Store2021.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

        [AllowAnonymous]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            ShoppingCartModel.ShoppingCartItems = cart;
            ShoppingCartModel.Total = cart?.Sum(item => item.Product.UnitPrice * item.Quantity);
            return View();
        }
    }
}
