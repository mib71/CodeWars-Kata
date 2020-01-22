using System;
using System.Linq;

namespace ArrayPlusArray
{
    class Program
    {
        /** 8 kyu Array plus array
             * Description:
             * I'm new to coding and now I want to get the sum of two arrays...actually 
             * the sum of all their elements. I'll appreciate for your help.
             * 
             * P.S. Each array includes only integer numbers. Output is a number too.*/

        static void Main(string[] args)
        {
            Console.WriteLine(ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
        }
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }
    }
}
