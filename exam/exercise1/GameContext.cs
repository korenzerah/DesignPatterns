namespace DesignPatterns.exam.exercise1
{
    public class GameContext
    {
        private GameState _state;
        private GameData data;
        public GameContext(GameState s) {
            this._state = s;
            this.data = new GameData();            
        }        

        public void SpaceshipHit(int points) {            
            this._state = this._state.SpaceshipHit(this.data, points);
        }
    }
}