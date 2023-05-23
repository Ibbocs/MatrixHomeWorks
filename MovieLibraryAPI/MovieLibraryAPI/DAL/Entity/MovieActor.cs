﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLibraryAPI.DAL.Entity
{
    public class MovieActor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieActorID { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }


    }
}
