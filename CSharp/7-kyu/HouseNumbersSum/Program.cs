using System;

namespace HouseNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HouseNumbersSum(new int[] { 5, 1, 2, 3, 0, 1, 5, 0, 2 }));
        }
        public static int HouseNumbersSum(int[] inputArray)
        {
            int rv = 0;
            foreach (int housnumber in inputArray)
            {
                rv += housnumber;
                if (housnumber == 0) break;
            }
            return rv;
        }
    }
}
