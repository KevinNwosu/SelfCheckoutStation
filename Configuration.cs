namespace SelfCheckoutStation
{
    public class Configuration
    {
        public decimal SalesTaxPercent { get; private set; }

        public Configuration(decimal salesTax)
        {
            SalesTaxPercent = salesTax;
        }
    }
}
