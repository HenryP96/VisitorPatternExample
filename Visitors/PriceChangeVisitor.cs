using System;
using System.Data;
using VisitorPatternExample.Interfaces;

namespace VisitorPatternExample
{
    public class PriceChangeVisitor : IVisitor
    {
        public double Visit(Fruit fruit)
        {
            // 20% discount if weight is above 1 kg
            var fruitPrice = fruit.CalculatePrice();
            var cost = (fruit.Weight > 1.0) ? (fruitPrice * 0.8) : fruitPrice;

            if (cost != fruitPrice)
            {
                Console.WriteLine($"{fruit.Name}, {fruit.Weight} kg: {cost} kr. (20% discount)");
            }
            else
            {
                Console.WriteLine($"{fruit.Name}, {fruit.Weight} kg: {cost} kr.");
            }
            return cost;
        }

        public double Visit(Milk milk)
        {
            double cost = milk.Price;

            // 10% discount if brand of milk is 'Arla'
            if (milk.Brand == "Arla")
            {
                cost *= 0.9;
                Console.WriteLine($"Milk: {cost} kr. (10% discount)");
            }
            else
            {
                Console.WriteLine($"Milk: {cost} kr.");
            }
            return cost;
        }

        public double Visit(Shirt shirt)
        {
            double cost = shirt.Price;
            string temp = "";

            // The brand 'Adidas' is 10% more expensive
            if (shirt.Brand == "Adidas")
            {
                cost *= 1.1;
                temp += " (10% added taxes)";
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
                temp += " (30 kr. discount)";
            }

            Console.WriteLine($"Shirt: {cost} kr." + temp);
            return cost;
        }
    }
}