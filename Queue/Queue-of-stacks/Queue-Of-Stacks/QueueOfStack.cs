using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Queue_Of_Stacks
{
    class QueueOfStack
    {
        Queue<StackOfProducts> myQueueOfStack;

        public QueueOfStack()
        {
            myQueueOfStack = new Queue<StackOfProducts>();
        }

        public void CreateStack()
        {
            StackOfProducts myStackOfProducts = new StackOfProducts();
            int options = 0;

            Console.WriteLine("A new product's stack was created!");
            Console.ReadKey();

            do
            {
                Console.Clear();
                Console.WriteLine("-----STACK MENU-----");
                Console.WriteLine("1 - Insert a product ");
                Console.WriteLine("2 - Show my actual stack");
                Console.WriteLine("3 - Remove a product");
                Console.WriteLine("9 - Return to Queue Menu");
                Console.Write("\nOption => ");
                options = int.Parse(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("-----INSERTION SECTION-----");
                        myStackOfProducts.InsertProduct();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("-----STACK OF PRODUCTS SECTION-----");
                        myStackOfProducts.ShowStack();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();

                        Console.WriteLine("-----REMOVE SECTION-----");
                        myStackOfProducts.RemoveProduct();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();

                        Console.WriteLine("Returning to queue menu. . .");
                        Thread.Sleep(1500);
                        break;
                    default:
                        break;
                }

            } while (options != 9);

            myQueueOfStack.Enqueue(myStackOfProducts);
        }

        public void ShowQueue()
        {
            int count = 1;
            Console.WriteLine("-----QUEUE-----");

            foreach (StackOfProducts item in myQueueOfStack)
            {
                Console.WriteLine("{0}º stack: ", count);
                item.ShowStack();
                count++;
            }

        }

        public void DeleteStack()
        {
            Console.WriteLine("Removing the 1º stack. . .");
            myQueueOfStack.Dequeue();
        }
    }
}
