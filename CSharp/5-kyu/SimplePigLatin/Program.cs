namespace SimplePigLatin
{
    /// <summary>
    /// Move the first letter of each word to the end of it, then add 
    /// "ay" to the end of the word. Leave punctuation marks untouched.
    /// 
    /// Kata.PigIt("Pig latin is cool!"); // igPay atinlay siay oolcay!
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Hello world !"));
        }

        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split(' ').Select(word =>
            {
                if (word.All(char.IsLetter))
                    return $"{word.Substring(1)}{word[0]}ay";
                else
                    return word;
            }));            
        }
    }
}
