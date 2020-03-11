using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string str;
    char[] strToChar;
    int length;
    
    Console.Write("Digite uma palavra/frase: ");
    str = Console.ReadLine();
    strToChar = str.ToCharArray();
    length = strToChar.Length;
  
    InvertStr(strToChar, length);
    Console.ReadKey();
  }
  static void InvertStr(char[] array, int length)
  {
    char lastChar = array[--length];
    Console.Write(lastChar);
    if(length > 0)
    {
      InvertStr(array, length);
    }
  }
}