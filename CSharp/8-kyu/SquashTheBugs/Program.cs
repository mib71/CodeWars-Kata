using System;
using System.Linq;

namespace SquashTheBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLongest("Lets all go on holiday"));
        }
        
        private static int FindLongest(string str)
        {
            string[] spl = str.Split(' ');
            int longest = 0;

            for (int i = 0; i < spl.Length; i++)
            {
                if (spl[i].Length > longest)
                {
                    longest = spl[i].Length;
                }
            }
            return longest;
        }

        /* Refactored
        private static int FindLongest(string str)
        {
            return str.Split().Max(c => c.Length);
        }
         */
    }
}
