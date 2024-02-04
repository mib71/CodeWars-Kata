namespace DescendingOrder
{
    /// <summary>
    /// Your task is to make a function that can take any non-negative integer as an argument 
    /// and return it with its digits in descending order. Essentially, rearrange the digits 
    /// to create the highest possible number.
    /// 
    /// Input: 42145 Output: 54421
    /// Input: 145263 Output: 654321
    /// Input: 123456789 Output: 987654321
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(124569789));
        }

        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(c => c)));
        }
    }
}
