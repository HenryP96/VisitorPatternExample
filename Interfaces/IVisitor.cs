using System;

namespace VisitorPatternExample.Interfaces
{
    public interface IVisitor
    {
        double Visit(Fruit fruit);
        double Visit(Milk milk);
        double Visit(Shirt shirt);
    }
}