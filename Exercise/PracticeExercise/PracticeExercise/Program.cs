using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise
{
    /*
        Create a generic list that:
        -Increment a STACK with pair numbers of the list; (DONE)
        -Increment a QUEUE with odd numbers of the list; (DOING)
    */
    class Element
    {
        public int value;
        public Element next;

    }

    class Stack
    {
        private Element Top;
        private Element Aux;
        public Stack()
        {
            Top = null;
        }
        public void InsertStack(int num)
        {
            Element newValue = new Element();
            newValue.value = num;

            if(Top == null)
            {
                Top = newValue;
            }
            else
            {
                newValue.next = Top;
                Top = newValue;
            }
        }
        public void ShowStack()
        {
            Aux = Top;
            while (Aux.next != null)
            {
                Console.WriteLine(" {0}", Aux.value);
                Aux = Aux.next;
            }
            Console.ReadKey();
        }
    }

    class List
    {
        private Element Start;
        private Element Final;
        private Element Aux;
        public List()
        {
            Start = null;
            Final = null;
        }

        public void InsertList(int num)
        {
            Element newValue = new Element();
            newValue.value = num;


            if(Start == null)
            {
                Start = newValue;
                Final = newValue;
            }
            else
            {
                newValue.next = Start;
                Start = newValue;
            }
        }

        public void ShowList()
        {
            Stack newStack = new Stack();
            Aux = Start;
            while(Aux.next != null)
            {
                if(Aux.value % 2 == 0)
                {
                    newStack.InsertStack(Aux.value);
                }
                Console.WriteLine(" {0}", Aux.value);
                Aux = Aux.next;
            }
            Console.ReadKey();
            Console.WriteLine("STACK: ");
            newStack.ShowStack();
        }
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            List genericList = new List();
            Random rdmNumber = new Random();
            int num = 0;
            for(int i = 0; i < 20; i++)
            {
                num = rdmNumber.Next(0, 15);
                genericList.InsertList(num);
            }
            Console.WriteLine("LIST:");
            genericList.ShowList();
        }
    }
}
