using System;
using System.Collections.Generic;
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

        // Dummymethode für den Test
        public DMProduct GetProductTest()
        {
            return new DMProduct(Guid.Parse("09bdd169-12b0-4167-a201-f9494a72e50b"), "chocolate cake", "yummi", 130, new DMRecipe(Guid.Parse("09bdd169-12b0-4167-a201-f9494a72e50b"), "Do this and that"));
        }
        
        // GET Methoden
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

        // PUT Methoden
        public Customer UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct()
        {
            throw new NotImplementedException();
        }

        // POST (INSERT) Methoden
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

       /** public void InsertOrder(XmlElement o)
        {
            dh.AddOrder(o);
        }*/

      /**  public void InsertProduct(XmlElement p)
        {
            dh.AddProduct(p);
        }*/

        // DELETE Methoden

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
