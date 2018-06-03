using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendServiceProvider.DataModels
{
    public class DMIngredient
    {
        // only Oracle Backend values. table name = INGREDIENT (+ INGREDIENT_CATEGORY for the category)
        // ToDo: add values from PHP myAdmin database
        // how many values do we need?
        public float IngredientPrice { get; set; }
        public string IngredientType { get; set; }
        public string IngredientDescription { get; set; }
        public string Category { get; set; }

        // add constructor
    }
}
