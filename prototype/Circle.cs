namespace DesignPatterns.prototype
{
    public class Circle : Prototype<Circle>
    {
        private Point center;
        public double area;

        public Circle(Point center, double area) {
            this.center = center;
            this.area = area;
        }

        public override Circle Clone()
        {
            return new Circle(this.center.Clone(), this.area);
        }
    }
}