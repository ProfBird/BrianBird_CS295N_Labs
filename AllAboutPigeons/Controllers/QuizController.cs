using AllAboutPigeons.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace AllAboutPigeons.Controllers
{
    public class QuizController : Controller
    {
        public Dictionary<int, String> Questions { get; set; }
        public Dictionary<int, String> Answers { get; set; }

        public QuizController()
        {
            // Temporary set of hard-coded questions
            // In the future we'll read these from a file.
            Questions = new Dictionary<int, String>();
            Answers = new Dictionary<int, String>();
            Questions[1] = "Are all pigeons homing pigeons?";
            Answers[1] = "No";
            Questions[2] = "Are all pigeons secretly government spies?";
            Answers[2] = "Only Some";
            Questions[3] = "Where do pigeons sleep";
            Answers[3] = "The Pentagon";
        }

        public IActionResult Index()
        {
            var model = LoadQuestions(new QuizQuestions());
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string answer1, string answer2, string answer3) 
        { 
            var model = LoadQuestions(new QuizQuestions());
            model.UserAnswers[1] = answer1;
            return View(model);
        }

        public QuizQuestions LoadQuestions(QuizQuestions model)
        {
            // TODO: load questions and answers
            // into the model
            model.Questions = Questions;
            model.Answers = Answers;
            model.UserAnswers = new Dictionary<int, string>();
            // create empty entries for each question
            foreach (var question in Questions)
            {
                int key = question.Key;
                model.UserAnswers[key] = "";
            }

            return model;
        }

        public Dictionary<int, bool> checkQuizAnswers(QuizQuestions model) 
        { 
            var result = new Dictionary<int, bool>();
            foreach (var question in Questions) 
            {
                int key = question.Key;
                result[key] = model.Answers[key] == model.UserAnswers[key];
            }
            return result;
        }
    }
}
