using System;

namespace GrasshopperGradeBook
{
    class Program
    {
        /** 8 kyu Grasshopper - Grade book
         * Complete the function so that it finds the mean of the three scores 
         * passed to it and returns the letter value associated with that grade.
         * 
         * 90 <= score <= 100	'A'
         * 80 <= score < 90	'B'
         * 70 <= score < 80	'C'
         * 60 <= score < 70	'D'
         * 0 <= score < 60	'F'
         * 
         * Tested values are all between 0 and 100. Theres is no need to check for
         * negative values or values greater than 100.*/

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
