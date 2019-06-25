using System.Linq;
using System;
using System.Collections.Generic;

namespace DesignPatterns.mediator
{
    public class StockMediator : Mediator
    {
        private List<Colleague> cols = new List<Colleague>();
        private List<StockOffer> stockBuys = new List<StockOffer>();
        private List<StockOffer> stockSell = new List<StockOffer>();
        public void addColleague(Colleague col)
        {
            this.cols.Add(col);
            ++col.colleagueCode;
        }

        public void buyOffer(string stock, int shares, int collCode)
        {
            StockOffer toRemove = null;
            foreach (StockOffer offer in this.stockSell) {
                if (offer.stockName == stock && offer.stockShares == shares) {
                    toRemove = offer;
                    Console.WriteLine($"Stock: {stock} bought {shares}!");
                    this.cols.First(x => x.colleagueCode == offer.colleagueCode).NotifyOnTransaction(stock, shares, collCode);
                }
            }

            if (toRemove != null) {
                this.stockSell.Remove(toRemove);
            } else {
                this.stockBuys.Add(new StockOffer(shares, stock, collCode));
                Console.WriteLine($"New stock offer added - Name: {stock}, shares: {shares}, colleague: {collCode}");
            }
        }

        public void sellOffer(string stock, int shares, int collCode)
        {
            StockOffer toRemove = null;
            foreach (StockOffer offer in this.stockBuys) {
                if (offer.stockName == stock && offer.stockShares == shares) {
                    toRemove = offer;
                    Console.WriteLine($"Stock: {stock} sold {shares}!");
                    this.cols.First(x => x.colleagueCode == offer.colleagueCode).NotifyOnTransaction(stock, shares, collCode);
                }
            }

            if (toRemove != null) {
                this.stockBuys.Remove(toRemove);
            } else {
                this.stockSell.Add(new StockOffer(shares, stock, collCode));
                Console.WriteLine($"New stock offer added - Name: {stock}, shares: {shares}, colleague: {collCode}");
            }
        }        

        public void presentAllOffers() {
            Console.WriteLine("Stock Offers:");

            Console.WriteLine("BUY OFFERS:");
            foreach(StockOffer o in this.stockBuys) {
                Console.WriteLine(o.ToString());
            }

            Console.WriteLine("SELL OFFERS:");
            foreach(StockOffer o in this.stockSell) {
                Console.WriteLine(o.ToString());
            }
        }
    }
}