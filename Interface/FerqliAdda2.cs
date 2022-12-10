using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class FerqliAdda2 : ILogger
    {
        public void LogInformation()
        {
            try
            {
                Proses2(16);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        private void Proses2(byte a)
        {
            int b = (a + 250);
            Console.WriteLine(b);
        }
    }
}
