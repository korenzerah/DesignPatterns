using System.Collections.Generic;

namespace DesignPatterns.observer
{
    public class StockGrabber : ISubject
    {
        private List<IObserver> obs = new List<IObserver>();
        private double ibmPrice;
        private double applePrice;
        private double googlePrice;
        public void notify()
        {
            this.obs.ForEach(x => x.update(ibmPrice, applePrice, googlePrice));
        }

        public void register(IObserver ob)
        {
            this.obs.Add(ob);
        }

        public void unregister(IObserver ob)
        {
            this.obs.Remove(ob);
        }

        public void setIbmPrice(double newPrice) {
            this.ibmPrice = newPrice;
            this.notify();
        }

        public void setApplePrice(double newPrice) {
            this.applePrice = newPrice;
            this.notify();
        }

        public void setGooglePrice(double newPrice) {
            this.googlePrice = newPrice;
            this.notify();
        }
    }
}