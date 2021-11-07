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
            int distance = 0;
            for (int i = 1; i < array.Length; i++)
            {
                distance += Math.Abs(array[i - 1] - array[i]);
            }

            return distance;
        }
        #endregion
    }
}
