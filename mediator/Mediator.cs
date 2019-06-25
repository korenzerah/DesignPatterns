namespace DesignPatterns.mediator
{
    public interface Mediator
    {
        void sellOffer(string stock, int shares, int collCode);
        void buyOffer(string stock, int shares, int collCode);

        void addColleague(Colleague col);
    }
}