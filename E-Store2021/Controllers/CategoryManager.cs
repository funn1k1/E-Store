using E_Store2021.Data;
using E_Store2021.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class CategoryManager : Controller
    {
        private ApplicationDbContext _context;
        public CategoryManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int categoryId)
        {
            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == categoryId);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            if (Request.Form.Files.Count > 0)
            {
                IFormFile file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    category.CategoryPicture = dataStream.ToArray();
                }
            }
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
            }

            
            return View(category);
        }


        public async Task<IActionResult> Delete(int categoryId)
        {
            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == categoryId);
            return View(category);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteById(int categoryId)
        {
            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == categoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
