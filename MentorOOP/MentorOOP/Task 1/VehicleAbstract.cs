using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorOOP.Task_1
{
    public  abstract class VehicleAbstract
    {
        public string make, model;
        public int year;
        public int price;

        public abstract void Accelerating();

        public abstract void Braking();

        public abstract void Turning();
    }
}
