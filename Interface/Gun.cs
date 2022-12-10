using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Gun : Weapon,IShootable
    {
        public Gun(string name) : base(name)
        {
        }

        public void Shoot()
        {
            Console.WriteLine("Shooted");
        }
    }
}
