using System.Collections.Generic;

namespace BartenderDrinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDrinkByProfession("salted Kex"));
        }

        public static string GetDrinkByProfession(string p)
        {
            if (words.TryGetValue(p.ToLower(), out var output))
            {
                return output;
            }

            return "Beer";
        }

        private static Dictionary<string, string> words = new()
        {
            { "jabroni", "Patron Tequila" },
            { "school counselor", "Anything with Alcohol" },
            { "programmer", "Hipster Craft Beer" },
            { "bike gang member", "Moonshine" },
            { "politician", "Your tax dollars" },
            { "rapper", "Cristal" }	
        };
    }
}
