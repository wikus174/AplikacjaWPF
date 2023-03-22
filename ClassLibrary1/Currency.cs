namespace ClassLibrary1
{
    public class Currency
    {
        public string name { get; }
        public string symbol;
        public double exchangeRate;

        public Currency(string name, string symbol, double exchangeRate)
        {
            this.name=name;
            this.symbol=symbol;
            this.exchangeRate=exchangeRate;

        }
    }
}