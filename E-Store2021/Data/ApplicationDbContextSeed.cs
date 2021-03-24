using E_Store2021.Enums;
using E_Store2021.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Data
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext _context, ILoggerFactory loggerFactory, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            try
            {
                _context.Database.EnsureCreated();

                await SeedCategoriesAsync(_context);

                await SeedSubCategories(_context);

                await SeedCountry(_context);
                await SeedCompany(_context);

                await SeedProduct(_context);

                await SeedReview(_context);

                await SeedRoles(_context, roleManager);

                await SeedSuperAdminAsync(userManager, roleManager);
            }
            catch(Exception ex)
            {
                var log = loggerFactory.CreateLogger<ApplicationDbContext>();
                log.LogError(ex.Message);
            }
        }
        private static async Task SeedCategoriesAsync(ApplicationDbContext _context)
        {
            if (_context.Categories.Any()) return;
            var categories = new List<Category>()
            {
                new Category
                {
                    Description = "Some category",
                    CategoryName = "Electronics",
                    ImagePath = "category_1.webp"
                },
                new Category
                {
                    Description = "Some category",
                    CategoryName = "Computers",
                    ImagePath = "category_2.webp"
                },
                new Category
                {
                    Description = "Some category",
                    CategoryName = "Music",
                    ImagePath = "category_3.webp"
                },
                new Category
                {
                    Description = "Some category",
                    CategoryName = "Software",
                    ImagePath = "category_4.webp"
                },
                new Category
                {
                    Description = "Some category",
                    CategoryName = "Arts",
                    ImagePath = "category_5.webp"
                },
                new Category
                {
                    Description = "Some category",
                    CategoryName = "Games",
                    ImagePath = "category_6.webp"
                },
            };
            _context.Categories.AddRange(categories);
            await _context.SaveChangesAsync();
        }

        private static async Task SeedSubCategories(ApplicationDbContext _context)
        {
            if (_context.SubCategories.Any()) return;
            var categories = await _context.Categories.ToListAsync();
            var subCategories = new List<SubCategory>
            {
                new SubCategory
                {
                    CategoryID =  categories.FirstOrDefault(c => c.CategoryName == "Electronics").CategoryID,
                    SubCategoryName = "Camera",
                    Description = "Some"
                },
                new SubCategory
                {
                    CategoryID =  categories.FirstOrDefault(c => c.CategoryName == "Electronics").CategoryID,
                    SubCategoryName = "Phones",
                    Description = "Some"
                },
                new SubCategory
                {
                    CategoryID =  categories.FirstOrDefault(c => c.CategoryName == "Electronics").CategoryID,
                    SubCategoryName = "Headphones",
                    Description = "Some"
                },
                new SubCategory
                {
                    CategoryID =  categories.FirstOrDefault(c => c.CategoryName == "Electronics").CategoryID,
                    SubCategoryName = "Video Game Consoles && Accessories",
                    Description = "Some"
                },
            };
            _context.SubCategories.AddRange(subCategories);
            await _context.SaveChangesAsync();
        }

        private static async Task SeedProduct(ApplicationDbContext _context)
        {
            if (_context.Products.Any()) return;
            var subCategories = await _context.SubCategories.ToListAsync();
            var companies = await _context.Companies.ToListAsync();
            var products = new List<Product>
            {
                new Product
                {
                    ProductName = "iPhone 12 Pro Max",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Phones").SubCategoryID,
                    UnitPrice = 1695.66,
                    Year = 2016,
                    ImagePath = "iphone12.webp",
                    Description = "Some phone",
                    Star = 5,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "Apple").CompanyID,
                },
                new Product
                {
                    ProductName = "iPhone 11 Pro Max",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Phones").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2016,
                    ImagePath = "iphone11.jpg",
                    Description = "Some phone",
                    Star = 5,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "Apple").CompanyID,
                },
                new Product
                {
                    ProductName = "Xiaomi 9 Pro",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Phones").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2016,
                    ImagePath = "iphone11.jpg",
                    Description = "Some phone",
                    Star = 5,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "Xiaomi").CompanyID,
                },
                new Product
                {
                    ProductName = "Canon PowerShot SX540 Digital Camera",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Camera").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2016,
                    ImagePath = "canon_sx540.jpg",
                    Description = "Some phone",
                    Star = 5,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "Canon").CompanyID,
                },
                new Product
                {
                    ProductName = "Panasonic LUMIX FZ300",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Camera").SubCategoryID,
                    UnitPrice = 397,
                    Year = 2016,
                    ImagePath = "panasonic_fz300.jpg",
                    Description = "Some phone",
                    Star = 5,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "Panasonic").CompanyID,
                },
                new Product
                {
                    ProductName = "4K Digital Camera 48MP Camera",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Camera").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2016,
                    ImagePath = "4k_digitalcamera_48mp.jpg",
                    Description = "Some phone",
                    Star = 4.5,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "CEDITA").CompanyID,
                },
                new Product
                {
                    ProductName = "TOZO T10 Bluetooth 5.0", 
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Headphones").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2016,
                    ImagePath = "tozo_t10.jpg",
                    Description = "Some phone",
                    Star = 4.6,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "TOZO").CompanyID,
                },
                new Product
                {
                    ProductName = "TOZO T6 True Wireless",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Headphones").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2016,
                    ImagePath = "tozo_t6.jpg",
                    Description = "Some phone",
                    Star = 4.5,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "TOZO").CompanyID,
                },
                new Product
                {
                    ProductName = "Razer Kraken Tournament Edition",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Headphones").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2019,
                    ImagePath = "razer_kraken.jpg",
                    Description = "Some phone",
                    Star = 4.5,
                    Quantity = 10,
                    Discount = 2,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "Razer").CompanyID,
                },
                new Product
                {
                    ProductName = "Sony PlayStation 4 Pro (Red Dead Redemption 2 Bundle)",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Video Game Consoles && Accessories").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2018,
                    ImagePath = "playstation-4.jpg",
                    Description = "Some phone",
                    Star = 4,
                    Quantity = 10,
                    Discount = 0,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "Sony").CompanyID,
                },
                new Product
                {
                    ProductName = "PlayStation 4 Pro 1TB Limited Edition",
                    SubCategoryID = subCategories.FirstOrDefault(s => s.SubCategoryName == "Video Game Consoles && Accessories").SubCategoryID,
                    UnitPrice = 1395.66,
                    Year = 2020,
                    ImagePath = "playstation-spider.jpg",
                    Description = "Some phone",
                    Star = 5,
                    Quantity = 10,
                    Discount = 10,
                    CompanyID = companies.FirstOrDefault(c => c.CompanyName == "Sony").CompanyID,
                },
            };

            _context.Products.AddRange(products);
            await _context.SaveChangesAsync();
        }

        private static async Task SeedCompany(ApplicationDbContext _context)
        {
            if (_context.Companies.Any()) return;
            var countries = await _context.Countries.ToListAsync();
            List<Company> companies = new List<Company>
            {
                new Company
                {
                    CompanyName = "Apple",
                    Year = 1976,
                    CountryID = countries.FirstOrDefault(c => c.CountryName == "USA").CountryID
                },
                new Company
                {
                    CompanyName = "Xiaomi",
                    Year = 2010,
                    CountryID = countries.FirstOrDefault(c => c.CountryName == "China").CountryID
                },
                new Company
                {
                    CompanyName = "Canon",
                    Year = 1987,
                    CountryID = countries.FirstOrDefault(c => c.CountryName == "China").CountryID
                },
                new Company
                {
                    CompanyName = "Panasonic",
                    Year = 1918,
                    CountryID = countries.FirstOrDefault(c => c.CountryName == "Japan").CountryID
                },
                new Company
                {
                    CompanyName = "CEDITA",
                    Year = 2005,
                    CountryID = countries.FirstOrDefault(c => c.CountryName == "United Kingdom").CountryID
                },
                new Company
                {
                    CompanyName = "TOZO",
                    Year = 2016,
                    CountryID = countries.FirstOrDefault(c => c.CountryName == "Spain").CountryID
                },
                new Company
                {
                    CompanyName = "Razer",
                    Year = 2010,
                    CountryID = countries.FirstOrDefault(c => c.CountryName == "USA").CountryID
                },
                new Company
                {
                    CompanyName = "Sony",
                    Year = 2000,
                    CountryID = countries.FirstOrDefault(c => c.CountryName == "USA").CountryID
                },
            };
            _context.Companies.AddRange(companies);
            await _context.SaveChangesAsync();
        }

        private static async Task SeedCountry(ApplicationDbContext _context)
        {
            if (_context.Countries.Any()) return;

            var countries = new List<Country>
            {
                new Country
                {
                    CountryName = "Spain"
                },
                new Country
                {
                    CountryName = "United Kingdom"
                },
                new Country
                {
                    CountryName = "Japan"
                },
                new Country
                {
                    CountryName = "China"
                },
                new Country
                {
                    CountryName = "USA"
                },
            };
            _context.Countries.AddRange(countries);
            await _context.SaveChangesAsync();
        }

        private static async Task SeedReview(ApplicationDbContext _context)
        {
            if (_context.Reviews.Any()) return;

            var products = await _context.Products.ToListAsync();

            var reviews = new List<Review>
            {
                new Review
                {
                    ProductID = products.FirstOrDefault(c => c.ProductName == "Razer Kraken Tournament Edition").ProductID,
                    Text = "The best",                    
                },
                new Review
                {
                    ProductID = products.FirstOrDefault(c => c.ProductName == "Razer Kraken Tournament Edition").ProductID,
                    Text = "The worst...",
                },
                new Review
                {
                    ProductID = products.FirstOrDefault(c => c.ProductName == "Razer Kraken Tournament Edition").ProductID,
                    Text = "Thank you",
                },
                new Review
                {
                    ProductID = products.FirstOrDefault(c => c.ProductName == "Sony PlayStation 4 Pro (Red Dead Redemption 2 Bundle)").ProductID,
                    Text = "Good!!!"
                },
                new Review
                {
                    ProductID = products.FirstOrDefault(c => c.ProductName == "PlayStation 4 Pro 1TB Limited Edition").ProductID,
                    Text = "Not bad!"
                },
            };
            _context.Reviews.AddRange(reviews);
            await _context.SaveChangesAsync();
        }

        private static async Task SeedRoles(ApplicationDbContext _context, RoleManager<IdentityRole> roleManager)
        {
            if (_context.Roles.Any()) return;
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Basic.ToString()));

        }

        private static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "superadmin@mail.ru",
                FirstName = "Eugene",
                LastName = "Yukovich",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                Gender = "Male",
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Ewgeny245*");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.SuperAdmin.ToString());
                }
            }
        }
    }
}
