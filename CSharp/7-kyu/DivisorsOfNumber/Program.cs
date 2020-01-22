using System;

namespace DivisorsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divisors(30));
        }
        public static int Divisors(int n)
        {
            int rv = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) rv++;
            }
            return rv;
        }
    }
}
