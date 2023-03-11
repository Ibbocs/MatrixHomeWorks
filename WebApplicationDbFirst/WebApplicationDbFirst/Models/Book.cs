using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationDbFirst.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }

        public virtual BookAuthor BookAuthor { get; set; }
    }
}
