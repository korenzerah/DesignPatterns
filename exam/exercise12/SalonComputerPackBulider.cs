namespace DesignPatterns.exam.exercise12
{
    public class SalonComputerPackBulider : ComputerPackBuilder
    {
        protected override void AddGraphicCard()
        {
            this.compPack.AddGraphicCard("strong");
        }

        protected override void AddMemory()
        {
            this.compPack.AddMemory("low");
        }

        protected override void AddMotherboard()
        {
            this.compPack.AddMotherboard("low");
        }

        protected override void AddProccessor()
        {
            this.compPack.AddProccessor("dak");
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