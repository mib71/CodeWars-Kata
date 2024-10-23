namespace MakeTheDeadfishSwim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Parse("iiisdoso");
        }

        public static int[] Parse(string data)
        {
            List<int> output = new();
            int i = 0;

            foreach (char c in data)
            {
                switch (c)
                {
                    case 'i':
                        i++;
                        break;
                    case 'd':
                        i--;
                        break;
                    case 's':
                        i *= i;
                        break;
                    case 'o':
                        output.Add(i);
                        break;
                    default:
                        break;
                }
            }

            return output.ToArray();
        }
    }
}
