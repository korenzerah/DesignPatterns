namespace DesignPatterns.bridge
{

    public class RemoteControl
    {
        public EntertainmentDevice device {get; set;}
        
        public RemoteControl(EntertainmentDevice device) {
            this.device = device;
        }        

        public void pressOn() {
            this.device.turnOn();
        }

        public void pressOff() {
            this.device.turnOff();
        }

        public void nextPressed() {
            this.device.nextPressed();
        }

        public void prevPressed() {
            this.device.prevPressed();
        }
    }
}