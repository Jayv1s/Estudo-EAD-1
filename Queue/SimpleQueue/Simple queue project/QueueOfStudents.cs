using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Simple_queue_project
{
    class QueueOfStudents
    {
        public Queue<Student> MyStudentQueue;
        public QueueOfStudents()
        {
            MyStudentQueue = new Queue<Student>();
        }

        public void InsertIntoQueue()
        {
            Student MyStudent = new Student();
            Random generateId = new Random();

            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.Write("Student name => ");
            MyStudent.Name = Console.ReadLine();

            MyStudent.studentID = generateId.Next(1000, 9000);
            Console.Write("\nThe student ID is: {0}", MyStudent.studentID);


            MyStudentQueue.Enqueue(MyStudent);
        }

        public void ShowQueue()
        {
            int count = 1;
            Console.Clear();
            Console.WriteLine("------------------------------");

            foreach (Student item in MyStudentQueue)
            {
                Console.WriteLine("{0}º Student: {1}", count, item.Name);
                Console.WriteLine("-----------> {0}",item.studentID);
                Console.WriteLine("\n");
                count++;
            }

            Console.WriteLine("------------------------------");
        }

        public void RemoveFromQueue()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Removing 1º student....");
            Thread.Sleep(1500);
            MyStudentQueue.Dequeue();
        }
    }
}
