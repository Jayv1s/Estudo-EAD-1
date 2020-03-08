using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int[] array = new int [20];
    Random x = new Random();
    for(int i = 0; i < 20; i++)
    {
      array[i] = x.Next(1,10);
      Console.Write("  "+array[i]);
    }
    int length = array.Length;

    
    Console.Write("\nResultado:"+SumArray(array, length));
    Console.ReadKey();
  }
  static int SumArray(int[] array, int length)
  {
    int result = array[--length];
    if(length > 0 )
    {
      result = result + SumArray(array, length);
    }
    return result;
  }
}