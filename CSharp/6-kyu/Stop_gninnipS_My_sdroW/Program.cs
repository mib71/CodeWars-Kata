using System.Linq;

namespace Stop_gninnipS_My_sdroW
{
    /// <summary>
    /// Write a function that takes in a string of one or more words, and returns the same string, 
    /// but with all words that have five or more letters reversed (Just like the name of this Kata). 
    /// Strings passed in will consist of only letters and spaces. Spaces will be included only when 
    /// more than one word is present.
    /// 
    /// "Hey fellow warriors"  --> "Hey wollef sroirraw" 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpinWords("Hey fellow warriors"));
        }

        public static string SpinWords(string sentence)
        {                        
            return string.Join(" ", sentence.Split(' ').ToList().Select(x =>
                x.Length >= 5 ? new string(x.Reverse().ToArray()) : x).ToList());
        }
    }
}
