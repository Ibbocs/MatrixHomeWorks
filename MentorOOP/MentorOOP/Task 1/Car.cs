using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorOOP.Task_1
{
    public class Car : VehicleAbstract
    {
        public override void Accelerating()
        {
            Console.WriteLine($"Car is accelerating");
        }

        public override void Braking()
        {
            Console.WriteLine($"Car is breaking");
        }

        public override void Turning()
        {
            Console.WriteLine($"Car is turning");
        }
    }
}
