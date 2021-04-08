using System;
using VisitorPatternExample.Interfaces;

namespace VisitorPatternExample
{
    public class PrintInfoVisitor : IShoppingCartVisitor
    {
        public double Visit(Fruit fruit)
        {
            Console.WriteLine($"The fruit's name is {fruit.Name}, weighs {fruit.Weight} kg" +
                              $" and the price is {fruit.PricePerKg} kr./kg");
            return 0.0;
        }

        public double Visit(Milk milk)
        {
            string formattedDate = milk.ExpiryDate.ToString("dd-MM-yyyy");
            Console.WriteLine($"The brand of the milk is {milk.Brand}, the expiry date is {formattedDate}" +
                              $"and the price is {milk.Price} kr.");
            return 0.0;
        }

        public double Visit(Shirt shirt)
        {
            Console.WriteLine($"The brand of the shirt is {shirt.Brand}, has the color {shirt.Color}" +
                              $"and the price is {shirt.Price} kr.");
            return 0.0;
        }
    }
}