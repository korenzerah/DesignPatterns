namespace DesignPatterns.visitor
{
    public abstract class Shape : IVisitable
    {
        public abstract void Accept(IVisitor v);
    }
}