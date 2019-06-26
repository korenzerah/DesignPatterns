namespace DesignPatterns.observer
{
    public interface ISubject
    {
         void register (IObserver ob);
         void unregister (IObserver ob);

         void notify();
    }
}