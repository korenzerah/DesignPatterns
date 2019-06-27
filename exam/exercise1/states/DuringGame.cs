namespace DesignPatterns.exam.exercise1.states
{
    public class DuringGame : GameState
    {
        public override GameState gameOver()
        {
            return new GameOver();
        }

        public override GameState gameWin()
        {
            return new GameWin();
        }

        public override GameState SpaceshipHit(GameData data, int points)
        {            
            data.spaceship.hit(points);
            data.currentLevel++;

            if (data.spaceship.points <= 0) {
                return this.gameOver();
            } else if (data.currentLevel == 3) {
                return this.gameWin();
            } else {
                return this;
            }                
        }            
    }
}
