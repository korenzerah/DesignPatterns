using System.Runtime.CompilerServices;
using System;
namespace DesignPatterns.exam.exercise7
{
    public class Participant
    {
        public int id {get; set;}
        public Chatroom chat {get; set;}

        public Participant(int id)
        {
            this.id = id;            
        }

        public void SendAll(string message) {
            Console.WriteLine("Sending message to everyone:" + this.id);
            chat.sendMessageToEveryone(this.id, message);
        }

        public void SendToUser(int id, string message) {
            Console.WriteLine("Sending user: " + id + ", the message:" + message + "from user:" + this.id);
            chat.sendMessageToUser(this.id, id, message);
        }

        public void Receive(int userId, string message) {
            Console.WriteLine($"{this.id} Received message: {message}, from USER: {userId}");
        }
    }
}