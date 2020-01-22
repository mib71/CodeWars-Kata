using System;
using System.Linq;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OddOrEven(new int[]{ 1023, 1, 2}));
        }
        public static string OddOrEven(int[] array)
        {
            return (array.Sum() % 2 == 0) ? "even" : "odd";
        }
    }
}
