using System;

namespace GrasshopperPersonalizedMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greet("owner", "owner"));
        }

        private static string Greet(string name, string owner)
        {
            return (name == owner) ? "Hello boss" : "Hello guest";
        }
    }
}
