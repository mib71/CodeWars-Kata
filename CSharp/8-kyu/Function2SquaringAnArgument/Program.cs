using System;

namespace Function2SquaringAnArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(7));
        }

        public static double Square(double n)
        {
            return n * n;            
        }
    }
}
