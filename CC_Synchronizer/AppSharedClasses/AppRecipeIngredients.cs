namespace AppSharedClasses
{
    public class AppRecipeIngredients
    {
        private int Id { get; set; }
        public int RecipeId { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public int IngredientId { get; set; }

        public AppRecipeIngredients() { }

        public AppRecipeIngredients(int id, int recipeId, int quantity, float unitPrice, int ingredientId)
        {
            Id = id;
            RecipeId = recipeId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            IngredientId = ingredientId;
        }
    }
}
