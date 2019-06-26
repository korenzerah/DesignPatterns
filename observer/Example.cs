using System;

namespace DesignPatterns.observer
{
    class MainOfObserver
    {
        static void Example(string[] args)
        {
            StockObserver so = new StockObserver();
            StockGrabber sg = new StockGrabber();
            sg.setApplePrice(50);
            sg.register(so);
            sg.setApplePrice(51);
        }
    }
}
