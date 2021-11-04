using System;
using System.Collections.Generic;

namespace NumberOfPeopleInTheBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Number(new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } }));
        }

        #region Kata
        private static int Number(List<int[]> peopleListInOut)
        {
            int passengers = 0;
            foreach (int[] stop in peopleListInOut)
            {
                passengers += stop[0];
                passengers -= stop[1];                
            }
            return passengers;
        }
        #endregion
    }
}
