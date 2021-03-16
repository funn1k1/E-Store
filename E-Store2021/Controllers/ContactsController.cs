using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Controllers
{
    public class ContactsController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

    }
}
