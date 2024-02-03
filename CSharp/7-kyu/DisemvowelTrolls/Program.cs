namespace DisemvowelTrolls
{
    /// <summary>
    /// Trolls are attacking your comment section!
    ///
    /// A common way to deal with this situation is to remove all of the vowels from the trolls'
    /// comments, neutralizing the threat.
    /// 
    /// Your task is to write a function that takes a string and return a new string with all vowels removed.
    /// 
    /// For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Disemvowel("This website is for losers LOL!"));
        }

        public static string Disemvowel(string str)
        {
            return string.Concat(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());            
        }
    }
}
