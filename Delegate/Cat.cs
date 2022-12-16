using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Cat
    {
        private int mood = 50, hungry = 50, energy = 50;
        
        public void Play(int value)
        {
            mood += value / 2;
            hungry += value;
            energy -= value+10;

            Console.WriteLine($"Mood {mood}, Hungry {hungry}, Energy {energy}");
        }

        public void Feed(int value)
        {
            mood -= value;
            hungry += value*value;
            energy += value/2;

            Console.WriteLine($"Mood {mood}, Hungry {hungry}, Energy {energy}");
        }

        public void Sleep(int value)
        {
            mood -= value / 2;
            hungry -= value;
            energy += value;

            Console.WriteLine($"Mood {mood}, Hungry {hungry}, Energy {energy}");
        }
    }
}
