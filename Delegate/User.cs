using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public User()
        {
            
        }

        public void Diger(List<string> user)
        {
            foreach (var item in user)
            {
                Console.WriteLine(item);
            }
        }
    }
}
