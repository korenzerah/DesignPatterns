namespace DesignPatterns.exam.exercise1
{
    public abstract class GameState
    {
         public abstract GameState gameOver();
         public abstract GameState gameWin();
         public abstract GameState SpaceshipHit(GameData data, int points);
    }
}