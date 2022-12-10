using System;

namespace Interface
{
    internal class Weapon
    {
        public string Name;

        public Weapon(string name)
        {
            Name = name;
        }

        public void Label()
        {
            Console.WriteLine($"This is {Name}!");
            
                
        }

    }
}
