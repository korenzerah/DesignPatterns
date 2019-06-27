using System;

namespace DesignPatterns.exam.exercise1.states
{
    public class GameOver : GameState
    {
        public GameOver()
        {
            Console.WriteLine("Game over!");
        }

        public override GameState gameOver()
        {
            return this;
        }

        public override GameState gameWin()
        {
            Console.WriteLine("Game is already over!");
            return this;
        }
        public override GameState SpaceshipHit(GameData data, int points)
        {
            Console.WriteLine("Game is already over!");
            return this;
        }
    }
}