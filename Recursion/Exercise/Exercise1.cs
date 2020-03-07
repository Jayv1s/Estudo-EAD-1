using System;

class MainClass {
  public static void Main (string[] args)
  {
    SumNumOneToTen(1,0);
    Console.ReadKey();
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
}