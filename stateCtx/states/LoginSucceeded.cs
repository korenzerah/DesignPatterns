using System;
namespace DesignPatterns {
    public class LoginSucceeded : LoginState {        
        public LoginSucceeded(LoginContext c): base(c){
            Console.WriteLine("Succeeded!");
        }
        public override void failed() {
            Console.WriteLine("Already logged in");
        }
        public override void succeed() {            
            Console.WriteLine("Already logged in");
        }
    }
}