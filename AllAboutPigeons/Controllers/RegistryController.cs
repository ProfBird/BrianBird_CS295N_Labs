using AllAboutPigeons.Data;
using AllAboutPigeons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllAboutPigeons.Controllers
{
    public class RegistryController : Controller
    {
        AppDbContext context;
        public RegistryController(AppDbContext c) {
            context = c;
        }
        
        public IActionResult Index(string messageId)
        {
            // Show all the posts in the database
            // TODO: Limit the posts shown to some practical number
            var model = context.Messages
                .Include(m => m.To)
                .Include(m => m.From)
                .ToList();
            ViewBag.LatestId = messageId;
            return View(model);
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

            // Save model to db
            context.Messages.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index", new { model.MessageId });
        }

            public IActionResult Info()
        {
            return View();
        }

    }
}
