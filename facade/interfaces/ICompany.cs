namespace DesignPatterns.facade.interfaces
{
    public interface ICompany : IUserProxy
    {
         void createFlight(string flightId);
    }
}