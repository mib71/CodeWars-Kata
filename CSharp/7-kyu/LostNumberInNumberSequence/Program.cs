namespace LostNumberInNumberSequence
{
    /// <summary>
    /// An ordered sequence of numbers from 1 to N is given. One number might have deleted from it, 
    /// then the remaining numbers were mixed. Find the number that was deleted.
    /// 
    /// The starting array sequence is [1,2,3,4,5,6,7,8,9]
    /// The mixed array with one deleted number is [3,2,4,6,7,8,1,9]
    /// Your function should return the int 5.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var startingList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var mixedList = new List<int>() {6, 5, 7, 1, 9, 4, 8, 2, 3 };
            Console.WriteLine(FindDeletedNumber(startingList, mixedList));
        }

        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {
            int differences; 
            try
            {
                differences = startingList.Except(mixedList).First();
                return differences;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
