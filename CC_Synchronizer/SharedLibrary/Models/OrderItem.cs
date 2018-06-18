using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class OrderItem
    {
        public decimal OrderItemID { get; set; }
        public decimal OrderID { get; set; }
        public decimal ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal? ManufacturerID { get; set; }
        public decimal? FrontEndID { get; set; }

        public OrderItem() { }

        public OrderItem(decimal orderItemID, decimal orderID, decimal productID, decimal unitPrice, int quantity, decimal manufacturerID, decimal frontEndID)
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
