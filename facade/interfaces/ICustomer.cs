namespace DesignPatterns.facade.interfaces
{
    public interface ICustomer : IUserProxy
    {
         void buyTicket(string flightId);
    }
}