namespace DesignPatterns {
    public class LoginContext {
        public LoginState state = null;

        public void init() {
            this.state = new NewLogin(this);
        }

        public void success() {
            this.state.succeed();
        }

        public void failed() {
            this.state.failed();
        }
    }
}