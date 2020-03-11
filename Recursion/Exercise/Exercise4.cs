using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int[] array = new int [5];
    Random x = new Random();
    for(int i = 0; i < 5; i++)
    {
      array[i] = x.Next(1,50);
      Console.Write("  "+array[i]);
    }
    int length = array.Length;
    Console.Write("\nResultado:"+BiggestNumber(array, length));
    Console.ReadKey();
  }
  static int BiggestNumber(int[] array, int length)
  {
    int result = array[--length];
    int oldResult = result;

    if(length > 0 )
    {
      result = BiggestNumber(array, length);
    }
    if(oldResult > result)
    {
      return oldResult;
    } 
    else
    {
      return result;
    }
  }
}