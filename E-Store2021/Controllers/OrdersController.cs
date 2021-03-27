using E_Store2021.Data;
using E_Store2021.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace E_Store2021.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext _context;

        private UserManager<ApplicationUser> _userManager;

        public OrdersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<Order> orders = _context.Orders.ToList();
            return View(orders);
        }

        public IActionResult Reject()
        {
            return View();
        }
    }
}