namespace DesignPatterns {
    public class NewLogin : LoginState {

        public NewLogin(LoginContext c): base(c){}
        public override void failed() {
            this.context.state = new LoginFailed(this.context);
        }
        public override void succeed() {
            this.context.state = new LoginSucceeded(this.context);
        }
    }
}