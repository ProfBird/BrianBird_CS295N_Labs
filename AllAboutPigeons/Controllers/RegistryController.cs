using AllAboutPigeons.Data;
using AllAboutPigeons.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllAboutPigeons.Controllers
{
    public class RegistryController : Controller
    {
        AppDbContext context;

        public RegistryController(AppDbContext c)
        {
            context = c;
        }

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
            model.Date = DateOnly.FromDateTime(DateTime.Now);
            // Temporarily add a random rating to the post
            Random random = new Random();
            model.Rating = random.Next(0, 10);

            // Save the post to the database
            context.Messages.Add(model);
            context.SaveChanges();

            // No longer returning a model directly to Index.cshtml
            // return View("Index", model);
            return RedirectToAction("Index", new { reviewId = model.MessageId });
        }

            public IActionResult Info()
        {
            return View();
        }

    }
}
