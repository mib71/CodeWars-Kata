using System;

namespace CanWeDivideIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_divide_by(-12, 2, -5 ));
        }

        private static bool is_divide_by(int number, int a, int b)
        {
            return number % a == 0 && number % b == 0;
        }
    }
}
