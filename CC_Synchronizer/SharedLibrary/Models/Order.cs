using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerID { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderTimeStamp { get; set; }
        public string UserName { get; set; }
        public string Tags { get; set; }
        public int Frontend_ID { get; set; }
        public int Manufaturer_ID { get; set; }

        public Order()
        {

        }

        public Order(int orderId, int customerID, decimal orderTotal, DateTime orderTimeStamp, string userName, string tags, int frontend_ID, int manufaturer_ID)
        {
            OrderId = orderId;
            CustomerID = customerID;
            OrderTotal = orderTotal;
            OrderTimeStamp = orderTimeStamp;
            UserName = userName;
            Tags = tags;
            Frontend_ID = frontend_ID;
            Manufaturer_ID = manufaturer_ID;
    }
    }
}
