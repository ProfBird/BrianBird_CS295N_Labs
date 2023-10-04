using Microsoft.AspNetCore.Mvc;

namespace AllAboutPigeons.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
