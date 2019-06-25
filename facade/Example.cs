using System;
using DesignPatterns.facade.interfaces;
using DesignPatterns.facade.proxies;

namespace DesignPatterns.facade
{
    class MainOfFacade
    {
        static void Example(string[] args)
        {
            IUserProxy pr = LoginFactory.LoginToFacadeSystem("elal");
            (pr as CompanyFacadeProxy).createFlight("1");
            (pr as CompanyFacadeProxy).createFlight("2");
            (pr as CompanyFacadeProxy).createFlight("1");
            (pr as CompanyFacadeProxy).createFlight("1");

            IUserProxy pr2 = LoginFactory.LoginToFacadeSystem("koren");
            (pr2 as CustomerFacadeProxy).buyTicket("1");
            (pr2 as CustomerFacadeProxy).buyTicket("1");

            IUserProxy pr3 = LoginFactory.LoginToFacadeSystem("");
            (pr3 as AnonymousFacadeProxy).showFlights();
        }
    }
}
