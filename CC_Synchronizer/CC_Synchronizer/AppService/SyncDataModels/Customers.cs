using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Customers
    {
        public List<ShCustomers> TableList { get; set; }

        public Customers()
        {
            TableList = new List<ShCustomers>();
        }

        public void Add(ShCustomers customer)
        {
            TableList.Add(customer);
        }

        public static Customers Deserialize(string s)
        {
            SyncXMLSerializer<Customers> serializerCustomers = new SyncXMLSerializer<Customers>();
            return serializerCustomers.Deserialize(s);
        }
    }
}
