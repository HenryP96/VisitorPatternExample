using System;
using System.Collections.Generic;
using VisitorPatternExample.Interfaces;


namespace VisitorPatternExample
{
    public class ShoppingCart
    {
        public static void Main()
        {
            double totalCost = 0;
            Console.WriteLine("Adding items to the shopping cart...");

            var cart = new List<IStoreElement>
            {
                new Fruit(50, 1.2, "Apple"),
                new Fruit(40, 0.4, "Banana"),
                new Milk(10, "Arla", new DateTime(2021, 08, 25)),
                new Shirt(150, "Black", "Nike")
            };

            /* Calculating total cost of items in shopping cart using the
               newly added extensions from the 'Visitor' */
            Console.WriteLine("Calculating total costs of items in shopping cart...");

            IVisitor priceVisitor = new PriceChangeVisitor();

            foreach (IStoreElement element in cart)
            {
                totalCost += element.Accept(priceVisitor);
            }

            Console.WriteLine($"Total cost: {totalCost} kr.");
            Console.WriteLine("");








            /* Printing info of items in shopping cart using the
               newly added extensions from the 'Visitor' */
            Console.WriteLine("Printing info of items in shopping cart...");

            IVisitor printVisitor = new PrintInfoVisitor();
            foreach (IStoreElement element in cart)
            {
                totalCost += element.Accept(printVisitor);
            }
        }

    }
}