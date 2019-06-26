namespace DesignPatterns.decorator
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza pizza;
        public ToppingDecorator(IPizza p)
        {
            this.pizza = p;   
        }

        public abstract string getDetails();
        public abstract double getPrice();
    }
}