using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Orders
    {
        public List<ShOrders> TableList { get; set; }

        public Orders()
        {
            TableList = new List<ShOrders>();
        }

        public void Add(ShOrders order)
        {
            TableList.Add(order);
        }

        public static Orders Deserialize(string s)
        {
            SyncXMLSerializer<Orders> serializerOrders = new SyncXMLSerializer<Orders>();
            return serializerOrders.Deserialize(s);
        }
    }
}
