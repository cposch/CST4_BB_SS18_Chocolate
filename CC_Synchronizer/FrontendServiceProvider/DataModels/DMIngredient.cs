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
        // how many values do we need?
        public Guid IngredientID { get; set; }
        public string IngredientName { get; set; }
        public string IngredientDescription { get; set; }
        public float IngredientPrice { get; set; }
        public string IngredientCategory { get; set; }

        // add constructor
    }
}
