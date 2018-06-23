using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using BackendDataHandler;
using RESTFrontendService.DataModels;
using SharedLibrary.Models;

namespace RESTFrontendService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestServiceImpl.svc or RestServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class RestServiceImpl : IRestServiceImpl
    {

        BackendDataHandling dh = new BackendDataHandling();

        // Dummymethode für den Test ....................................................................................
        public DMProduct GetProductTest()
        {
            return new DMProduct(Guid.Parse("09bdd169-12b0-4167-a201-f9494a72e50b"), "chocolate cake", "yummi", 130, new DMRecipe(Guid.Parse("09bdd169-12b0-4167-a201-f9494a72e50b"), "Do this and that"));
        }

        // GET Methoden .................................................................................................
        public List<Customer> GetCustomers()
        {
            return dh.QueryAllCustomer();
        }

        public List<Order> GetOrders()
        {
            return dh.QueryAllOrders();
        }

        public List<Product> GetProducts()
        {
            return dh.QueryAllProducts();
        }

        public List<Product> GetUpdatedForFrontendProducts()
        {
            return dh.QueryAllProductsByLastUpdatedForFrontend();
        }

        public List<Product> GetUpdatedForManufacturerProducts()
        {
            return dh.QueryAllProductsByLastUpdatedForManufacturer();
        }

        public List<Customer> GetUpdatedForFrontendCustomers()
        {
            return dh.QueryAllCustomersByLastUpdatedForFrontend();
        }

        public List<Customer> GetUpdatedForManufacturerCustomers()
        {
            return dh.QueryAllCustomersByLastUpdatedForManufacturer();
        }
        // PUT Methoden .................................................................................................
        public Customer UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductFID(XmlElement pFID)
        {
            decimal pid = decimal.Parse(pFID.GetAttribute("ProductID"));
            decimal fid = decimal.Parse(pFID.GetAttribute("FrontendID"));
            dh.UpdateProductFID(pid, fid, "FRONTEND");
        }

        // POST (INSERT) Methoden ........................................................................................
        public void InsertCustomer(XmlElement c)
        {
            dh.AddCustomer(new Customer() {
                CustomerId = int.Parse(c.GetAttribute("Id")),
                FirstName = c.GetAttribute("FirstName"),
                LastName = c.GetAttribute("LastName"),
                Address = c.GetAttribute("Address"),
                City = c.GetAttribute("City"),
                State = c.GetAttribute("State"),
                Zip = c.GetAttribute("Zip"),
                Email = c.GetAttribute("Email"),
                PhoneNumber = c.GetAttribute("PhoneNumber"),
                Url = c.GetAttribute("Url"),
                CreditLimit = int.Parse(c.GetAttribute("CreditLimit")),
                Tags = c.GetAttribute("Tags")

            });

        }

        public void InsertOrder(XmlElement o)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            CultureInfo provider = CultureInfo.InvariantCulture;

            dh.AddOrder(new Order() {
                OrderId = decimal.Parse(o.GetAttribute("Id")),
                CustomerID = decimal.Parse(o.GetAttribute("CustomerID")),
                OrderTotal = decimal.Parse(o.GetAttribute("OrderTotal")),
                OrderTimeStamp = DateTime.ParseExact(o.GetAttribute("DateTime"), format, provider),
                UserName = o.GetAttribute("UserName"),
                Tags = o.GetAttribute("Tags"),
                Frontend_ID = decimal.Parse(o.GetAttribute("FrontendID")),
                //Manufaturer_ID = decimal.Parse(o.GetAttribute("ManufacturerID"))
            });
        }

        public void InsertProduct(XmlElement p)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            CultureInfo provider = CultureInfo.InvariantCulture;

            dh.AddProduct(new Product() {
                
                //Product_ID = decimal.Parse(p.GetAttribute("ProductID")),
                Product_Name = p.GetAttribute("ProductName"),
                Product_Description = p.GetAttribute("ProductDescription"),
                Category = p.GetAttribute("Category"),
                Product_Avail = p.GetAttribute("ProductAvail"),
                List_Price = decimal.Parse(p.GetAttribute("ListPrice")),
                //Product_Image = byte[].Parse(p.GetAttribute("s")),
                MIMETYPE = p.GetAttribute("MimeType"),
                Filename = p.GetAttribute("Filename"),
                Image_Last_Update = DateTime.ParseExact(p.GetAttribute("ImgLastUpdate"), format, provider),
                Tags = p.GetAttribute("Tags"),
                Sale_Price = decimal.Parse(p.GetAttribute("SalePrice")),
                Sale_Begin = DateTime.ParseExact(p.GetAttribute("SaleBegin"), format, provider),
                Sale_End = DateTime.ParseExact(p.GetAttribute("SaleEnd"), format, provider),
                Frontend_ID = decimal.Parse(p.GetAttribute("FrontendID")),
                //Manufaturer_ID = decimal.Parse(p.GetAttribute("ManufacturerID"))
            });
        }

        // DELETE Methoden .............................................................................................

        public Customer DeleteCustomer(string customerID)
        {
            throw new NotImplementedException();
        }

        public Order DeleteOrder(string orderID)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(string productID)
        {
            throw new NotImplementedException();
        }
    }
}
