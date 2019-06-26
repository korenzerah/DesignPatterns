namespace DesignPatterns.observer
{
    public interface IObserver
    {
         void update(double ibmPrice, double applePrice, double googlePrice);
    }
}