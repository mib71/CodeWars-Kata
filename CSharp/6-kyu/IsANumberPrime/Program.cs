using System;

namespace IsANumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(9));
        }

        public static bool IsPrime(int n)
        {
            if (n == 2) return true;

            if (n >= 3)
            {
                if (n % 2 == 0 || n == 9) return false;
                var limit = (int)Math.Floor(Math.Sqrt(n));

                for (int i = 2; i < limit; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

            //First attempt
            //if (n == 2)
            //{
            //    return true;
            //}
            //if (n >= 3)
            //{
            //    if (n % 2 == 0)
            //    {
            //        return false;
            //    }
            //    var limit = (int)Math.Floor(Math.Sqrt(n));
                
            //    for (int i = 2; i < n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}

            //return false;        
    }
}
