﻿using System;
using System.Linq;

namespace ArrayPlusArray
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
        }
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }
    }
}
