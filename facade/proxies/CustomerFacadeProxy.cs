using DesignPatterns.facade.interfaces;

namespace DesignPatterns.facade.proxies
{
    public class CustomerFacadeProxy : ICustomer
    {        
        public void buyTicket(string flightId)
        {
            FlightsFacade.getInstance().buyTicket(flightId);
        }
    }
}