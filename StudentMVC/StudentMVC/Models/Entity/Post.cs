namespace StudentMVC.Models.Entity
{
    public class Post
    {
        public int id { get; set; }
        public int authorId { get; set; }
        public string text { get; set; }
        public DateTime publishedData { get; set; }
        public object comments { get; set; }
    }
}
