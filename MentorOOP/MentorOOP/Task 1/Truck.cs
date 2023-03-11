using System;

namespace MentorOOP.Task_1
{
    public class Truck : VehicleAbstract
    {
        public Truck(string _make)
        {
            make = _make;
        }
        public override void Accelerating()
        {
            Console.WriteLine($"Truck is accelerating");
        }

        public override void Braking()
        {
            Console.WriteLine($"Truck is breaking");
        }

        public override void Turning()
        {
            Console.WriteLine($"Truck is turning");
        }
    }
}
