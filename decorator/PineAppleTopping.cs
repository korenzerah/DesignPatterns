namespace DesignPatterns.decorator
{
    public class PineAppleTopping : ToppingDecorator
    {
        public PineAppleTopping(IPizza p) : base(p)
        {
        }

        public override string getDetails()
        {
            return this.pizza.getDetails() + " PineApple";
        }

        public override double getPrice()
        {
            return this.pizza.getPrice() + 3;
        }
    }
}