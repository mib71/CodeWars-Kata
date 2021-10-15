using System;
using System.Linq;

namespace FindTheStrayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Stray(new int[] {1, 1, 3 }));
        }

        public static int Stray(int[] numbers)
        {            
            return numbers.First(n => numbers.Count(x => x == n) == 1);
        }
    }
}
