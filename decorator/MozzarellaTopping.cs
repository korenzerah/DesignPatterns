namespace DesignPatterns.decorator
{
    public class MozzarellaTopping : ToppingDecorator
    {
        public MozzarellaTopping(IPizza p) : base(p)
        {
        }

        public override string getDetails()
        {
            return this.pizza.getDetails() + " Mozzarella";
        }

        public override double getPrice()
        {
            return this.pizza.getPrice() + 5;
        }
    }
}