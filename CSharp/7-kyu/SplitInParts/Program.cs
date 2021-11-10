using System;

namespace SplitInParts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitInParts("supercalifragilisticexpialidocious", 3));
        }

        private static string SplitInParts(string s, int partLength)
        {
            for (int i = partLength; i < s.Length; i += partLength + 1)
                s = s.Insert(i, " ");

            return s;
        }
    }
}
