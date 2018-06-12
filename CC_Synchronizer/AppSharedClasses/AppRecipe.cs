namespace AppSharedClasses
{
    public class AppRecipe
    {
        private int Id { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }

        public AppRecipe() { }

        public AppRecipe(int id, int productId, string description)
        {
            Id = id;
            ProductId = productId;
            Description = description;
        }
    }
}
