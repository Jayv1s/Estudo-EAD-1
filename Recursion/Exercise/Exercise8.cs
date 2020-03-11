using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int x;

    Console.Write("Valor final: ");
    x = int.Parse(Console.ReadLine());

  
    Console.Write(SumAndSub(x));
    Console.ReadKey();
  }
  static int SumAndSub(int x)
  {
    int result = x;

    if(x > 1)
    {
      if(x%2 == 0)
      {
      result = SumAndSub(--x) + result;
      }
      else
      {
      result = SumAndSub(--x) - result;
      }
    }
    return result;
  }
}