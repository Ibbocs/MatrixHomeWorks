using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class Employee
    {
        protected string name;
        protected int paymentperHour = 2;

        public Employee(string _name)
        {
            name= _name;
        }

        public abstract void Calculate();
    }
}
