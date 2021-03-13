using E_Store2021.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        [AllowAnonymous]
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

            return View(catalog);
        }
    }
}