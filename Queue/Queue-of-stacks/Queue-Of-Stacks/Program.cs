using System;
using System.Threading;

namespace Queue_Of_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueOfStack myQueue = new QueueOfStack();
            int option = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("-----QUEUE MENU-----");
                Console.WriteLine("1 - Create a product's stack ");
                Console.WriteLine("2 - Show All the product's stack");
                Console.WriteLine("3 - Delete a product's stack");
                Console.WriteLine("9 - Quit");
                Console.Write("\nOption => ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();

                        myQueue.CreateStack();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();

                        myQueue.ShowQueue();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();

                        myQueue.DeleteStack();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();

                        Console.WriteLine("Closing. . .");
                        Thread.Sleep(1500);
                        break;
                    default:
                        break;
                }

            } while (option != 9);

        }
    }
}
