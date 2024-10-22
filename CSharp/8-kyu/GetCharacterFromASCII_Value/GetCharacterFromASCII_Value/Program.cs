namespace GetCharacterFromASCII_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetChar(55));
        }

        public static char GetChar(int n) => Convert.ToChar(n);
    }
}
