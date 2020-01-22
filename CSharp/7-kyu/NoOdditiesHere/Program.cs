using System;
using System.Linq;

namespace NoOdditiesHere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoOdds(new int[] { 1, 2, 3, 4, 5 }));
        }

        public static int[] NoOdds(int[] values)
        {
            return values.Where(s => s % 2 == 0).ToArray();
        }

    }
}
