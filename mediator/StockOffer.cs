namespace DesignPatterns.mediator
{
    public class StockOffer
    {
        public int stockShares {get;set;}
        public string stockName {get; set;}        
        public int colleagueCode { get; set; }
        
        public StockOffer(int shares, string sym, int colleagueCode) {
            this.stockName = sym;
            this.stockShares = shares;
            this.colleagueCode = colleagueCode;
        }
        public override string ToString() {
            return $"Name: {stockName}, Shares: {stockShares}, collCode: {colleagueCode}";
        }
    }
}