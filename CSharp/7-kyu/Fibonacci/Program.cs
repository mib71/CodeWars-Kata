using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(9));
        }

        private static int Fib(int n)
        {
            return n < 2 ? n : Fib(n - 1) + Fib(n - 2);
        }
        
        //https://en.wikipedia.org/wiki/Fibonacci_number

        //First try

        //int fibA = 0;
        //int fibB = 1;
        //int res = 0;
        //for (int i = 2; i <= n; i++)
        //{
        //    res = fibA + fibB;
        //    fibA = fibB;
        //    fibB = res;
        //}

        //return res;

    }
}
