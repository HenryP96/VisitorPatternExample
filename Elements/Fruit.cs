using VisitorPatternExample.Interfaces;

namespace VisitorPatternExample
{
    public class Fruit : IStoreElement
    {
        public double PricePerKg { get; set; }
        public double Weight { get; set; }
        public string Name { get; }


        public Fruit(double pricePerKg, double weight, string name)
        {
            PricePerKg = pricePerKg;
            Weight = weight;
            Name = name;
        }

        public double Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}