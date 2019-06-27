namespace DesignPatterns.exam.exercise7
{
    public interface Mediator
    {
        void sendMessageToUser(int fromUserId, int id, string msg);
        void sendMessageToEveryone(int fromUserId, string msg);
        void addParticipant(Participant p);
    }
}