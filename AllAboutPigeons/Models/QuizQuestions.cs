namespace AllAboutPigeons.Models
{
    public class QuizQuestions

    {
        public Dictionary<int, String> Questions { get; }
        public Dictionary<int, String> Answers { get; }
        public Dictionary<int, String> UserAnswers { get; }  
        public Dictionary <int, bool> Results { get; } // result of checking the answers
    }
}
