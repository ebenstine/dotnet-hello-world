****

using System.Linq;

public class Kata
{
  public static bool Check(object[] a, object x)
  {
    return a.Contains(x);
  }
}



****

using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        //Moment of truth...
      if (flower1%2 == 0 && flower2%2 != 0 || flower1%2 != 0 && flower2%2 == 0 )
      {
        return true;
      } else {
        return false;
      }
    }
}

*****


using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    // Your code here
    int sum = 0;
    foreach (int num in arr)
    {
      if ( num > 0)
      {
        sum += num;
      }
    }
    return sum;
  }
}