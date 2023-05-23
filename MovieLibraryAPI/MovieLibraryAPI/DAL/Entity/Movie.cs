using System.Collections;
using System.Collections.Generic;

namespace MovieLibraryAPI.DAL.Entity
{
    public class Movie
    {
        //title,release year,genre,director,aktyorlari
        public int MovieID { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Title { get; set; }

        public ICollection<MovieActor> MovieActor { get; set; }
    }
}
