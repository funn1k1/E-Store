using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class SubCategoryManager : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
