using System;

namespace AppSharedClasses
{
    public class ShRecipeIngredients
    {
        private int Id { get; set; }
        public int RecipeId { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public int IngredientId { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }
        public DateTime Lastmodified { get; set; }

        public ShRecipeIngredients() { }

        public ShRecipeIngredients(int id, int recipeId, int quantity, float unitPrice, int ingredientId, int backendID, int frontEndID, DateTime lastmodified)
        {
            Id = id;
            RecipeId = recipeId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            IngredientId = ingredientId;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }
    }
}
