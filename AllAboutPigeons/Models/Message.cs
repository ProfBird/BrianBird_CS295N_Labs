namespace AllAboutPigeons.Models
{
    public class Message
    {
        public AppUser To {  get; set; }
        public AppUser From { get; set; }
        public string Text {  get; set; }
        public DateOnly Date {  get; set; }
    }
}
