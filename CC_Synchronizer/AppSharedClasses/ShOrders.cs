using System;

namespace AppSharedClasses
{
    public class ShOrders
    {
        public int? OrdersID;
        public int? CustomerID { get; set; }
        public float OrderTotal { get; set; }
        public DateTime? OrderTimeStamp { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public int? BackendID { get; set; }
        public int? FrontEndID { get; set; }
        public DateTime? Lastmodified { get; set; }

        public ShOrders() { }

        public ShOrders(int? ordersID, int? customerID, float orderTotal, DateTime? orderTimeStamp, string userName, string status, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            OrdersID = ordersID;
            CustomerID = customerID;
            OrderTotal = orderTotal;
            OrderTimeStamp = orderTimeStamp;
            UserName = userName;
            Status = status;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }

        public ShOrders(int? customerID, float orderTotal, DateTime? orderTimeStamp, string userName, string status, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            CustomerID = customerID;
            OrderTotal = orderTotal;
            OrderTimeStamp = orderTimeStamp;
            UserName = userName;
            Status = status;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }
    }
}
