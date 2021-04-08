using System;

namespace VisitorPatternExample.Interfaces
{
    public interface IShoppingCartVisitor
    {
        double Visit(Fruit fruit);
        double Visit(Milk milk);
        double Visit(Shirt shirt);
    }
}