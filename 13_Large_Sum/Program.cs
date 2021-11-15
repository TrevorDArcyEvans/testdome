using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace _13_Large_Sum
{
  class Program
  {
    static void Main(string[] args)
    {
      BigInteger sum = 0;
      File
        .ReadAllLines("13_Numbers.txt")
        .ToList()
        .ForEach(x => sum += BigInteger.Parse(x));
      var sumStr = sum.ToString();

      Console.WriteLine($"Sum = {sumStr.Substring(0, 10)}");
    }
  }
}
