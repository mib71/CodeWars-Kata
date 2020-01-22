using System;
using System.Collections.Generic;

namespace FindElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindAll(new int[] { 6, 9, 3, 4, 3, 82, 11 }, 3)); 
        }
        public static int[] FindAll(int[] array, int n)
        {
            List<int> rv = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    rv.Add(i);
                }
            }

            return rv.ToArray();
        }
    }
}
