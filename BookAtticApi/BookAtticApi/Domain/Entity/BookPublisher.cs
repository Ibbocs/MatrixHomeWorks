namespace BookAtticApi.Domain.Entity
{
    public class BookPublisher
    {
        //publisher-book many-to-many

        public Book Book { get; set; }
        public int BookId { get; set; }

        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
        
    }
}
