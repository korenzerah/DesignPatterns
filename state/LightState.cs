namespace DesignPatterns
{
    public abstract class LightState {
        
        public abstract LightState turnOn();
        public abstract LightState turnOff();
        public abstract LightState fix();
    }   
}