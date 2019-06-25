using System;
using DesignPatterns.facade.interfaces;

namespace DesignPatterns.facade
{
    public class FlightsFacade : IAnonymous, ICustomer, ICompany
    {
        private static FlightsFacade _singleton = null;
        private static Object lockObj = new Object();

        private FlightsDAO flights {get; set;} = new FlightsDAO();
        private CompanyDAO companies {get; set;} = new CompanyDAO();
        private TicketsDAO tickets {get; set;} = new TicketsDAO();
        private CustomersDAO customers {get; set;} = new CustomersDAO();
        private FlightsFacade() {

        }

        public static FlightsFacade getInstance() {
            if (_singleton != null) {
                return _singleton;
            }

            lock(lockObj) {
                if (_singleton == null)
                    _singleton = new FlightsFacade();
            }

            return _singleton;
        }        

        public void showFlights()
        {
            this.flights.flights.ForEach(f => Console.WriteLine(f));
        }

        public void buyTicket(string flightId)
        {
            flights.flights.Remove(flightId);
            Console.WriteLine($"Bought ticket for :{flightId}");
        }

        public void createFlight(string flightId)
        {
            flights.flights.Add(flightId);                
            Console.WriteLine($"Created flight :{flightId}");
        }
    }
}