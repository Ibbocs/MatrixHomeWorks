namespace StudentMVC.Models.Entity
{
    public class Root
    {
        public int id { get; set; }
        public int authorId { get; set; }
        public string text { get; set; }
        public Post post { get; set; }
    }
}
