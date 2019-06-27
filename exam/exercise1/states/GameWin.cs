using System;

namespace DesignPatterns.exam.exercise1.states
{
    public class GameWin : GameState
    {
        public GameWin()
        {
            Console.WriteLine("Game won!");
        }

        public override GameState gameOver()
        {
            Console.WriteLine("Game is won already!");
            return this;
        }

        public override GameState gameWin()
        {
            return this;
        }

        public override GameState SpaceshipHit(GameData data, int currentLevel)
        {
            Console.WriteLine("Game is won already!");
            return this;
        }
    }
}