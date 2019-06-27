using System.Linq;
using System.Collections.Generic;

namespace DesignPatterns.exam.exercise7
{
    public class Chatroom : Mediator
    {
        List<Participant> chatParticipants = new List<Participant>();
        public void addParticipant(Participant p)
        {
            this.chatParticipants.Add(p);
            p.chat = this;
        }

        public void sendMessageToEveryone(int fromUserId, string msg)
        {
            this.chatParticipants.Where(x => x.id != fromUserId).ToList()
            .ForEach((par) => par.Receive(fromUserId, msg));
        }

        public void sendMessageToUser(int fromUserId, int id, string msg)
        {
            this.chatParticipants.First(x => x.id == id).Receive(fromUserId, msg);
        }
    }
}