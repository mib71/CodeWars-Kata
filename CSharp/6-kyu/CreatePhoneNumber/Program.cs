namespace CreatePhoneNumber
{
    /// <summary>
    /// Write a function that accepts an array of 10 integers (between 0 and 9), 
    /// that returns a string of those numbers in the form of a phone number.
    /// 
    /// Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
    /// </summary>    
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(CreatePhoneNumber(test));
        }

        public static string CreatePhoneNumber(int[] numbs)
        {
            return $"({numbs[0]}{numbs[1]}{numbs[2]}) {numbs[3]}{numbs[4]}{numbs[5]}-{numbs[6]}{numbs[7]}{numbs[8]}{numbs[9]}";
        }
    }
}
