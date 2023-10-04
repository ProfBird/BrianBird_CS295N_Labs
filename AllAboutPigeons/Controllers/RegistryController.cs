using Microsoft.AspNetCore.Mvc;

namespace AllAboutPigeons.Controllers
{
    public class RegistryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

    }
}
