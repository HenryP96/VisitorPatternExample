using System.Dynamic;
using VisitorPatternExample.Interfaces;

namespace VisitorPatternExample
{
    public class Shirt : IStoreElement
    {
        public double Price { get; set; }
        public string Color { get; }
        public string Brand { get; }

        public Shirt(double price, string color, string brand)
        {
            Price = price;
            Color = color;
            Brand = brand;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}