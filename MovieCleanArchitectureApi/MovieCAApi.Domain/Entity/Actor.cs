using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovieCAApi.Domain.Entity
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string ActorName { get; set; }

        public ICollection<MovieActor> MovieActor { get; set; }

    }
}
