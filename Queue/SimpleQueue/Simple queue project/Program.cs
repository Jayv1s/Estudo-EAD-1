using System;
using System.Threading;

namespace Simple_queue_project
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueOfStudents myQueueOfStudents = new QueueOfStudents();
            int option;

            do
            {
                Console.Clear();
                Console.WriteLine("--------------menu-------------");
                Console.WriteLine("1 - Add student");
                Console.WriteLine("2 - Show all my students");
                Console.WriteLine("3 - Remove student");
                Console.WriteLine("9 - Quit");
                Console.WriteLine("-------------------------------");

                Console.Write("Option => ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        myQueueOfStudents.InsertIntoQueue();
                        Console.ReadKey();
                        break;
                    case 2:
                        myQueueOfStudents.ShowQueue();
                        Console.ReadKey();
                        break;
                    case 3:
                        myQueueOfStudents.RemoveFromQueue();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Closing...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        break;
                }
            } while (option != 9);
        }
    }
}
