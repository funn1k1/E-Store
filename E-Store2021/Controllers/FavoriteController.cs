using E_Store2021.Data;
using E_Store2021.Helpers;
using E_Store2021.Models;
using E_Store2021.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class FavoriteController : Controller
    {
        private ApplicationDbContext _context;
        
        public FavoriteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var favorite = SessionHelper.GetObjectFromJson<List<FavoriteItem>>(HttpContext.Session, "favorite");
            FavoriteModel.FavoriteItems = favorite;
            return View();
        }

        public IActionResult Add(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<FavoriteItem>>(HttpContext.Session, "favorite") == null)
            {
                List<FavoriteItem> favorite = new List<FavoriteItem>();
                favorite.Add(new FavoriteItem { Product = _context.Products.FirstOrDefault(p => p.ProductID == id)});
                SessionHelper.SetObjectAsJson(HttpContext.Session, "favorite", favorite);
            }
            else
            {
                List<FavoriteItem> favorite = SessionHelper.GetObjectFromJson<List<FavoriteItem>>(HttpContext.Session, "favorite");
                int index = IsExist(id);
                if (index == -1)
                    favorite.Add(new FavoriteItem { Product = _context.Products.FirstOrDefault(p => p.ProductID == id) });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "favorite", favorite);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            List<FavoriteItem> favorite = SessionHelper.GetObjectFromJson<List<FavoriteItem>>(HttpContext.Session, "favorite");
            int index = IsExist(id);

            favorite.RemoveAt(index);

            SessionHelper.SetObjectAsJson(HttpContext.Session, "favorite", favorite);

            return RedirectToAction("Index");
        }

        private int IsExist(int id)
        {
            List<FavoriteItem> favorite = SessionHelper.GetObjectFromJson<List<FavoriteItem>>(HttpContext.Session, "favorite");
            for (int i = 0; i < favorite.Count; i++)
            {
                if (favorite[i].Product.ProductID.Equals(id))
                    return i;
            }
            return -1;
        }
    }
}
