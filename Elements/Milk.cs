using System;
using VisitorPatternExample.Interfaces;

namespace VisitorPatternExample
{
    public class Milk : IStoreElement
    {
        public double Price { get; set; }
        public string Brand { get; }
        public DateTime ExpiryDate { get; }

        public Milk(double price, string brand, DateTime expiryDate)
        {
            Price = price;
            Brand = brand;
            ExpiryDate = expiryDate;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}