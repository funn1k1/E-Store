using E_Store2021.Data;
using E_Store2021.Models;
using E_Store2021.Models.StaticModels;
using E_Store2021.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class CatalogController : Controller
    {
        private ApplicationDbContext _context;

        public CatalogController(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public async Task<ViewResult> Index(int pageNumber = 1)
        {
            List<CountryModel> countries = await _context.Countries.Include(c => c.Companies)
                .ThenInclude(p => p.Products).Select(c => new CountryModel { ID = c.CountryID, CountryName = c.CountryName, IsChecked = false, Companies = c.Companies })
                .ToListAsync();

            List<CompanyModel> companies = await _context.Companies.Include(c => c.Products)
                .Select(c => new CompanyModel { ID = c.CompanyID, CompanyName = c.CompanyName, IsChecked = false, Products = c.Products })
                .ToListAsync();

            List<CategoryModel> categoryModels = await _context.Categories.Include(c => c.SubCategories)
                .Select(c => new CategoryModel
                {
                    ID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    SubCategories = c.SubCategories
                }).ToListAsync();

            List<SubCategoryModel> subCatModels = await _context.SubCategories.Include(c => c.Products)
                .Select(c => new SubCategoryModel
                {
                    ID = c.SubCategoryID,
                    SubCategoryName = c.SubCategoryName,
                    Products = c.Products
                }).ToListAsync();

            List<ProductModel> productModels = await _context.Products.Select(c => new ProductModel
            {
                ID = c.ProductID,
                ProductName = c.ProductName,
                ImagePath = c.ImagePath,
                UnitPrice = c.UnitPrice,
                ProductPicture = c.ProductPicture
            }).ToListAsync();

            SelectBox.Categories = new SelectList(categoryModels, "CategoryName", "CategoryName");

            SelectBox.SubCategories = new SelectList(subCatModels, "SubCategoryName", "SubCategoryName");

            CompanyViewModel viewModel = new CompanyViewModel
            {
                Countries = countries,
                Companies = companies,
                Categories = categoryModels,
                SubCategories = subCatModels,
                Products = productModels,
                ProductsPagination = PaginatedList<ProductModel>.CreateAsync(productModels, pageNumber, 6)
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<ViewResult> Filter(string[] countries, string[] companies, string category, string subCategory, double startPrice, double endPrice, string isSale, int? pageNumber = 1)
        {
            List<CategoryModel> categoryModels = await _context.Categories.Include(c => c.SubCategories).ThenInclude(c => c.Products).ThenInclude(c => c.Company)
                .Where(c => c.CategoryName == category).Select(c => new CategoryModel
                {
                    ID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    SubCategories = c.SubCategories,
                }).ToListAsync();

            List<SubCategory> subTemp1 = new List<SubCategory>();

            foreach (var catModel in categoryModels)
            {
                foreach (var subCatModel in catModel.SubCategories)
                {
                    subTemp1.Add(subCatModel);
                }
            }

            List<SubCategoryModel> subCategories = subTemp1.Select(s => new SubCategoryModel
            {
                ID = s.SubCategoryID,
                SubCategoryName = s.SubCategoryName,
                Products = s.Products,
            }).Where(s => s.SubCategoryName == subCategory).ToList();

            for (int i = 0; i < subCategories.Count; i++)
            {
                subCategories[i].Products = subCategories[i].Products.Where(c => c.UnitPrice >= startPrice && c.UnitPrice <= endPrice).ToList();
            }

            List<Product> products = new List<Product>();

            foreach (var subCat in subCategories)
            {
                foreach (var product in subCat.Products)
                {
                    products.Add(product);
                }
            }

            List<CompanyModel> companyModels = _context.Companies.Include(c => c.Products)
            .Select(c => new CompanyModel
            {
                ID = c.CompanyID,
                CompanyName = c.CompanyName,
                IsChecked = companies.Contains(c.CompanyName),
                Products = c.Products
            }).ToList();

            List<Product> prod = new List<Product>();

            foreach (var company in companyModels.Where(p => p.IsChecked))
            {
                foreach (var product in company.Products)
                {
                    prod.Add(product);
                }
            }

            List<CountryModel> countryModels = _context.Countries.Include(c => c.Companies).ThenInclude(p => p.Products)
            .Select(c => new CountryModel
            {
                ID = c.CountryID,
                CountryName = c.CountryName,
                IsChecked = countries.Contains(c.CountryName),
                Companies = c.Companies
            }).ToList();

            List<Product> countryProducts = new List<Product>();

            foreach (var country in countryModels.Where(p => p.IsChecked))
            {
                foreach (var company in country.Companies)
                {
                    foreach (var p in company.Products)
                    {
                        countryProducts.Add(p);
                    }
                }
            }
            List<ProductModel> productModels;
            if (isSale == "on")
            {
                productModels = products.Where(p => p.Discount > 0 && isSale.Equals("on")).Select(p => new ProductModel
                {
                    ID = p.ProductID,
                    ProductName = p.ProductName,
                    ImagePath = p.ImagePath,
                    UnitPrice = p.UnitPrice,
                    ProductPicture = p.ProductPicture
                }).ToList(); ;
            }
            else
            {
                productModels = products.Where(p => prod.Contains(p) || countryProducts.Contains(p)).Select(p => new ProductModel
                {
                    ID = p.ProductID,
                    ProductName = p.ProductName,
                    ImagePath = p.ImagePath,
                    UnitPrice = p.UnitPrice,
                    ProductPicture = p.ProductPicture
                }).ToList();
            }

            CompanyViewModel viewModel;

            if (productModels.Count > 0)

                viewModel = new CompanyViewModel { Products = productModels, Companies = companyModels, Countries = countryModels, SubCategories = subCategories };
            else

                viewModel = new CompanyViewModel
                {
                    Products = products.Select(p => new ProductModel
                    {
                        ID = p.ProductID,
                        ProductName = p.ProductName,
                        ImagePath = p.ImagePath,
                        UnitPrice = p.UnitPrice,
                        ProductPicture = p.ProductPicture
                    }).ToList(),
                    Companies = companyModels,
                    Countries = countryModels,
                    SubCategories = subCategories
                };

            int pageSize = 9;

            viewModel.ProductsPagination = PaginatedList<ProductModel>.CreateAsync(viewModel.Products.ToList(), pageNumber ?? 1, pageSize);

            return View("Index", viewModel);
        }
    }
}