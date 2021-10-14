using System;

namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(9119));
        }

        public static int SquareDigits(int n)
        {
            string result = "";
            
            foreach (var c in n.ToString())
            {
                int sqareIt = int.Parse(c.ToString());
                result += (sqareIt * sqareIt);
            }
            
            return int.Parse(result);
        }
    }
}
