using System;

namespace YoureASquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSquare(121));
        }

        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}
