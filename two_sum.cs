using System;
using System.Collections.Generic;
using System.Linq;

class TwoSum
{
  public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
  {
    for (var i = 0; i < list.Count; i++)
    {
      for (var j = i + 1; j < list.Count; j++)
      {
        var trialsum = list[i] + list[j];
        if (trialsum == sum)
        {
          return new Tuple<int, int>(i, j);
        }
      }
    }

    return null;
  }

  public static void Main(string[] args)
  {
    Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
    if (indices != null)
    {
      Console.WriteLine(indices.Item1 + " " + indices.Item2);
    }
  }
}
