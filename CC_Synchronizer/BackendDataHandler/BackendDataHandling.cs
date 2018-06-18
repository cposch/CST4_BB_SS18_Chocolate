using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDataHandler
{
    public class BackendDataHandling
    {
        BackendDBEntities2 db = new BackendDBEntities2();

        //Inserts ---------------------------------------------------------------

        public void AddProduct(Product p)
        {
            DEMO_PRODUCT_INFO pt = new DEMO_PRODUCT_INFO();
            pt.PRODUCT_ID = p.Product_ID;
            pt.PRODUCT_NAME = p.Product_Name;
            pt.PRODUCT_DESCRIPTION = p.Product_Description;
            pt.CATEGORY = p.Category;
            pt.PRODUCT_AVAIL = p.Product_Avail;
            pt.LIST_PRICE = p.List_Price;
            pt.PRODUCT_IMAGE = p.Product_Image;
            pt.MIMETYPE = p.MIMETYPE;
            pt.FILENAME = p.Filename;
            pt.IMAGE_LAST_UPDATE = p.Image_Last_Update;
            pt.TAGS = p.Tags;
            pt.SALE_PRICE = p.Sale_Price;
            pt.SALE_BEGIN = p.Sale_Begin;
            pt.SALE_END = p.Sale_End;
            pt.FRONTEND_ID = p.Frontend_ID;
            pt.MANUFACTURER_ID = p.Manufaturer_ID;

            db.DEMO_PRODUCT_INFO.Add(pt);
            db.SaveChanges();
        }

        public void AddCustomer(Customer c)
        {
            DEMO_CUSTOMERS ct = new DEMO_CUSTOMERS();
            ct.CUSTOMER_ID = c.CustomerId;
            ct.CUST_FIRST_NAME = c.FirstName;
            ct.CUST_LAST_NAME = c.LastName;
            ct.CUST_STREET_ADDRESS1 = c.Address;
            ct.CUST_CITY = c.City;
            ct.CUST_STATE = c.State;
            ct.CUST_POSTAL_CODE = c.Zip;
            ct.CUST_EMAIL = c.Email;
            ct.PHONE_NUMBER1 = c.PhoneNumber;
            ct.URL = c.Url;
            ct.CREDIT_LIMIT = c.CreditLimit;
            ct.TAGS = c.Tags;
            db.DEMO_CUSTOMERS.Add(ct);
            db.SaveChanges();
        }

        public void AddOrder(Order o)
        {
            DEMO_ORDERS ot = new DEMO_ORDERS();

            ot.ORDER_ID = o.OrderId;
            ot.CUSTOMER_ID = o.CustomerID;
            ot.ORDER_TOTAL = o.OrderTotal;
            ot.ORDER_TIMESTAMP = o.OrderTimeStamp;
            ot.USER_NAME = o.UserName;
            ot.TAGS = o.Tags;
            ot.FRONTEND_ID = o.Frontend_ID;
            ot.MANUFACTURER_ID = o.Manufaturer_ID;
            db.DEMO_ORDERS.Add(ot);
            db.SaveChanges();
        }

        public void AddOrderItem(OrderItem oi)
        {
            DEMO_ORDER_ITEMS oit = new DEMO_ORDER_ITEMS();
            oit.ORDER_ITEM_ID = oi.OrderItemID;
            oit.ORDER_ID = oi.OrderID;
            oit.PRODUCT_ID = oi.ProductID;
            oit.UNIT_PRICE = oi.UnitPrice;
            oit.QUANTITY = oi.Quantity;
            oit.MANUFACTURER_ID = oi.ManufacturerID;
            oit.FRONTEND_ID = oi.FrontEndID;
            db.DEMO_ORDER_ITEMS.Add(oit);
            db.SaveChanges();
        }


        //QueryALL -------------------------------------------------------------

        public List<Product> QueryAllProducts()
        {
            return db.DEMO_PRODUCT_INFO.Select(w => new Product()
            {
                Product_ID = (int)w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = (decimal)w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = (DateTime)w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = (decimal)w.SALE_PRICE,
                Sale_Begin = (DateTime)w.SALE_BEGIN,
                Sale_End = (DateTime)w.SALE_END,
                Frontend_ID = (int)w.FRONTEND_ID,
                Manufaturer_ID = (int)w.MANUFACTURER_ID

            }).ToList();
        }

        public List<Customer> QueryAllCustomer()
        {
            return db.DEMO_CUSTOMERS.Select(w => new Customer()
            {

                CustomerId = (int)w.CUSTOMER_ID,
                FirstName = w.CUST_FIRST_NAME,
                LastName = w.CUST_LAST_NAME,
                Address = w.CUST_STREET_ADDRESS1,
                City = w.CUST_CITY,
                State = w.CUST_STATE,
                Zip = w.CUST_POSTAL_CODE,
                Email = w.CUST_EMAIL,
                PhoneNumber = w.PHONE_NUMBER1,
                Url = w.URL,
                CreditLimit = (int)w.CREDIT_LIMIT,
                Tags = w.TAGS
            }).ToList();
        }

        public List<Order> QueryAllOrders()
        {
            return db.DEMO_ORDERS.Select(w => new Order()
            {
              OrderId = (int)w.ORDER_ID,
                CustomerID = (int)w.CUSTOMER_ID,
                OrderTotal = (decimal)w.ORDER_TOTAL,
                OrderTimeStamp = (DateTime)w.ORDER_TIMESTAMP,
                UserName = w.USER_NAME,
                Tags = w.TAGS,
                Frontend_ID = (int)w.FRONTEND_ID,
                Manufaturer_ID = (int)w.MANUFACTURER_ID

            }).ToList();

        }
        public List<OrderItem> QueryAllOrderItmesByOrder(Order o)
        {
            return db.DEMO_ORDER_ITEMS.Where(w => w.ORDER_ID.Equals(o.OrderId)).Select(w => new OrderItem()
            {
                OrderItemID = (int)w.ORDER_ITEM_ID,
                OrderID = (int)w.ORDER_ID,
                ProductID = (int)w.PRODUCT_ID,
                UnitPrice = w.UNIT_PRICE,
                Quantity = w.QUANTITY,
                ManufacturerID = (int)w.MANUFACTURER_ID,
                FrontEndID = (int)w.FRONTEND_ID
        }).ToList();

    }
}
}
