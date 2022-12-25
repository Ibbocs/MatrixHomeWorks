using System;
using MathLibrary;

namespace ClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            Console.WriteLine(myMath.AddNumber(1, 2, 3, 4));
            

            
        }
    }
}
