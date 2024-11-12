/// <summary>
/// Find The Duplicated Number in a Consecutive Unsorted List - Tougher Version
/// https://www.codewars.com/kata/558f0553803bc3c4720000af/csharp
/// </summary>

internal class Program
{
    private static void Main(string[] args)
    {
        var result = FindDup([8, 2, 6, 3, 7, 2, 5, 1, 4]);
        Console.WriteLine(result);        
    }

    public static int FindDup(int[] arr)
    {
        return arr.GroupBy(n => n)
              .Where(g => g.Count() > 1)
              .Select(g => g.Key)
              .FirstOrDefault();
    }
}