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
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(binary.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
}
