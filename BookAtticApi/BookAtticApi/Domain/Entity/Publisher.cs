using System.Collections.Generic;

namespace BookAtticApi.Domain.Entity
{
    public class Publisher
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }

        //publisher-book many-to-many
        public ICollection<BookPublisher> bookPublishers { get; set; }
    }
}
