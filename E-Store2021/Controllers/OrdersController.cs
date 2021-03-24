using E_Store2021.Data;
using E_Store2021.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext _context;

        private UserManager<ApplicationUser> _userManager;

        private RoleManager<ApplicationUser> _roleManager;

        public OrdersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationUser> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var user = _userManager?.GetUserAsync(User)?.Result;

            return View();
        }
    }
}
