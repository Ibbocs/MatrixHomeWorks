using System;

namespace BookAtticApi.Domain.DTO
{
    public class SellectAllBPAInfoDTO
    {
        public int BookId { get; set; }
        public int Page { get; set; }
        public string BookName { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int AuthorId { get; set; }
        public string AuthorSurname { get; set; }
        public string AuthorName { get; set; }

        public int PublisherId { get; set; }
        public int PublisherPrice { get; set; }
        public string PublisherName { get; set; }
    }
}
