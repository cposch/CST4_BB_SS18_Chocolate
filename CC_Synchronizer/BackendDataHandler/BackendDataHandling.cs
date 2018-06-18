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
                Product_ID = w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = w.SALE_PRICE,
                Sale_Begin = w.SALE_BEGIN,
                Sale_End = w.SALE_END,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID

            }).ToList();
        }

        public List<Product> QueryAllProductsbyFID(int FID)
        {
            return db.DEMO_PRODUCT_INFO.Where(w => w.FRONTEND_ID.Equals(FID)).Select(w => new Product()
            {
                Product_ID = w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = w.SALE_PRICE,
                Sale_Begin = w.SALE_BEGIN,
                Sale_End = w.SALE_END,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID
            }).ToList();
        }

        public List<Product> QueryAllProductsbyMID(int MID)
        {
            return db.DEMO_PRODUCT_INFO.Where(w => w.MANUFACTURER_ID.Equals(MID)).Select(w => new Product()
            {
                Product_ID = w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = w.SALE_PRICE,
                Sale_Begin = w.SALE_BEGIN,
                Sale_End = w.SALE_END,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID
            }).ToList();
        }

        public List<Customer> QueryAllCustomer(int FID)
        {
            return db.DEMO_CUSTOMERS.Where(w => w.FRONTEND_ID.Equals(FID)).Select(w => new Customer()
            {

                CustomerId = w.CUSTOMER_ID,
                FirstName = w.CUST_FIRST_NAME,
                LastName = w.CUST_LAST_NAME,
                Address = w.CUST_STREET_ADDRESS1,
                City = w.CUST_CITY,
                State = w.CUST_STATE,
                Zip = w.CUST_POSTAL_CODE,
                Email = w.CUST_EMAIL,
                PhoneNumber = w.PHONE_NUMBER1,
                Url = w.URL,
                CreditLimit = w.CREDIT_LIMIT,
                Tags = w.TAGS
            }).ToList();
        }

        public List<Customer> QueryAllCustomerbyFID(int FID)
        {
            return db.DEMO_CUSTOMERS.Select(w => new Customer()
            {

                CustomerId = w.CUSTOMER_ID,
                FirstName = w.CUST_FIRST_NAME,
                LastName = w.CUST_LAST_NAME,
                Address = w.CUST_STREET_ADDRESS1,
                City = w.CUST_CITY,
                State = w.CUST_STATE,
                Zip = w.CUST_POSTAL_CODE,
                Email = w.CUST_EMAIL,
                PhoneNumber = w.PHONE_NUMBER1,
                Url = w.URL,
                CreditLimit = w.CREDIT_LIMIT,
                Tags = w.TAGS
            }).ToList();
        }


        public List<Order> QueryAllOrders(int FID)
        {
            return db.DEMO_ORDERS.Where(w => w.FRONTEND_ID.Equals(FID)).Select(w => new Order()
            {
              OrderId = w.ORDER_ID,
                CustomerID = w.CUSTOMER_ID,
                OrderTotal = w.ORDER_TOTAL,
                OrderTimeStamp = w.ORDER_TIMESTAMP,
                UserName = w.USER_NAME,
                Tags = w.TAGS,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID

            }).ToList();

        }

        public List<Order> QueryAllOrdersbyMID(int MID)
        {
            return db.DEMO_ORDERS.Where(w => w.MANUFACTURER_ID.Equals(MID)).Select(w => new Order()
            {
                OrderId = w.ORDER_ID,
                CustomerID = w.CUSTOMER_ID,
                OrderTotal = w.ORDER_TOTAL,
                OrderTimeStamp = w.ORDER_TIMESTAMP,
                UserName = w.USER_NAME,
                Tags = w.TAGS,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID

            }).ToList();

        }

        public List<Order> QueryAllOrdersbyFID()
        {
            return db.DEMO_ORDERS.Select(w => new Order()
            {
                OrderId = w.ORDER_ID,
                CustomerID = w.CUSTOMER_ID,
                OrderTotal = w.ORDER_TOTAL,
                OrderTimeStamp = w.ORDER_TIMESTAMP,
                UserName = w.USER_NAME,
                Tags = w.TAGS,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID

            }).ToList();

        }
        public List<OrderItem> QueryAllOrderItmesByOrder(int oid)
        {
            return db.DEMO_ORDER_ITEMS.Where(w => w.ORDER_ID.Equals(oid)).Select(w => new OrderItem()
            {
                OrderItemID = w.ORDER_ITEM_ID,
                OrderID = w.ORDER_ID,
                ProductID = w.PRODUCT_ID,
                UnitPrice = w.UNIT_PRICE,
                Quantity = w.QUANTITY,
                ManufacturerID = w.MANUFACTURER_ID,
                FrontEndID = w.FRONTEND_ID
        }).ToList();

    }
}
}
