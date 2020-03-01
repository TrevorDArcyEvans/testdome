using System;

public interface IBird
{
  public Egg lay();
}

public interface IBirdCreator
{
  public IBird createBird();
}

public class ChickenBirdCreator : IBirdCreator
{
  public IBird createBird()
  {
    return new Chicken(this);
  }
}

public class Egg
{
  private readonly Lazy<IBird> _hatchling;

  public Egg(IBirdCreator hatchable)
  {
    _hatchling = new Lazy<IBird>(() => hatchable.createBird());
  }

  public IBird hatch()
  {
    if (_hatchling.IsValueCreated)
    {
      throw new InvalidOperationException("Egg already hatched");
    }
    return _hatchling.Value;
  }
}

public class Chicken : IBird
{
  private readonly ChickenBirdCreator _birdCreator;

  public Chicken(ChickenBirdCreator birdCreator)
  {
    _birdCreator = birdCreator;
  }

  public Egg lay()
  {
    return new Egg(_birdCreator);
  }
}

public static class Program
{
  public static void Main(string[] args)
  {
    Chicken chicken = new Chicken(new ChickenBirdCreator());
    Console.WriteLine(chicken is IBird);

    var egg = chicken.lay();
    var bird1 = egg.hatch();
    var bird2 = egg.hatch();
  }
}
