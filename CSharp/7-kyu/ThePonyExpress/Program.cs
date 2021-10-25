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
            int temp = 0;
            for (int i = 0; i < stations.Length; i++)
            {
                temp += stations[i];
                if (temp >= 100)
                {
                    temp = 0;
                    riders++;
                    i--;
                }
            }
            
            return riders;
        }
    }
}
