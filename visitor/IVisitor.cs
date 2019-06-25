namespace DesignPatterns.visitor
{
    public interface IVisitor
    {
        void visitCircle(Circle c);
        void visitRectangle(Rectangle r);
    }
}