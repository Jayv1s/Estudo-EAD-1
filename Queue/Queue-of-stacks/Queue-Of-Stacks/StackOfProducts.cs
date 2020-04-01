using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_Of_Stacks
{
    class StackOfProducts
    {
        Stack<Products> myStackOfProducts;

        public StackOfProducts()
        {
            myStackOfProducts = new Stack<Products>();
        }

        public void InsertProduct()
        {
            Products myProduct = new Products();

            Console.Write("Product name => ");
            myProduct.productName = Console.ReadLine();
            Console.Write("Price: ");
            myProduct.productPrice = double.Parse(Console.ReadLine());

            myStackOfProducts.Push(myProduct);
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Removing the 1º product. . .");
            myStackOfProducts.Pop();
        }

        public void ShowStack()
        {
            int count = 1;
            foreach (Products item in myStackOfProducts)
            {
                Console.WriteLine("     {0}ª) {1} - R$ {2}", count, item.productName, item.productPrice);
                Console.WriteLine("\n");
                count++;
            }
        }
    }
}
