using System;

namespace BookAtticApi.Domain.DTO
{
    public class SellectBookDTO
    {
        public int BookId { get; set; }
        public int Page { get; set; }
        public string BookName { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

}
