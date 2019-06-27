namespace DesignPatterns.exam.exercise5
{
    public abstract class LogDecorator : ILog
    {
        protected ILog log;

        public LogDecorator(ILog l) {
            this.log = l;
        }
        public abstract void WriteLog();
    }
}