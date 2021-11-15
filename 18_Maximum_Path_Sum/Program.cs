using System;
using System.IO;
using System.Linq;

namespace _18_Maximum_Path_Sum
{
  class Program
  {
    static void Main(string[] args)
    {
      // read numbers into a square matrix
      var lines = File.ReadAllLines("p067_triangle.txt");
      var numLines = lines.Count();
      var numbers = new int[numLines, numLines];
      for (var i = 0; i < numLines; i++)
      {
        var line = lines[i];
        var numsInLine = line.Split(' ');
        for (var j = 0; j < numsInLine.Count(); j++)
        {
          numbers[i, j] = int.Parse(numsInLine[j]);
        }
      }

      // evaluate every possible route
      //var maxSum = MaxSumByBruteForce(numbers);
      //Console.WriteLine($"Max sum = {maxSum}");

      var maxerSum = MaxSumByBackIteration(numbers);
      Console.WriteLine($"Max sum = {maxerSum}");
    }

    private static int MaxSumByBruteForce(int[,] numbers)
    {
      var numLines = numbers.GetLength(0);
      var maxSum = 0;
      var numSol = Math.Pow(2, numLines - 1);
      for (var i = 0; i <= numSol; i++)
      {
        var tempSum = numbers[0, 0];
        var index = 0;
        for (var j = 0; j < numLines - 1; j++)
        {
          index += i >> j & 1;
          tempSum += numbers[j + 1, index];
        }

        maxSum = tempSum > maxSum ? tempSum : maxSum;
      }

      return maxSum;
    }

    private static int MaxSumByBackIteration(int[,] numbers)
    {
      var numLines = numbers.GetLength(0);
      var maxSums = new int[numLines];

      // initialise max sums to last row
      for (var i = 0; i < numLines; i++)
      {
        maxSums[i] = numbers[numLines - 1, i];
      }

      // go back up rows, getting max sum for each triangle below
      for (var i = numLines - 2; i >= 0; i--)
      {
        for (var j = 0; j <= numLines - 2; j++)
        {
          maxSums[j] = numbers[i, j] + Math.Max(maxSums[j], maxSums[j + 1]);
        }
      }

      // max sum for first row
      return maxSums[0];
    }
  }
}
