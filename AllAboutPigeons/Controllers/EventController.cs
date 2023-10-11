using Microsoft.AspNetCore.Mvc;

namespace AllAboutPigeons.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
