using System;

namespace CorrectTheMistakesOfTheCharacterRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Correct("51NGAP0RE"));
        }

        private static string Correct(string text)
        {
            return text.Replace("5", "S").Replace("0", "O").Replace("1", "I");
        }
    }
}
