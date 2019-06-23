using System;
namespace DesignPatterns {
    class BillT : BillHandler {
        public int divider;

        public BillT(int divider) {
            this.divider = divider;
        }
        
        public override void handle(int amount) {
            if (amount >= divider) {
                Console.WriteLine("Giving "+ this.divider + "x" + amount / this.divider);
            }

            if (amount % this.divider > 0) {
                this.next.handle(amount % divider);
            }
        }
    }
}