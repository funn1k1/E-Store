using Microsoft.AspNetCore.Mvc;

namespace E_Store2021.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}