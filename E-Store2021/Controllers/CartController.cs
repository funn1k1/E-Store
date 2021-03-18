using E_Store2021.Data;
using E_Store2021.Helpers;
using E_Store2021.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            ShoppingCartModel.ShoppingCartItems = cart;
            ShoppingCartModel.Total = Math.Ceiling((decimal)cart?.Sum(item => item.Product.UnitPrice * item.Quantity));
            ShoppingCartModel.Count = cart?.Sum(item => item.Quantity);
            return View();
        }

        [AllowAnonymous]
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart") == null)
            {
                List<ShoppingCartItem> cart = new List<ShoppingCartItem>();
                cart.Add(new ShoppingCartItem { Product = _context.Products.Include(p => p.SubCategory).ThenInclude(p => p.Category).Include(p => p.Company).FirstOrDefault(p => p.ProductID == id), Quantity = 1, TotalPrice = Math.Ceiling(_context.Products.FirstOrDefault(p => p.ProductID == id).UnitPrice)});
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
                int index = IsExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                    cart[index].TotalPrice = Math.Ceiling(cart[index].Product.UnitPrice * cart[index].Quantity); 
                   
                }                    
                else
                    cart.Add(new ShoppingCartItem { Product = _context.Products.Include(p => p.SubCategory).ThenInclude(p => p.Category).Include(p => p.Company).FirstOrDefault(p => p.ProductID == id), Quantity = 1, TotalPrice = Math.Ceiling(_context.Products.FirstOrDefault(p => p.ProductID == id).UnitPrice) });
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