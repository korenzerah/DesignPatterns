using DesignPatterns.facade.interfaces;

namespace DesignPatterns.facade.proxies
{
    public class AnonymousFacadeProxy : IAnonymous
    {
        public void showFlights()
        {
            FlightsFacade.getInstance().showFlights();
        }
    }
}