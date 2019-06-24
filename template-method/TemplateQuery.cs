namespace DesignPatterns.template_method
{
    public abstract class TemplateQuery
    {
        public abstract void openConnection();
        public abstract void runQuery();
        public abstract void closeConnection();

        public virtual void run() {
            this.openConnection();
            this.runQuery();
            this.closeConnection();
        }
    }
}