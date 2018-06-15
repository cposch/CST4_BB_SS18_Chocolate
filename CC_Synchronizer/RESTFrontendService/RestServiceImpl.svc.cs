using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTFrontendService.DataModels;
using SharedLibrary.Models;

namespace RESTFrontendService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestServiceImpl.svc or RestServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class RestServiceImpl : IRestServiceImpl
    {
        // Dummymethode für den Test
        public DMProduct GetProductTest()
        {
            return new DMProduct(Guid.Parse("09bdd169-12b0-4167-a201-f9494a72e50b"), "chocolate cake", "yummi", 130, new DMRecipe(Guid.Parse("09bdd169-12b0-4167-a201-f9494a72e50b"), "Do this and that"));
        }

        // DELETE Methoden
        public Customer DeleteCustomer(int customerID)
        {
            throw new NotImplementedException();
        }

        public Order DeleteOrder(int orderID)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(int productID)
        {
            throw new NotImplementedException();
        }

        // GET Methoden
        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        // POST Methoden
        public Customer InsertCustomer(Customer c)
        {
            throw new NotImplementedException();
        }

        public Order InsertOrder(Order o)
        {
            throw new NotImplementedException();
        }

        public Product InsertProduct(Product p)
        {
            throw new NotImplementedException();
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
    }
}
