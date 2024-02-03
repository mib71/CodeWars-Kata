namespace CountDivisibleNumbers
{
    /// <summary>
    /// Complete the function that takes 3 numbers x, y and k (where x ≤ y), and returns the number 
    /// of integers within the range [x..y] (both ends included) that are divisible by k.
    ///More scientifically: { i : x ≤ i ≤ y, i mod k = 0 }
    ///
    /// Given x = 6, y = 11, k = 2 the function should return 3, because there are three numbers 
    /// divisible by 2 between 6 and 11: 6, 8, 10
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleCount(6, 11, 2));
        }

        public static long DivisibleCount(long x, long y, long k)
        {            
            if (x % k == 0)
                return (y / k) - (x / k) + 1;
                        
            return (y / k) - (x / k);            
        }
    }
}
