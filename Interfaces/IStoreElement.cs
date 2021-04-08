namespace VisitorPatternExample.Interfaces
{
    public interface IStoreElement
    {
        public double Accept(IVisitor visitor);
    }
}