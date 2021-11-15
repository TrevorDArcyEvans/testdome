using System;

namespace _19_Counting_Sundays
{
  class Program
  {
    static void Main(string[] args)
    {
      var numSun = 0;

      for (var year = 1901; year <= 2000; year++)
      {
        for (var month = 1; month <= 12; month++)
        {
          if (new DateTime(year, month, 1).DayOfWeek == DayOfWeek.Sunday)
          {
            numSun++;
          }
        }
      }

      Console.WriteLine($"Number of Sundays on the first of the month in 20th century:  {numSun}");
    }
  }
}
