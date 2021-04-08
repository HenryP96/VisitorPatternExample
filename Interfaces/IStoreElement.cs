namespace VisitorPatternExample.Interfaces
{
    public interface IStoreElement
    {
        public double Accept(IShoppingCartVisitor visitor);
    }
}