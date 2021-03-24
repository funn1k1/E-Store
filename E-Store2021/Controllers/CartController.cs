using E_Store2021.Data;
using E_Store2021.Helpers;
using E_Store2021.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Store2021.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;
        SignInManager<ApplicationUser> signinManager;
        UserManager<ApplicationUser> userManager;
        public CartController(ApplicationDbContext context, SignInManager<ApplicationUser> _signinManager, UserManager<ApplicationUser> _userManager)
        {
            _context = context;
            signinManager = _signinManager;
            userManager = _userManager;

        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            ShoppingCartModel.ShoppingCartItems = cart;
            ShoppingCartModel.Total = (cart != null) ? Math.Round((decimal)cart?.Sum(item => item.Product.UnitPrice * item.Quantity), 2) : 0m;
            ShoppingCartModel.Count = cart?.Sum(item => item.Quantity);

            if (ShoppingCartModel.CouponName != null)
            {
                decimal price = Math.Round((decimal)(ShoppingCartModel.Total - ShoppingCartModel.Total * (decimal)ShoppingCartModel.Discount / 100), 2);
                ShoppingCartModel.SpecialPrice = price;
            }
            return View();
        }

        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart") == null)
            {
                List<ShoppingCartItem> cart = new List<ShoppingCartItem>();
                cart.Add(new ShoppingCartItem { Product = _context.Products.Include(p => p.SubCategory).ThenInclude(p => p.Category).Include(p => p.Company).FirstOrDefault(p => p.ProductID == id), Quantity = 1,
                    TotalPrice = Math.Round(_context.Products.FirstOrDefault(p => p.ProductID == id).UnitPrice, 2) });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
                int index = IsExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                    cart[index].TotalPrice = Math.Round(cart[index].Product.UnitPrice * cart[index].Quantity, 2);
                }
                else
                    cart.Add(new ShoppingCartItem { Product = _context.Products.Include(p => p.SubCategory).ThenInclude(p => p.Category).Include(p => p.Company).FirstOrDefault(p => p.ProductID == id), Quantity = 1,
                        TotalPrice = Math.Round(_context.Products.FirstOrDefault(p => p.ProductID == id).UnitPrice, 2) });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public IActionResult Remove(int id)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            int index = IsExist(id);

            cart.RemoveAt(index);

            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public IActionResult UpdateQuantity(int id, int quantity)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");

            int index = IsExist(id);


            return View();
        }

        [HttpPost]
        public IActionResult UpdateCartPrice(string id, string couponName)
        {
            if (_context.Coupons.Any(c => c.Name == couponName))
            {
                var coupon = _context.Coupons.FirstOrDefault(c => c.Name == couponName);
                var user = userManager.FindByIdAsync(id);
                if (user.GetAwaiter().GetResult().Id == coupon.UserId)
                {
                    ShoppingCartModel.SpecialPrice = Math.Round((decimal)(ShoppingCartModel.Total - ShoppingCartModel.Total * (decimal)coupon.Discount / 100), 2);
                    ShoppingCartModel.Discount = coupon.Discount;
                    ShoppingCartModel.CouponName = couponName;
                }
                return View(nameof(Index));
            }
            else
            {
                return View(nameof(Index));
            }
                
        }

        [AllowAnonymous]
        private int IsExist(int id)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductID.Equals(id))
                    return i;
            }
            return -1;
        }


    }
}