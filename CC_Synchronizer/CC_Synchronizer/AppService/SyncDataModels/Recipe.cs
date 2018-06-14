using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Recipe
    {
        public List<ShRecipe> TableList { get; set; }

        public Recipe()
        {
            TableList = new List<ShRecipe>();
        }

        public void Add(ShRecipe recipe)
        {
            TableList.Add(recipe);
        }

        public static Recipe Deserialize(string s)
        {
            SyncXMLSerializer<Recipe> serializerRecipe = new SyncXMLSerializer<Recipe>();
            return serializerRecipe.Deserialize(s);
        }
    }
}
