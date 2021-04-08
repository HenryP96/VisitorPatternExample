using System;
using VisitorPatternExample.Interfaces;

namespace VisitorPatternExample
{
    public class Milk : IStoreElement
    {
        public double Price { get; set; }
        public string Brand { get; }

        public Milk(double price, string brand)
        {
            Price = price;
            Brand = brand;
        }

        public double Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}