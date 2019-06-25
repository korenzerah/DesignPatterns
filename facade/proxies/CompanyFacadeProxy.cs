using DesignPatterns.facade.interfaces;

namespace DesignPatterns.facade.proxies
{
    public class CompanyFacadeProxy : ICompany
    {
        public void createFlight(string flightId)
        {
            FlightsFacade.getInstance().createFlight(flightId);
        }
    }
}