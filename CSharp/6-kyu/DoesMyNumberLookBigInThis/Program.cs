using System;

namespace DoesMyNumberLookBigInThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(371));
        }

        public static bool Narcissistic(int value)
        {
            double sum = 0;
            int powerOf = value.ToString().Length;
            
            foreach (var c in value.ToString())
            {                
                int chr = int.Parse(c.ToString());                
                sum += Math.Pow(chr, powerOf);                
            }

            return (sum == value) ? true : false;
        }
    }
}
