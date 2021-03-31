using E_Store2021.Data;
using E_Store2021.Models;
using E_Store2021.Models.StaticModels;
using E_Store2021.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class ProductsManager : Controller
    {
        private ApplicationDbContext _context;

        private RoleManager<IdentityRole> _roleManager;

        public ProductsManager(ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(p => p.SubCategory).ThenInclude(p => p.Category).ToListAsync();
            var productsViewModel = new List<ProductViewModel>();
            foreach (Product product in products)
            {
                var productViewModel = new ProductViewModel();
                productViewModel.Product = product;
                productsViewModel.Add(productViewModel);
            }

            return View(productsViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ChangeProduct(int id)
        {
            Product prod = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == id);
            return View(prod);

        }

        [HttpPost]
        public async Task<IActionResult> ChangeProduct(Product product)
        {

            if (Request.Form.Files.Count > 0)
            {
                IFormFile file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    product.ProductPicture = dataStream.ToArray();
                }
            }

            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return View(product);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            SelectBox.Categories = new SelectList(_context.Categories.ToList(), "CategoryID", "CategoryName");
            SelectBox.SubCategories = new SelectList(_context.SubCategories.ToList(), "SubCategoryID", "SubCategoryName");
            SelectBox.Companies = new SelectList(_context.Companies.ToList(), "CompanyID", "CompanyName");
            SelectBox.Countries = new SelectList(_context.Countries.ToList(), "CountryID", "CountryName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                if (Request.Form.Files.Count > 0)
                {
                    IFormFile file = Request.Form.Files.FirstOrDefault();
                    using (var dataStream = new MemoryStream())
                    {
                        await file.CopyToAsync(dataStream);
                        product.ProductPicture = dataStream.ToArray();
                    }
                }

                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                ViewBag.TextMess = "Products changed successfully";
                
            }
            catch (Exception ex)
            {
                ViewBag.TextMess = $"Error Occured:\n{ex.Message}";
            }
            return View();
        }
    }
}
