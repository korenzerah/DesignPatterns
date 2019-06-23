namespace DesignPatterns
{
    public abstract class LoginState {
        protected LoginContext context;

        public LoginState(LoginContext context) {
            this.context = context;
        }
        public abstract void succeed();
        public abstract void failed();        
    }   
}