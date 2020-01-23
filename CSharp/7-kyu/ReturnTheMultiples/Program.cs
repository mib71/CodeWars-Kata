using System;

namespace ReturnTheMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiples(3, 5);
        }
        public static double[] Multiples(int m, double n)
        {
            double[] rv = new double[m];
            for (int i = 0; i < m; i++)
            {
                rv[i] = (i + 1) * n;
            }
            return rv;
        }
    }
}
