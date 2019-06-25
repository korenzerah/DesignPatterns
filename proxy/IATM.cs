namespace DesignPatterns.proxy
{
    public interface IATM
    {
        void deposit(int amout);
        void insertCard();
        void removeCard();
        void withdraw();
    }
}