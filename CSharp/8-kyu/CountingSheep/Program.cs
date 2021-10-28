using System;
using System.Linq;

namespace CountingSheep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSheeps(new bool[] { true, false, true }));
        }

        private static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }
    }
}
