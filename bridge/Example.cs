using System;

namespace DesignPatterns.bridge
{
    class MainOfBridge
    {
        static void Example(string[] args)
        {
            TV t = new TV();
            Memir m = new Memir();
            RemoteControl rc = new RemoteControl(t);
            rc.pressOn();
            rc.pressOff();
            rc.prevPressed();
            rc.device = m;
            rc.pressOn();
            rc.nextPressed();
        }
    }
}
