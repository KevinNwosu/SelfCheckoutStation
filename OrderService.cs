namespace SelfCheckoutStation
{
    public class OrderService
    {
        public void AddLineItem(Order order, Items lineItem)
        {
            order.LineItems.Add(new Items() {Price = lineItem.Price, Quantity = lineItem.Quantity});
        }
        public decimal FinalizeOrder(Order order)
        {
            decimal total = 0;

            foreach (var item in order.LineItems)
            {
                total = total + (item.Price * item.Quantity); 
            }
            return total;
        }

    }
}
