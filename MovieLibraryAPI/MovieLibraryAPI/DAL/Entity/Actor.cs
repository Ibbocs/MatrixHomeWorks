using System.Collections.Generic;

namespace MovieLibraryAPI.DAL.Entity
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string ActorName { get; set; }

        public ICollection<MovieActor> MovieActor { get; set; }

    }
}
