using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double x;

    Console.Write("Valor final: ");
    x = double.Parse(Console.ReadLine());

  
    Console.Write(SumDivision(x));
    Console.ReadKey();
  }
  static double SumDivision(double x)
  {
    double result = 1 / x;

    if(x > 1)
    {
      x--;
      result = result + (SumDivision(x));
    }
    return result;
  }
}