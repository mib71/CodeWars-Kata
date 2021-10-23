using System;

namespace CreditCardMask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("64607935616"));
        }

        public static string Maskify(string cc)
        {
            for (int i = 0; i <= cc.Length - 5; i++)
            {
                cc = cc.Remove(i, 1).Insert(i, "#");
            }

            return cc;
        }
    }
}
