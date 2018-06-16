using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Product_Info
    {
        public List<ShProductInfo> TableList { get; set; }

        public Product_Info()
        {
            TableList = new List<ShProductInfo>();
        }

        public void Add(ShProductInfo productInfo)
        {
            TableList.Add(productInfo);
        }

        public static Product_Info Deserialize(string s)
        {
            SyncXMLSerializer<Product_Info> serializerProduct_Info = new SyncXMLSerializer<Product_Info>();
            return serializerProduct_Info.Deserialize(s);
        }
    }
}
