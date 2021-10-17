using System;
using System.Linq;

namespace FindTheSmallestIntegerInTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSmallestInt(new int[] { 34, 15, 88, 2 }));
        }

        private static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }
    }
}
