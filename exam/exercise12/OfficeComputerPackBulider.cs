namespace DesignPatterns.exam.exercise12
{
    public class OfficeComputerPackBuilder : ComputerPackBuilder
    {
        protected override void AddGraphicCard()
        {
            this.compPack.AddGraphicCard("average");
        }

        protected override void AddMemory()
        {
            this.compPack.AddMemory("average");
        }

        protected override void AddMotherboard()
        {
            this.compPack.AddMotherboard("average");
        }

        protected override void AddProccessor()
        {
            this.compPack.AddProccessor("average");
        }

        protected override void BuildPack()
        {
            this.compPack.BuildPack("average");
        }

        protected override void RunTest()
        {
            this.compPack.RunTest();
        }
    }
}