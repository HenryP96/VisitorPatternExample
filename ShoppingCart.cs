using System;
using System.Collections.Generic;
using VisitorPatternExample.Interfaces;


namespace VisitorPatternExample
{
    public class ShoppingCart
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adding items to the shopping cart...");

            var cart = new List<IStoreElement>
            {
                new Fruit(50, 1.2, "Apple"),
                new Fruit(40, 0.4, "Banana"),
                new Milk(10, "Arla"),
                new Shirt(150, "Black", "Nike")
            };

            /* Calculating total cost of items in shopping cart using the
               newly added extensions from the 'Visitor' */
            double totalCost = 0;
            IShoppingCartVisitor visitor = new ShoppingCartVisitor();

            foreach (IStoreElement element in cart)
            {
                totalCost += element.Accept(visitor);
            }
            Console.WriteLine($"Total cost: {totalCost} kr.");

        }

    }
}