using E_Store2021.Data;
using E_Store2021.Models;
using E_Store2021.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;

        public ProductController(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index(int id)
        {
            ProductViewModel product = new ProductController(_context).CreateProduct(id);

            return View(product);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AddReview(int? id, string text)
        {
            if (id == null)
                return NotFound();

            int? productId = _context.Products.FirstOrDefault(p => p.ProductID == id).ProductID;

            Review review = new Review
            {
                Text = text,
                ProductID = productId,
            };

            _context.Reviews.Add(review);

            await _context.SaveChangesAsync();

            ProductViewModel product = new ProductController(_context).CreateProduct(id);

            return View("Index", product);
        }

        public ProductViewModel CreateProduct(int? id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.ProductID == id);

            int? productID = product?.ProductID;

            List<Review> reviews = _context.Reviews.Where(r => r.ProductID == productID).ToList();

            int? subCategoryId = product?.SubCategoryID;

            SubCategory subCategory = _context.SubCategories.FirstOrDefault(s => s.SubCategoryID == subCategoryId);

            int? categoryId = subCategory?.CategoryID;

            Category category = _context.Categories.FirstOrDefault(c => c.CategoryID == categoryId);

            ProductViewModel productView = new ProductViewModel
            {
                Product = product,
                SubCategory = subCategory,
                Category = category,
                Reviews = reviews,
            };

            return productView;
        }
    }
}