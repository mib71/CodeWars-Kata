using System;

namespace GrasshopperGradeBook
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine(GetGrade(95, 90, 93));
        }

        public static char GetGrade(int s1, int s2, int s3)
        {
            int sum = ((s1 + s2 + s3) / 3);

            if (sum < 60) { return 'F'; }
            if (sum < 70) { return 'D'; }
            if (sum < 80) { return 'C'; }
            if (sum < 90) { return 'B'; }
            return 'A';


        }
    }
}
