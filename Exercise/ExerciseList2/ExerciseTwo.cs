using System;

namespace Exercise2
{
    class Element
    {
        public Element next;
        public int value;
    }

    class StackB
    {
        private Element First;
        public Element Last;
        private Element Aux;

        public StackB()
        {
            First = null;
            Last = null;
        }

        public void InsertIntoSecondStack(int number)
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
                newValue.next = Last;
                Last = newValue;
            }
        }


        public void ShowSecondStack()
        {
            Aux = Last;

            while(Aux != null)
            {
                Console.WriteLine(Aux.value);
                Aux = Aux.next;
            }
        }

        public string ConcatSecondStack(Element myElements)
        {
            Aux = myElements;
            string concatResultStackB = "";
            string value;

            if (Aux != null)
            {
                value = Aux.value.ToString();
                concatResultStackB = value + ConcatSecondStack(Aux.next);
            }
            return concatResultStackB;
        }
    }

    class StackA
    {
        private Element First;
        public Element Last;
        private Element Aux;

        public StackA()
        {
            First = null;
            Last = null;
        }

        public void InsertIntoFirstStack(int number)
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
                newValue.next = Last;
                Last = newValue;
            }
        }

        public void ShowFirstStack()
        {
            Aux = Last;

            while (Aux != null)
            {
                Console.WriteLine(Aux.value);
                Aux = Aux.next;
            }
        }

        public string ConcatFirstStack(Element myElements)
        {
            Aux = myElements;
            string concatResultStackA = "";
            string value;

            if (Aux != null)
            {
                value = Aux.value.ToString();
                concatResultStackA = value + ConcatFirstStack(Aux.next);
            }
            return concatResultStackA;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Random x = new Random();
            StackA FirstStack = new StackA();
            StackB SecondStack = new StackB();
            string concatValuesA;
            string concatValuesB;
            int value;

            for(int i = 0; i < 5; i++)
            {
                value = x.Next(1, 10);
                FirstStack.InsertIntoFirstStack(i);
            }

            for (int i = 0; i < 5; i++)
            {
                value = x.Next(1, 10);
                SecondStack.InsertIntoSecondStack(value);
            }

            Console.WriteLine("First Stack: ");
            FirstStack.ShowFirstStack();
            Console.ReadKey();

            Console.WriteLine("---------------------------");

            Console.WriteLine("\nSecond Stack: ");
            SecondStack.ShowSecondStack();
            Console.ReadKey();

            Console.WriteLine("---------------------------");
            Console.WriteLine("First stack concatened: ");
            concatValuesA = FirstStack.ConcatFirstStack(FirstStack.Last);
            Console.WriteLine(concatValuesA);
            Console.ReadKey();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Second stack concatened: ");
            concatValuesB = SecondStack.ConcatSecondStack(SecondStack.Last);
            Console.WriteLine(concatValuesB);
            Console.ReadKey();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Comum values: ");
            Repetitions(concatValuesA, concatValuesB);
            Console.ReadKey();

        }

        static void Repetitions(string StackA, string StackB)
        {
            char[] values = StackB.ToCharArray();

            for(int i = 0; i < values.Length; i++)
            {
                if(StackA.Contains(values[i]))
                {
                    Console.WriteLine(values[i]);
                }
            }
        }
    }
}
