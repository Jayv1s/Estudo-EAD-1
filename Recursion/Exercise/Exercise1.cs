using System;

class MainClass {
  public static void Main (string[] args)
  {
    Console.WriteLine("Solution 1: ");
    SumNumOneToTen(1,0);
    Console.ReadKey();
    Console.Clear();


    Console.WriteLine("Solution 2: ");
    Console.WriteLine(SumNumOneToTen_2(1));
    Console.ReadKey();
    Console.Clear();
  }
  static void SumNumOneToTen (int lowNumber, int newNumber) 
  {
    int result = newNumber;
    if(lowNumber <= 10)
    {
      result = lowNumber + result;
      Console.WriteLine("{0} + {1} = {2}",lowNumber,newNumber,result);
      lowNumber ++;
      SumNumOneToTen(lowNumber, result);
    }
  }
  static int SumNumOneToTen_2 (int lowNumber) 
  {
    int result = lowNumber;
    if(lowNumber < 10)
    {
      lowNumber++;
      result = result + SumNumOneToTen_2(lowNumber);
    }
    return result;
  }
}