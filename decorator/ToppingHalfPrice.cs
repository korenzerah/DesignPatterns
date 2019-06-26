namespace DesignPatterns.decorator
{
    public class ToppingHalfPrice : ToppingDecorator
    {
        public ToppingHalfPrice(IPizza p) : base(p)
        {
        }

        public override string getDetails()
        {
            return this.pizza.getDetails() + " 50% discount!";
        }

        public override double getPrice()
        {
            return this.pizza.getPrice() / 2;
        }
    }
}