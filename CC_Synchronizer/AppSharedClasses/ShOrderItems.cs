using System;

namespace AppSharedClasses
{
    public class ShOrderItems
    {
        private int OrderItemID;
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public float UnitPrice { get; set; }
        public float Quantity { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }
        public DateTime Lastmodified { get; set; }

        public ShOrderItems() { }

        public ShOrderItems(int orderItemID, int orderID, int productID, float unitPrice, float quantity, int backendID, int frontEndID, DateTime lastmodified)
        {
            OrderItemID = orderItemID;
            OrderID = orderID;
            ProductID = productID;
            UnitPrice = unitPrice;
            Quantity = quantity;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }
    }
}
