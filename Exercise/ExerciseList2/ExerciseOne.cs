using System;
using System.Threading;

namespace Exercise1
{
    class Element
    {
        public int value;
        public Element next;
    }

    class Queue
    {
        private Element First;
        private Element Last;
        private Element Aux;
        public int count = 0;

        public Queue()
        {
            First = null;
            Last = null;
        }

        public void InsertIntoQueue(int number)
        {
            Element newValue = new Element();
            newValue.value = number;
            if (First == null)
            {
                First = newValue;
                Last = newValue;
                count++;
            }
            else
            {
                Last.next = newValue;
                Last = newValue;
                count++;
            }
        }

        public void ShowTheQueue()
        {
            Aux = First;

            while(Aux != null)
            {
                Console.WriteLine(Aux.value);
                Aux = Aux.next;
            }
        }

        public void RemoveFromQueue(int number)
        {
            Aux = First;

            while (First.value != number)
            {
                Aux = First;
                First = First.next;
                Last.next = Aux;
                Last = Aux;
                Last.next = null;
            }

            First = First.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue MyQueue = new Queue();
            bool condition = true;
            int number;
            int choice;
            do
            {
                Console.Clear();

                Console.WriteLine("--------------------------------------");
                Console.WriteLine(" 1 - Insert into queue");
                Console.WriteLine(" 2 - Show the queue");
                Console.WriteLine(" 3 - Remove from queue");
                Console.WriteLine(" 9 - Quit");
                Console.WriteLine("--------------------------------------");
                Console.Write("Option: ");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        if (MyQueue.count == 8)
                        {
                            Console.WriteLine("Sorry, the queue is full!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Insert a number value into the queue => ");
                            number = int.Parse(Console.ReadLine());
                            MyQueue.InsertIntoQueue(number);
                        }
                        break;
                    case 2:
                        Console.Clear();

                        MyQueue.ShowTheQueue();
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.Clear();

                        Console.Write("What number do you want to remove? ");
                        number = int.Parse(Console.ReadLine());
                        MyQueue.RemoveFromQueue(number);
                        Console.ReadKey();

                        break;
                    case 9:
                        Console.WriteLine("Closing...");
                        condition = false;
                        Thread.Sleep(2000);
                        break;
                    default:
                        break;
                }
            } while (condition);
        }
    }
}

