using System;

namespace AppSharedClasses
{
    public class AppOrders
    {
        private int OrdersID;
        public int CustomerID { get; set; }
        public float OrderTotal { get; set; }
        public DateTime OrderTimeStamp { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }

        public AppOrders() { }

        public AppOrders(int ordersID, int customerID, float orderTotal, DateTime orderTimeStamp, string userName, string status)
        {
            OrdersID = ordersID;
            CustomerID = customerID;
            OrderTotal = orderTotal;
            OrderTimeStamp = orderTimeStamp;
            UserName = userName;
            Status = status;
        }
    }
}
