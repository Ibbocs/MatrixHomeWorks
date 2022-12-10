using System;

namespace Interface
{
    internal class FerqliAdda1 : ILogger
    {
        public void LogInformation()
        {
            try
            {
                Console.WriteLine("Enter Number:");
                string a = Console.ReadLine();
                Proses(a);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private void Proses(string _a)
        {
            int b = int.Parse(_a);
            Console.WriteLine(b);
        }
    }
}
