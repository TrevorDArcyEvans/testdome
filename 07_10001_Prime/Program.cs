using System;
using System.IO;
using System.Linq;

namespace _07_10001_Prime
{
  class Program
  {
    static void Main(string[] args)
    {
      const string Divider = "=>";

      var line = File.ReadAllLines("log_100000.txt").Skip(10001).Take(1).Single();
      var divIdx = line.IndexOf(Divider);
      var indexStr = line.Substring(0, divIdx);
      var index = int.Parse(indexStr) + 1;  // index is zero based
      var primeStr = line.Substring(divIdx + Divider.Length, line.Length - divIdx - Divider.Length - 1);
      var prime = int.Parse(primeStr);

      Console.WriteLine($"Prime[{index}] = {prime}");
    }
  }
}
