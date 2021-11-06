using System;

namespace GreetMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greet("mib"));
        }

        #region Kata
        private static string Greet(string name)
        {
            return $"Hello {name.ToUpper()[0] + name.ToLower()[1..]}!";
        }
        #endregion
    }
}
