using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(rowSumOddNumbers(42));
        }
        public static long rowSumOddNumbers(long n)
        {
            return n * n * n;
        }
    }
}
