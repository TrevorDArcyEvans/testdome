using System;
using System.Collections.Generic;

public class TrainComposition
{
  private readonly LinkedList<int> _trains = new LinkedList<int>();

  public void AttachWagonFromLeft(int wagonId)
  {
    _trains.AddFirst(wagonId);
  }

  public void AttachWagonFromRight(int wagonId)
  {
    _trains.AddLast(wagonId);
  }

  public int DetachWagonFromLeft()
  {
    var wagonId = _trains.First;
    _trains.RemoveFirst();
    return wagonId.Value;
  }

  public int DetachWagonFromRight()
  {
    var wagonId = _trains.Last;
    _trains.RemoveLast();
    return wagonId.Value;
  }

  public static void Main(string[] args)
    {
        TrainComposition tree = new TrainComposition();
  tree.AttachWagonFromLeft(7);
        tree.AttachWagonFromLeft(13);
        Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        Console.WriteLine(tree.DetachWagonFromLeft()); // 13
    }
}
