using System;
using System.Linq;

namespace RowWeights
{
    class Program
    {
        static void Main(string[] args)
        {
            var row = RowWeights(new int[] { 100, 51, 50, 100 });
            
            foreach (int team in row)
            {
                Console.WriteLine(team);
            }
        }

        private static int[] RowWeights(int[] a)
        {            
            var team1 = a.Where((x, p) => p % 2 == 0).Sum();
            var team2 = a.Where((x, p) => p % 2 == 1).Sum();
            
            return new int[] {team1, team2};
        }
    }
}
