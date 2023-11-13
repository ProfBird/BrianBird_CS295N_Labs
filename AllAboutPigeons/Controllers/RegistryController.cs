﻿using AllAboutPigeons.Data;
using AllAboutPigeons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllAboutPigeons.Controllers
{
    public class RegistryController : Controller
    {
       // AppDbContext context;
       IRegistryRepository repository;
        public RegistryController(IRegistryRepository r) {
            repository = r;
        }

        // TODO: Do something interesting with the messageId
        public IActionResult Index(string messageId)
        {
            // Get the last post out of the database
            var messages = repository.GetMessages();
               // .Where(m => m.MessageId == int.Parse(messageId))
               // .FirstOrDefault();
               // .Find(int.Parse(messageId));
            return View(messages);
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
            int result;
            result = repository.StoreMessage(model);
            // TODO: Do something with the result
            return RedirectToAction("Index", new { model.MessageId });
        }

            public IActionResult Info()
        {
            return View();
        }

    }
}
