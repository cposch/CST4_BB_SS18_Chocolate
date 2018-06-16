using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Shape
    {
        public List<ShShape> TableList { get; set; }

        public Shape()
        {
            TableList = new List<ShShape>();
        }

        public void Add(ShShape shape)
        {
            TableList.Add(shape);
        }

        public static Shape Deserialize(string s)
        {
            SyncXMLSerializer<Shape> serializerShape = new SyncXMLSerializer<Shape>();
            return serializerShape.Deserialize(s);
        }
    }
}
