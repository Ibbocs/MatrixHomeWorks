using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorOOP.Task3
{
    public abstract class Game
    {
        public int healthPoints, attackPower, velocity;

        public abstract bool Movement();
        
    }


}
