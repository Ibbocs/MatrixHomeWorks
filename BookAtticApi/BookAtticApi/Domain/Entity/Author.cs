using System.Collections.Generic;

namespace BookAtticApi.Domain.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

        //author-book one-to-many
        public ICollection<Book> Books { get; set; }
    }
}
