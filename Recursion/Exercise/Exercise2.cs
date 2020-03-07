using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Write(SumXY(1,5));
    Console.ReadKey();
  }
  static int SumXY(int x, int y)
  {
    int result = x;
    if(x < y)
    {
      x++;
      result =  result + SumXY(x,y);
    }
    return result;
  }
}