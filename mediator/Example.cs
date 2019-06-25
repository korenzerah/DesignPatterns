using System;

namespace DesignPatterns.mediator
{
    class MainOfMediator
    {
        static void Example(string[] args)
        {
            StockMediator bursa = new StockMediator();
            GoogleCompany c1 = new GoogleCompany(bursa);
            TadiranCompany c2 = new TadiranCompany(bursa);

            c1.sellOffer("GOOG", 50);
            c1.sellOffer("MS", 2);
            c1.sellOffer("MS", 2);
            bursa.presentAllOffers();
            c2.buyOffer("GOOG", 40);
            c2.buyOffer("GOOG", 50);            
            bursa.presentAllOffers();
        }
    }
}
