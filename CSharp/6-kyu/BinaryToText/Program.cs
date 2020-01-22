using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryToString("0100100001100101011011000110110001101111"));
        }
        public static string BinaryToString(string binary)
        {
            string result = "";

            for (int i = 0; i < binary.Length / 8; i++)
            {
                string a = binary.Substring(i * 8, 8);
                int dec = Convert.ToInt32(a, 2);
                result = result + (char)dec;
            }

            return result;
        }
    }
}
