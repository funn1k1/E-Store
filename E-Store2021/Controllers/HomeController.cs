using E_Store2021.Data;
using E_Store2021.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var catalog = await _context.Categories
                .Include(c => c.SubCategories).ThenInclude(c => c.Products)
                .AsNoTracking().ToListAsync();

            var banners = new List<string>
            {
                "~/images/banner-image1.jpg",
                "~/images/banner-image1.jpg",
                "~/images/banner-image1.jpg",
                "~/images/banner-image1.jpg",
            };

            ViewData["Banner"] = banners;

            Random rnd = new Random();

           

            List<Product> rndProdDisc = await _context.Products.Where(p => p.Discount > 0).ToListAsync();
            List<Product> white = new List<Product>();


            for (int i = 0; i < rndProdDisc.Count; i++)
            {
                white.Add(new Product 
                { 
                    ProductID = i, 
                    ProductName = rndProdDisc[i].ProductName,
                    ProductPicture = rndProdDisc[i].ProductPicture,
                    Discount = rndProdDisc[i].Discount,
                    UnitPrice = rndProdDisc[i].UnitPrice,
                });
            }
            var rndNumber = rnd.Next(white.FirstOrDefault().ProductID, white.LastOrDefault().ProductID + 1); ;
            Product product = white.FirstOrDefault(p => p.ProductID == rndNumber);

            ViewBag.Product = product;
            return View(catalog);
        }
    }
}