using System.Xml.Serialization;

namespace CC_Synchronizer.AppService.Data
{
    [XmlRoot("IngredientCategory")]
    public class AppIngredientCategory
    {
        [XmlAnyElement("Item")]
        IngredientCategoryAppData[] items;
    }

    public class IngredientCategoryAppData
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int BackendID { get; set; }
        public int FrontendID { get; set; }
    }
}
