using System;

namespace DesignPatterns {
    public class LoginFailed : LoginState {
        int counter = 1;
        public LoginFailed(LoginContext c): base(c){
            Console.WriteLine("failed - num of times left: " + (3 - counter));
        }
        public override void failed() {
            this.counter++;
            Console.WriteLine("failed - num of times left: " + (3 - counter));

            if (counter == 3) {
                this.context.state = new Blocked(this.context);
                Console.WriteLine("Blocked");
            }            
        }
        public override void succeed() {
            this.context.state = new LoginSucceeded(this.context);
        }
    }
}