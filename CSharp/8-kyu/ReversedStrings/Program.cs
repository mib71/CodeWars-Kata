using System;
using System.Linq;

namespace ReversedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("hello world"));
        }

        private static string Solution(string str)
        {            
            return string.Concat(str.Reverse());

            /*
            //First try

            string reversRes = "";
            char[] revArray = str.Reverse().ToArray();

            foreach (var c in revArray)
            {
                reversRes += c.ToString();
            }            

            return reversRes;
            */
        }
    }
}
