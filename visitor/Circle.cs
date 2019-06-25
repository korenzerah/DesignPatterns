namespace DesignPatterns.visitor
{
    public class Circle : Shape
    {
        public override void Accept(IVisitor v)
        {
            v.visitCircle(this);
        }

    }
}