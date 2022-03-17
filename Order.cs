namespace SelfCheckoutStation
{
    public class Order
    {
        public List<Items> LineItems { get; set; }

        public decimal TotalItemCost { get; set; }

        public decimal SalesTax { get; set; }

        public decimal OrderTotal { get; set; }

        public override string ToString()
        {
            string items = "";

            foreach (var item in LineItems)
            {
                items = $"{items}" + $"\n{item.Quantity} items @ {item.Price:c}";
            }

            return items;
        }
        public void PrintReceipt(decimal stuff)
        {
            Console.WriteLine("====================");
            Console.WriteLine("RECEIPT");
            Console.WriteLine("====================");
            Console.WriteLine(ToString());
            Console.WriteLine($"Order total = {TotalItemCost:c}");
            Console.WriteLine($"Sales Tax: {stuff} = {SalesTax:c}");
            Console.WriteLine($"Total = {OrderTotal:c}");
            Console.WriteLine("====================");

        }
    }
}
