namespace DesignPatterns.bridge
{
    public abstract class EntertainmentDevice
    {        
        protected int state;
        protected int maxSetting;
        protected bool isOn;

        public void turnOn() {
            this.isOn = true;
        }

        public void turnOff() {
            this.isOn = false;
        }

        public abstract void printStatus();
        public abstract void nextPressed();
        public abstract void prevPressed();        
    }
}