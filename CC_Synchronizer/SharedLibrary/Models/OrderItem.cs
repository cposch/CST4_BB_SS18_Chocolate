using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int ManufacturerID { get; set; }
        public int FrontEndID { get; set; }

        public OrderItem() { }

        public OrderItem(int orderItemID, int orderID, int productID, decimal unitPrice, int quantity, int manufacturerID, int frontEndID)
        {
            OrderItemID = orderItemID;
            OrderID = orderID;
            ProductID = productID;
            UnitPrice = unitPrice;
            Quantity = quantity;
            ManufacturerID = manufacturerID;
            FrontEndID = frontEndID;
        }
    }
}
