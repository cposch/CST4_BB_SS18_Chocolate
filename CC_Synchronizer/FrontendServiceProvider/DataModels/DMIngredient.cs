using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendServiceProvider.DataModels
{
    public class DMIngredient
    {
        // only Oracle Backend values. table name = INGREDIENT
        
        public Guid IngredientID { get; set; }
        public string IngredientName { get; set; }
        public string IngredientDescription { get; set; }
        public float IngredientPrice { get; set; }
        public string IngredientCategory { get; set; }

        // constructor
        public DMIngredient()
        {

        }

        public DMIngredient(Guid ingredientID, string ingredientName, string ingredientDescription, float ingredientPrice, string ingredientCategory)
        {
            IngredientID = ingredientID;
            IngredientName = ingredientName;
            IngredientDescription = ingredientDescription;
            IngredientPrice = ingredientPrice;
            IngredientCategory = ingredientCategory;
        }
    }
}
