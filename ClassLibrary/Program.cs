using System;
using MathLibrary;

namespace ClassLibrary
{
    internal class Program:MyMath
    {
        static void Main(string[] args)
        {
           // MyMath usingLib = new MyMath();
            Console.WriteLine(MyMath.AddNumber(1, 2, 3, 4));

           Console.WriteLine( Math.Sqrt(16));
            
        }
    }
}
