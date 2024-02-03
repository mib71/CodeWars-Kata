namespace DetectPangram
{
    /// <summary>
    /// A pangram is a sentence that contains every single letter of the alphabet at least once. For example, 
    /// the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z 
    /// at least once (case is irrelevant).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(IsPangram(pangram));
        }

        public static bool IsPangram(string str)
        {
            str = str.ToLower();                        
            bool[] alphabet = new bool[26];
                        
            foreach (char c in str)
            {                
                if (char.IsLetter(c))
                {                    
                    alphabet[c - 'a'] = true;
                }
            }
                        
            return alphabet.All(letterPresent => letterPresent);
        }
    }
}
