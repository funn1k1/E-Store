using E_Store2021.Data;
using E_Store2021.Models;
using E_Store2021.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public ProductController(ApplicationDbContext _context, UserManager<ApplicationUser> userManager)
        {
            this._context = _context;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            ProductViewModel product = new ProductController(_context, _userManager).CreateProduct(id);

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(int? id, string text)
        {
            if (id == null)
                return NotFound();

            int? productId = _context.Products.FirstOrDefault(p => p.ProductID == id).ProductID;

            Review review = new Review
            {
                Text = text,
                ProductID = productId,
                UserId = _userManager.GetUserId(User),
            };

            _context.Reviews.Add(review);

            await _context.SaveChangesAsync();

            ProductViewModel product = new ProductController(_context, _userManager).CreateProduct(id);

            return View("Index", product);
        }

        public ProductViewModel CreateProduct(int? id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.ProductID == id);

            int? productID = product?.ProductID;

            List<Review> reviews = _context.Reviews.Include(u => u.User).Where(r => r.ProductID == productID).ToList();

            int? subCategoryId = product?.SubCategoryID;

            SubCategory subCategory = _context.SubCategories.FirstOrDefault(s => s.SubCategoryID == subCategoryId);

            int? categoryId = subCategory?.CategoryID;

            Category category = _context.Categories.FirstOrDefault(c => c.CategoryID == categoryId);

            Company company = _context.Companies.FirstOrDefault(c => c.CompanyID == product.CompanyID);

            ProductViewModel productView = new ProductViewModel
            {
                Product = product,
                SubCategory = subCategory,
                Category = category,
                Reviews = reviews,
                Company = company,
                Categories = _context.Categories.ToList(),
            };

            return productView;
        }
    }
}