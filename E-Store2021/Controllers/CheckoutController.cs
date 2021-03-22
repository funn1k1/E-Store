using E_Store2021.Data;
using E_Store2021.Helpers;
using E_Store2021.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            ShoppingCartModel.Total = Math.Ceiling((decimal)cart?.Sum(item => item.Product.UnitPrice * item.Quantity));

            List<string> countryList = new List<string>();
            CultureInfo[] cInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo cInfo in cInfoList)
            {
                RegionInfo R = new RegionInfo(cInfo.LCID);
                if (!countryList.Contains(R.EnglishName))
                {
                    countryList.Add(R.EnglishName);
                }
            }
            Order order = new Order();
            countryList.Sort();
            ViewBag.CountryList = new SelectList(countryList);
            return View(order);
        }


        
    }
}
