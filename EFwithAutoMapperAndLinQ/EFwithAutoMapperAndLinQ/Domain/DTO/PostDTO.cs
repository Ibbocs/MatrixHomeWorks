using System;

namespace EFwithAutoMapperAndLinQ.Domain.DTO
{
    public class PostDTO
    {
        public int AuthorId { get; set; }
        public string Text { get; set; }
        public DateTime PublishedData { get; set; }
    }
}
