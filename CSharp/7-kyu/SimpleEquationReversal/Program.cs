using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleEquationReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("y/b*100"));
        }

        private static string Solve(string eq)
        {
            return string.Join("", Regex.Split(eq, @"(\*)|(\+)|(-)|(/)").Reverse());            
        }
    }
}
