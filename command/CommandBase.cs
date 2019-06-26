namespace DesignPatterns.command
{
    public abstract class CommandBase : ICommand
    {
        public IMachine machine {get; private set;}
        public CommandBase(IMachine m)
        {
            this.machine = m;
        }

        public abstract void Cancel();
        public abstract void Execute();
    }
}