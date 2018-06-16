using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Ingredients
    {
        public List<ShIngredient> TableList { get; set; }

        public Ingredients()
        {
            TableList = new List<ShIngredient>();
        }

        public void Add(ShIngredient ingredient)
        {
            TableList.Add(ingredient);
        }

        public static Ingredients Deserialize(string s)
        {
            SyncXMLSerializer<Ingredients> serializerIngredients = new SyncXMLSerializer<Ingredients>();
            return serializerIngredients.Deserialize(s);
        }
    }
}
