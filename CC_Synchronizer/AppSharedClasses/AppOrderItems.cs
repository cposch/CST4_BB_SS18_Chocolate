namespace AppSharedClasses
{
    public class AppOrderItems
    {
        private int OrderItemID;
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public float UnitPrice { get; set; }
        public float Quantity { get; set; }

        public AppOrderItems() { }

        public AppOrderItems(int orderItemID, int orderID, int productID, float unitPrice, float quantity)
        {
            OrderItemID = orderItemID;
            OrderID = orderID;
            ProductID = productID;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
