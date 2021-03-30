using E_Store2021.Data;
using E_Store2021.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class CouponsManager : Controller
    {

        private ApplicationDbContext _context;

        public CouponsManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Coupon> coupons = _context.Coupons.ToList();
            return View(coupons);
        }

        [HttpPost]
        public async Task<IActionResult> Index(double discount, string couponName, DateTime dateTime)
        {
            Coupon coupon = new Coupon { Discount = discount, Name = couponName, ExpirationDate = dateTime };

            try
            {
                _context.Coupons.Add(coupon);
                await _context.SaveChangesAsync();
                ViewBag.TextMess = "Coupon added successfully";
            }
            catch (Exception ex)
            {
                ViewBag.TextMess = $"Error Occured:\n{ex.Message}";
            }

            return View();
        }
    }
}
