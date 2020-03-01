using System;

public class QuadraticEquation
{
  public static Tuple<double, double> FindRoots(double a, double b, double c)
  {
    var bpart = -b / (2 * a);
    var det = Math.Sqrt(b * b - 4 * a * c) / (2 * a);

    return new Tuple<double, double>(bpart + det, bpart - det);
  }

  public static void Main(string[] args)
  {
    Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
    Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
  }
}
