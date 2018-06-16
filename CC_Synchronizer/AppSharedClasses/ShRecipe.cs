namespace AppSharedClasses
{
    public class ShRecipe
    {
        private int Id { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }

        public ShRecipe() { }

        public ShRecipe(int id, int productId, string description, int backendID, int frontEndID)
        {
            Id = id;
            ProductId = productId;
            Description = description;
            BackendID = backendID;
            FrontEndID = frontEndID;
        }
    }
}
