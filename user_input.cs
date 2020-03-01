using System;
using System.Text;

public class TextInput
{
  protected StringBuilder sb = new StringBuilder();

  public virtual void Add(char c)
  {
    sb.Append(c.ToString());
  }

  public string GetValue()
  {
    return sb.ToString();
  }
}

public class NumericInput : TextInput
{
  public override void Add(char c)
  {
    if (char.IsDigit(c))
    {
      sb.Append(c.ToString());
    }
  }
}

public class UserInput
{
  public static void Main(string[] args)
  {
    TextInput input = new NumericInput();
    input.Add('1');
    input.Add('a');
    input.Add('0');
    Console.WriteLine(input.GetValue());
  }
}
