using System;

namespace SimpleMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(3));
        }
        public static int Multiply(int x)
        {
            return x % 2 == 0 ? x = x * 8 : x = x * 9;
        }
    }
}
