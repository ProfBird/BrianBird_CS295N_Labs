using AllAboutPigeons.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace AllAboutPigeons.Controllers
{
    public class QuizController : Controller
    {
        public Dictionary<int, String> Questions { get; set; }
        public Dictionary<int, String> Answers { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public Tests LoadQuestions(Tests model)
        {
            // Temporary set of hard-coded questions
            // In the future we'll read these from a file.
            
            // TODO: load questions and answers
            // into the model
            return model;
        }
    }
}
