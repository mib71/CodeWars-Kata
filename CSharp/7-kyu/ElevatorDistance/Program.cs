using System;

namespace ElevatorDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ElevatorDistance(new int[] { 5, 2, 8 }));
        }

        #region Kata
        private static int ElevatorDistance(int[] array)
        {
            int res = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i > 0)
                {
                    if (array[i] < array[i - 1])
                        res += (array[i] - array[i - 1]) * -1;
                    else
                        res += (array[i] - array[i - 1]);
                }
            }

            return res;
        }
        #endregion
    }
}
