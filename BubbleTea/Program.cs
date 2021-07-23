namespace BubbleTea
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var datas = new[] { 0, 1, 2, 3, 4 };
      BubbleSort(datas);
    }
    
    private static void BubbleSort(int[] datas)
    {
      var hasSwapped = false;
      do
      {
        hasSwapped = false;
        for(var i = 0; i < datas.Length - 1; i++)
        {
          if (datas[i] < datas[i + 1])
          {
            var tmp2 = datas[i];
            var tmp = datas[i + 1];
            datas[i] = tmp;
            datas[i + 1] = tmp2;
        
            hasSwapped = true;
          }
        }
      }
      while(hasSwapped);
    }
  }
}
