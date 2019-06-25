namespace DesignPatterns.visitor
{
    public interface IVisitable 
    {
        void Accept(IVisitor v);
    }
}