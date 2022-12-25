using System;
using MathLibrary;

namespace ClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath usingLib = new MyMath();
            Console.WriteLine(usingLib.AddNumber(1, 2, 3, 4));
            

            
        }
    }
}
