namespace SelfCheckoutStation
{
    public class SelfCheckoutStationWorkflow
    {
        public void Run(Configuration c)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Order o = new Order();

                Items i = new Items();

                OrderService os = new OrderService();

                ConsoleIO io = new ConsoleIO();

                o.LineItems = new List<Items>();

                bool scanning = true;

                while (scanning)
                {
                    i.Price = ConsoleIO.GetPrice();

                    if (i.Price == 0)
                    {
                        break;
                    }
                    else if (i.Price == -1)
                    {
                        Environment.Exit(0);
                    }

                    i.Quantity = ConsoleIO.GetQuantity();

                    os.AddLineItem(o, i);

                    Console.WriteLine(o.ToString());

                }
                o.TotalItemCost = os.FinalizeOrder(o);

                o.SalesTax = c.SalesTaxPercent * o.TotalItemCost;

                o.OrderTotal = o.TotalItemCost + o.SalesTax;

                o.PrintReceipt(c.SalesTaxPercent);

                ConsoleIO.PromptToContinue();

            }
        }


    }
}
