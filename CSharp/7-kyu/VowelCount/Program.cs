using System;
using System.Linq;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("abracadabra"));
        }

        private static int GetVowelCount(string str)
        {            
            string vowels = "aeiou" ;
            return str.Count(c => vowels.Contains(c));            
        }
    }
}
