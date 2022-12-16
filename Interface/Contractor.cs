using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Contractor : Employee
    {
        int workingHours;

        public Contractor(string _name, int _workingHours) : base(_name)
        {
            workingHours = _workingHours;
            
        }

        public override void Calculate()
        {
            int salary = workingHours * paymentperHour;
            Console.WriteLine($"{name} get {salary}");
        }
    }
}
