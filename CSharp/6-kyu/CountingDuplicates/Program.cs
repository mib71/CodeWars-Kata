﻿namespace CountingDuplicates
{
    /// <summary>
    /// Write a function that will return the count of distinct case-insensitive alphabetic characters 
    /// and numeric digits that occur more than once in the input string. The input string can be assumed 
    /// to contain only alphabets (both uppercase and lowercase) and numeric digits.
    /// 
    /// "abcde" -> 0 # no characters repeats more than once
    /// "aabbcde" -> 2 # 'a' and 'b'
    /// "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
    /// "indivisibility" -> 1 # 'i' occurs six times
    /// "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
    /// "aA11" -> 2 # 'a' and '1'
    /// "ABBA" -> 2 # 'A' and 'B' each occur twice
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("aabBcde"));
        }

        public static int DuplicateCount(string str) =>
            str.Where(char.IsLetterOrDigit)
               .GroupBy(char.ToLower)
               .ToDictionary(group => group.Key, group => group.Count())
               .Count(pair => pair.Value > 1);
    }
}