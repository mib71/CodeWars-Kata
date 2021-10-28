using System;

namespace OppositesAttract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lovefunc(1, 2));
        }

        private static bool lovefunc(int flower1, int flower2)
        {
            return ((flower1 + flower2) % 2 != 0) ? true : false;
        }
    }
}
