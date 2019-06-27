namespace DesignPatterns.exam.exercise1
{
    public class GameData
    {
        public SpaceShip spaceship {get; set;}
        public int currentLevel {get; set;}

        public GameData()
        {
            this.spaceship = new SpaceShip();
            this.currentLevel = 0;
        }
    }
}