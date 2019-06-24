namespace DesignPatterns.prototype
{
    public class Point : Prototype<Point>
    {
        public double x;
        public double y;

        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public override Point Clone()
        {
            return new Point(this.x, this.y);
        }
    }
}