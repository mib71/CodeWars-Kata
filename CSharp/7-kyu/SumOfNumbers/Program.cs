using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShowSequence(6));
        }
        public static string ShowSequence(int n)
        {
            string rv = "";
            List<string> rvList = new List<string>();
            int sum = 0;

            if (n < 0) return rv = n + "<0";
            if (n == 0) return rv = n + "=0";

            for (int i = 0; i <= n; i++)
            {
                sum += i;
                if(i < n)
                {
                    rvList.Add(i + "+");
                }
                if(i == n)
                {
                    rvList.Add(i + " = " + sum);
                    rv = string.Join("", rvList);
                }
                 
            }
            
            return rv;
        }
    }
}
