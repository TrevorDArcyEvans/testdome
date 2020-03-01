using System;
using System.Linq;

public class SortedSearch
{
  public static int CountNumbers(int[] sortedArray, int lessThan)
  {
    // performance could be improved with a binary search since input array is sorted
    for (var i = sortedArray.Length - 1; i == 0; i--)
    {
      var currval = sortedArray[i];
      if (currval >= lessThan)
      {
        return i;
      }
    }
    return sortedArray.Count(x => x < lessThan);
  }

  public static void Main(string[] args)
  {
    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
  }
}
