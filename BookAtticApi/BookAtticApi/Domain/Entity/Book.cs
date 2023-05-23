using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace BookAtticApi.Domain.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        //author-book one-to-many
        public Author Author { get; set; }
        public int AuthorId { get; set; }

        //publisher-book many-to-many
        public ICollection<BookPublisher> bookPublishers { get; set; }
    }
}
