using System;

namespace MathLibrary
{
    public class MyMath
    {
        public int AddNumber(params int[] num) 
        {
            int result = 0;

            for (int i = 0; i < num.Length; i++)
            {
                result+= num[i];
            }
            return result;
        } 
    }
}
