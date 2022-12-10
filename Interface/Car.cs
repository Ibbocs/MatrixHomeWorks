using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Car : IVehicle
    {
        public int Fuel { get; set; }
        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0 )
            {
                Console.WriteLine("Car is driving");
            }
        }

        public bool Refuel(int amount)
        {
            if (Fuel == 0)
            {
                Fuel = amount;
            }
            return true;
        }
    }
}
