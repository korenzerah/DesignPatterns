using System;
namespace DesignPatterns.exam.exercise12
{
    public class ComputerPack
    {
        public void BuildPack(string s) {
            Console.WriteLine($"Built {s} pack!");
        }

        public void AddMotherboard(string s) {
            Console.WriteLine($"Added {s} motherboard");
        }

        public void AddProccessor(string s) {
            Console.WriteLine($"Added {s} processor!");
        }

        public void AddGraphicCard(string s) {
            Console.WriteLine($"Added {s} graphic card");
        }

        public void AddMemory(string s) {
            Console.WriteLine($"Added {s} memory");
        }

        public void RunTest() {
            Console.WriteLine($"Running test!");
        }
    }
}