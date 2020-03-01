using System;
using System.Collections.Generic;

public class MatryoshkaDoll
{
    private MatryoshkaDoll _containedDoll;

    public MatryoshkaDoll() 
    {
    }

    public MatryoshkaDoll(MatryoshkaDoll containedDoll)
    {
        _containedDoll = containedDoll;
    }

    public int GetNumberOfSmallerDolls()
    {
        var numDolls = 0;
        var thisContDoll = _containedDoll;
        while (thisContDoll != null)
        {
          numDolls++;
          thisContDoll = thisContDoll._containedDoll;
        }
        return numDolls;
    }

    public static void Main()
    {
      var rootDoll = new MatryoshkaDoll();
      var outerDoll1 = new MatryoshkaDoll(rootDoll);
      var outerDoll2 = new MatryoshkaDoll(outerDoll1);
      var outerDoll3 = new MatryoshkaDoll(outerDoll2);
      Console.WriteLine("Smaller dolls = " + outerDoll3.GetNumberOfSmallerDolls());
    }
}
