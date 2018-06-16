using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Packages
    {
        public List<ShPackage> TableList { get; set; }

        public Packages()
        {
            TableList = new List<ShPackage>();
        }

        public void Add(ShPackage package)
        {
            TableList.Add(package);
        }

        public static Packages Deserialize(string s)
        {
            SyncXMLSerializer<Packages> serializerPackages = new SyncXMLSerializer<Packages>();
            return serializerPackages.Deserialize(s);
        }
    }
}
