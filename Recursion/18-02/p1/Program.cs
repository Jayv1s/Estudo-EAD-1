using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum values of X to Y;
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y= ");
            int y = int.Parse(Console.ReadLine());

            int Result = Mostra(x, y);
            Console.WriteLine("resultado = {0}", Result);
            Console.ReadKey();
        }
        static int Mostra(int x, int y)
        {
            int result = x;
            if (x < y)
            {
                result = result + Mostra(++x, y);
            }
            return result;
        }
    }
}
