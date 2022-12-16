using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Person
    {
        string firstname, lastname;
        public Person(string name, string lName)
        {
            firstname= name;
            lastname= lName;
        }

        public void WriteName()
        {
            Console.WriteLine(firstname);
        }

        public void WriteLastName() 
        { 
            Console.WriteLine(lastname);
        }
    }
}
