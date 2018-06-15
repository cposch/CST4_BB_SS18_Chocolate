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
        public float OrderTotal { get; set; }
        public DateTime OrderTimeStamp { get; set; }
        public string UserName { get; set; }
        public string Tags { get; set; }

        public Order()
        {

        }

        public Order(int orderId, int customerID, float orderTotal, DateTime orderTimeStamp, string userName, string tags)
        {
            OrderId = orderId;
            CustomerID = customerID;
            OrderTotal = orderTotal;
            OrderTimeStamp = orderTimeStamp;
            UserName = userName;
            Tags = tags;
        }
    }
}
