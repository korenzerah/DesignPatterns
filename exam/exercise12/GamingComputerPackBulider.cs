namespace DesignPatterns.exam.exercise12
{
    public class GamingComputerPackBulider : ComputerPackBuilder
    {
        protected override void AddGraphicCard()
        {
            this.compPack.AddGraphicCard("strong");
        }

        protected override void AddMemory()
        {
            this.compPack.AddMemory("many");
        }

        protected override void AddMotherboard()
        {
            this.compPack.AddMotherboard("strong");
        }

        protected override void AddProccessor()
        {
            this.compPack.AddProccessor("strong");
        }

        protected override void BuildPack()
        {
            this.compPack.BuildPack("strong");
        }

        protected override void RunTest()
        {
            this.compPack.RunTest();
        }
    }
}