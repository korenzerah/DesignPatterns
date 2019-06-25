using System;
namespace DesignPatterns.mediator
{
    public class Colleague
    {
        protected Mediator mediator;
        public int colleagueCode {get; set;} = 0;

        public Colleague(Mediator med)
        {
            this.mediator = med;
            this.mediator.addColleague(this);
        }

        public void sellOffer(string name, int shares) {
            mediator.sellOffer(name, shares, this.colleagueCode);
        }
        public void buyOffer(string name, int shares) {
            mediator.buyOffer(name, shares, this.colleagueCode);
        }
                
        public void NotifyOnTransaction(string stock, int shares, int collCode) {
            Console.WriteLine($"{stock} - {shares} - transactioned with: {collCode}");
        }
    }
}