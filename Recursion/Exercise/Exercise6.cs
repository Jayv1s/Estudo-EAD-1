using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int x;
    int y;

    Console.Write("Informe o valor que será elevado: ");
    x = int.Parse(Console.ReadLine());

    Console.Write("Informe o grau de elevação: ");
    y = int.Parse(Console.ReadLine());
  
    Console.Write(Potentiation(x,y));
    Console.ReadKey();
  }
  static int Potentiation(int x, int y)
  {
    int result = x;

    if(y > 1)
    {
      result = result * Potentiation(x, --y);
    }
    return result;
  }
}