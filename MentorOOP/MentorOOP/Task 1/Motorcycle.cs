using System;

namespace MentorOOP.Task_1
{
    public class Motorcycle : VehicleAbstract
    {
        public override void Accelerating()
        {
            Console.WriteLine($"Motorcycle is accelerating");
        }

        public override void Braking()
        {
            Console.WriteLine($"Motorcycle is breaking");
        }

        public override void Turning()
        {
            Console.WriteLine($"Motorcycle is turning");
        }
    }
}
