using System;

namespace ShortestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("bitcoin take over the world maybe who knows perhaps"));
        }
        public static int FindShort(string s)
        {
            int rv = 50;
            string[] words = s.Split(' ');
            foreach (string word in words)
                if (word.Length < rv) rv = word.Length;
            
            return rv;
        }
    }
}
