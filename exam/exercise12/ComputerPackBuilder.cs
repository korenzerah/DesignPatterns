namespace DesignPatterns.exam.exercise12
{
    public abstract class ComputerPackBuilder
    {
        protected ComputerPack compPack;

        public virtual void buildComputerPack() {
            this.compPack = new ComputerPack();
            this.BuildPack();
            this.AddMotherboard();
            this.AddProccessor();
            this.AddGraphicCard();
            this.AddMemory();
            this.RunTest();
        }

        protected abstract void BuildPack();
        protected abstract void AddMotherboard();
        protected abstract void AddProccessor();
        protected abstract void AddGraphicCard();
        protected abstract void AddMemory();
        protected abstract void RunTest();
    }
}