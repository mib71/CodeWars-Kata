using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueSum(new List<int>() { 1, 3, 8, 1, 8 }));
        }

        private static int? UniqueSum(List<int> lst)
        {
            return lst.Any() ? lst.Distinct().Sum() : new int();            
        }
    }
}
