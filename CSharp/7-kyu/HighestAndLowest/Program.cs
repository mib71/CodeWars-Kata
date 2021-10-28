using System;
using System.Linq;

namespace HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }

        private static string HighAndLow(string numbers)
        {
            string[] numberArray = numbers.Split(' ').ToArray();
            int min = numberArray.Select(int.Parse).Min();
            int max = numberArray.Select(int.Parse).Max();

            return $"{max} {min}";
        }
    }
}
