using AllAboutPigeons.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllAboutPigeons.Controllers
{
    public class RegistryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ForumPost() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForumPost(Message model)
        { 
            return View("Index", model); 
        }

        public IActionResult Info()
        {
            return View();
        }

    }
}
