namespace DesignPatterns.visitor
{
    public class Rectangle : Shape
    {
        public override void Accept(IVisitor v)
        {
            v.visitRectangle(this);
        }
    }
}