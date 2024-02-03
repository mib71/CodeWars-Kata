namespace CategorizeNewMember
{
    /// <summary>
    /// The Western Suburbs Croquet Club has two categories of membership, Senior and Open. They would like your help 
    /// with an application form that will tell prospective members which category they will be placed.
    /// 
    /// To be a senior, a member must be at least 55 years old and have a handicap greater than 7. In this croquet club, 
    /// handicaps range from -2 to +26; the better the player the lower the handicap.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var openOrSenior = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };

            Console.WriteLine(string.Join(", ", OpenOrSenior(openOrSenior)));
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {            
            return data.Select(member =>
            {
                if (member[0] >= 55 && member[1] > 7)
                    return "Senior";
                else
                    return "Open";
            }).ToList();
        }
    }
}
