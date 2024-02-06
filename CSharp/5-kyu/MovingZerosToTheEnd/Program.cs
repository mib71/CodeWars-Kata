namespace MovingZerosToTheEnd
{
    /// <summary>
    /// Write an algorithm that takes an array and moves all of the zeros to the end, 
    /// preserving the order of the other elements.
    /// 
    /// Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => 
    ///     new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MoveZeroes([1, 2, 0, 1, 0, 1, 0, 3, 0, 1]));
        }

        public static int[] MoveZeroes(int[] arr) => arr.OrderBy(n => n == 0).ToArray();
    }
}
