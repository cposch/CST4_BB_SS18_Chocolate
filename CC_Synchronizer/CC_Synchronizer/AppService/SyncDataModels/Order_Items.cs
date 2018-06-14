using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Order_Items
    {
        public List<ShOrderItems> TableList { get; set; }

        public Order_Items()
        {
            TableList = new List<ShOrderItems>();
        }

        public void Add(ShOrderItems orderItem)
        {
            TableList.Add(orderItem);
        }

        public static Order_Items Deserialize(string s)
        {
            SyncXMLSerializer<Order_Items> serializerOrder_Items = new SyncXMLSerializer<Order_Items>();
            return serializerOrder_Items.Deserialize(s);
        }
    }
}
