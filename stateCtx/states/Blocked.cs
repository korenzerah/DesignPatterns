namespace DesignPatterns {
    public class Blocked : LoginState {

        public Blocked(LoginContext c): base(c){}
        public override void succeed() {

        }

        public override void failed() {
        }
    }
}