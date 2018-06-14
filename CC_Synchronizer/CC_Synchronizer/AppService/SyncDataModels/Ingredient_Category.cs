using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Ingredient_Category
    {
        public List<ShIngredientCategory> TableList { get; set; }

        public Ingredient_Category()
        {
            TableList = new List<ShIngredientCategory>();
        }

        public void Add(ShIngredientCategory ingredient_Category)
        {
            TableList.Add(ingredient_Category);
        }

        public static Ingredient_Category Deserialize(string s)
        {
            SyncXMLSerializer<Ingredient_Category> serializerIngredient_Category = new SyncXMLSerializer<Ingredient_Category>();
            return serializerIngredient_Category.Deserialize(s);
        }
    }
}
