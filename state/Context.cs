namespace DesignPatterns {
    public class Context {
        LightState _state = null;

        public Context(LightState lightState) {
            this._state = lightState;
        }

        public void turnOn() 
        {
            this._state = this._state.turnOn();
        }

        public void turnOff() 
        {
            this._state = this._state.turnOff();
        }
    }
}