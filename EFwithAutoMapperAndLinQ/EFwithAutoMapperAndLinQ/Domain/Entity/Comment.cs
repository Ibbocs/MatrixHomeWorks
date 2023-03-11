namespace EFwithAutoMapperAndLinQ.Domain.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }

        public Post Post { get; set; }
    }
}
