using System;
using System.Threading;

namespace Exercise3
{
    class Element
    {
        public Element next;
        public int value;
    }
    class StackRepetitions
    {
        private Element First;
        private Element Last;
        private Element Aux;

        public StackRepetitions()
        {
            First = null;
            Last = null;
        }

        public void InsertIntoStack(int number)
        {
            Element newValue = new Element();
            newValue.value = number;


            if (First == null)
            {
                First = newValue;
                Last = newValue;
            }
            else
            {
                bool existANumber = exist(number);
                if (!existANumber)
                {
                    newValue.next = Last;
                    Last = newValue;
                }
            }
        }

        public void ShowStack()
        {
            Aux = Last;
            while (Aux != null)
            {
                Console.WriteLine(Aux.value);
                Aux = Aux.next;
            }
        }

        public bool exist(int number)
        {
            Aux = Last;
            while (Aux != null)
            {
                if(Aux.value == number)
                {
                    return true;
                }
                else
                {
                    Aux = Aux.next;
                }
            }
            return false;
        }
    }

    class StackUnique
    {
        private Element First;
        private Element Last;
        private Element Aux;

        public StackUnique()
        {
            First = null;
            Last = null;
        }

        public void InsertIntoStack(int number)
        {
            Element newValue = new Element();
            newValue.value = number;

            if (First == null)
            {
                First = newValue;
                Last = newValue;
            }
            else
            {
                bool existANumber = exist(number);
                if (!existANumber)
                {
                    newValue.next = Last;
                    Last = newValue;
                }
            }
        }

        public void ShowStack()
        {
            Aux = Last;
            while (Aux != null)
            {
                Console.WriteLine(Aux.value);
                Aux = Aux.next;
            }
        }

        public bool exist(int number)
        {
            Aux = Last;
            while (Aux != null)
            {
                if (Aux.value == number)
                {
                    return true;
                }
                else
                {
                    Aux = Aux.next;
                }
            }
            return false;
        }
    }

    class List
    {
        private Element First;
        private Element Last;

        private Element Aux;
        private Element TestValue;


        public List()
        {
            First = null;
            Last = null;
        }

        public void InsertIntoBeginning(int number)
        {
            Element newValue = new Element();
            newValue.value = number;
            if(First == null)
            {
                First = newValue;
                Last = newValue;
            }
            else
            {
                newValue.next = First;
                First = newValue;
            }
        }

        public void InsertIntoFinal(int number)
        {
            Element newValue = new Element();
            newValue.value = number;
            if(First == null)
            {
                First = newValue;
                Last = newValue;
            }
            else
            {
                Last.next = newValue;
                Last = newValue;
            }
        }

        public void ShowList()
        {
            Aux = First;
            while(Aux != null)
            {
                Console.Write(" "+ Aux.value+ " ");
                Aux = Aux.next;
            }
        }

        public void FindDuplicateNumbers(StackRepetitions stackRepetitions, StackUnique stackUnique)
        {
            Aux = First;
            while (Aux != null)
            {
                stackUnique.InsertIntoStack(Aux.value);
                TestValue = Aux.next;     

                while (TestValue != null)
                {
                    if(Aux.value == TestValue.value)
                    {
                        stackRepetitions.InsertIntoStack(Aux.value);                    
                    }
                    TestValue = TestValue.next;
                }
                Aux = Aux.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List myList = new List();
            StackRepetitions MyStackOfRepetitions = new StackRepetitions();
            StackUnique MyStackOfUniques = new StackUnique();
            Random randomNumber = new Random();
            

            for(int i = 0; i < 10; i++)
            {
                myList.InsertIntoBeginning(randomNumber.Next(1, 20));
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("My list: ");
            myList.ShowList();
            Console.ReadKey();


            myList.FindDuplicateNumbers(MyStackOfRepetitions, MyStackOfUniques);

            Console.WriteLine("\n----------------------------");
            Console.WriteLine("My stack of repetitions: ");
            MyStackOfRepetitions.ShowStack();
            Console.ReadKey();

            Console.WriteLine("----------------------------");
            Console.WriteLine("My stack of unique values: ");
            MyStackOfUniques.ShowStack();
            Console.ReadKey();


        }
    }
}
