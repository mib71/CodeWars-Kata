using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(4));
        }

        private static int factorial(int n)
        {
            return (n == 0) ? 1 : n * factorial(n - 1); 
        }
    }
}
