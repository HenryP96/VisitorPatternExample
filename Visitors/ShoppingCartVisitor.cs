using System;
using System.Data;
using VisitorPatternExample.Interfaces;

namespace VisitorPatternExample
{
    public class ShoppingCartVisitor : IShoppingCartVisitor
    {
        public double Visit(Fruit fruit)
        {
            // Calculating cost of fruit(s)
            var cost = fruit.PricePerKg * fruit.Weight;

            Console.WriteLine($"{fruit.Name}, {fruit.Weight} kg: {cost} kr.");
            return cost;
        }

        public double Visit(Milk milk)
        {
            double cost = milk.Price;

            // 10% discount if brand of milk is 'Arla'
            if (milk.Brand == "Arla")
            {
                cost *= 0.9;
            }

            Console.WriteLine($"Milk, {milk.Brand}: {cost} kr.");
            return cost;
        }

        public double Visit(Shirt shirt)
        {
            double cost = shirt.Price;

            // The brand 'Adidas' is 10% more expensive
            if (shirt.Brand == "Adidas")
            {
                cost *= 1.1;
            }

            // Save 30 kr. if the shirt is black
            if (shirt.Color == "Black")
            {
                if (shirt.Price >= 30)
                {
                    cost -= 30;
                }
                else
                {
                    cost = 0;
                }
            }

            Console.WriteLine($"Shirt, {shirt.Brand}: {cost} kr.");
            return cost;
        }
    }
}