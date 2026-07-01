namespace MicroBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Now;
        public string Author { get; set; } = "";
    }
}