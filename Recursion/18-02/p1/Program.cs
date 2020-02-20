using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum values of X to Y;
            Console.Write("x= "); // get user input
            int x = int.Parse(Console.ReadLine()); // pass the user input to my var X;

            Console.Write("y= ");
            int y = int.Parse(Console.ReadLine());

            int Result = Mostra(x, y); // call the function "Mostra"
            Console.WriteLine("resultado = {0}", Result); // return the results
            Console.ReadKey();
        }
        static int Mostra(int x, int y)
        {
            // this is a recursion function, it'll call yourself till the if been false
            int result = x;
            if (x < y)
            {
                result = result + Mostra(++x, y); // heres the recursion
            }
            return result;
        }
    }
}
