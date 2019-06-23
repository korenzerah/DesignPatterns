namespace DesignPatterns
{
    public class Tank : Vehicle
    {       
        private string year;
        private string commanderName; 
        public Tank (string model, string year, string commanderName) : base(model) {
            this.year = year;
            this.commanderName = commanderName;
        }

        public override string ToString() 
        {
            return base.ToString() + ", year: " + this.year + ", commanderName: " + this.commanderName;
        }
    }
}