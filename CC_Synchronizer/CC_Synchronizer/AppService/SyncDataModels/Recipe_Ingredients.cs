using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Recipe_Ingredients
    {
        public List<ShRecipeIngredients> TableList { get; set; }

        public Recipe_Ingredients()
        {
            TableList = new List<ShRecipeIngredients>();
        }

        public void Add(ShRecipeIngredients recipeIngredient)
        {
            TableList.Add(recipeIngredient);
        }

        public static Recipe_Ingredients Deserialize(string s)
        {
            SyncXMLSerializer<Recipe_Ingredients> serializerRecipe_Ingredients = new SyncXMLSerializer<Recipe_Ingredients>();
            return serializerRecipe_Ingredients.Deserialize(s);
        }
    }
}
