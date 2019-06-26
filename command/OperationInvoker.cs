namespace DesignPatterns.command
{
    public abstract class OperationInvoker
    {
        protected CommandBase command;
        public int num {get ;set;}

        public OperationInvoker(CommandBase com)
        {
            this.command = com;
        }

        public abstract void Execute();
        public abstract void Cancel();
    }
}