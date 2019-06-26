namespace DesignPatterns.command
{
    public interface IMachine
    {
        void turnOn();
        void turnOff();

        void startVirusScan();
        void stopVirusScan();

        bool canTurnOn();
    }
}