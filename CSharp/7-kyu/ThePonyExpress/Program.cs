using System;

namespace ThePonyExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Riders(new int[] { 6, 24, 6, 8, 28, 8, 23, 47, 17, 29, 37, 18, 40, 49 }));
        }

        private static int Riders(int[] stations)
        {
            int riders = 1;
            int distance = 0;
            for (int i = 0; i < stations.Length; i++)
            {
                distance += stations[i];
                if (distance >= 100)
                {
                    distance = 0;
                    riders++;
                    i--;
                }
            }
            
            return riders;
        }
    }
}
