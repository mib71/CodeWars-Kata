using System;
using System.Linq;

namespace GetTheMeanOfAnArray
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetAverage(new int[] { 3, 4, 5, 4, 3, 5 }));
        }

        private static int GetAverage(int[] marks)
        {
            return (int)marks.Average();
        }
    }
    
}
