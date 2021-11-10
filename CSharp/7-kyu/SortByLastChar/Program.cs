using System;
using System.Linq;

namespace SortByLastChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Last("abc cba cab"));
        }

        private static string[] Last(string x)
        {
            return x.Split(' ').OrderBy(x => x.Last()).ToArray();            
        }
    }
}
