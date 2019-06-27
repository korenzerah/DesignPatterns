using System;

namespace DesignPatterns.exam.exercise10 {
    public class WindowHandler {
        protected WindowHandler next;
        public void setNext(WindowHandler next) {
            this.next = next;
            // return this.next;
        }
        public virtual void handle() {
            Console.WriteLine("I'm a basic window");
            if(this.next != null) {
                this.next.handle();
            }
        }
    }
}