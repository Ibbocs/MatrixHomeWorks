using System;

namespace MentorOOP.Task_1
{
    public class Boat : VehicleAbstract
    {
        public override void Accelerating()
        {
            Console.WriteLine($"Boat is accelerating");
        }

        public override void Braking()
        {
            Console.WriteLine($"Boat is breaking");
        }

        public override void Turning()
        {
            Console.WriteLine($"Boat is turning");
        }
    }
}
