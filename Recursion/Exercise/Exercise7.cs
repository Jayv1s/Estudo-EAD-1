using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int x;

    Console.Write("Valor fatorial: ");
    x = int.Parse(Console.ReadLine());

  
    Console.Write(Factorial(x));
    Console.ReadKey();
  }
  static int Factorial(int x)
  {
    int result = x;

    if(x > 1)
    {
      result = result * Factorial(--x);
    }
    return result;
  }
}