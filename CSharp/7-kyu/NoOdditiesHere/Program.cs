using System;
using System.Linq;

namespace NoOdditiesHere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] noOdds = NoOdds(new int[] { 1, 2, 3, 4, 5 });
            foreach (var value in noOdds)
                Console.WriteLine(value);
        }

        public static int[] NoOdds(int[] values)
        {
            return values.Where(s => s % 2 == 0).ToArray();
        }

    }
}
