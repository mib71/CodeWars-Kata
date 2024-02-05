namespace SumOfPositive
{
    /// <summary>
    /// You get an array of numbers, return the sum of all of the positives ones.
    /// 
    /// Example [1,-4,7,12] => 1 + 7 + 12 = 20
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PositiveSum([]));
        }

        public static int PositiveSum(int[] arr)
        {
            return arr.Where(n => n > 0).Sum();
        }
    }
}
