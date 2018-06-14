namespace AppSharedClasses
{
    public class ShIngredientCategory
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }

        public ShIngredientCategory() { }

        public ShIngredientCategory(int id, string name, int backendID, int frontEndID)
        {
            Id = id;
            Name = name;
            BackendID = backendID;
            FrontEndID = frontEndID;
        }

        public ShIngredientCategory(string name, int backendID, int frontEndID)
        {
            Name = name;
            BackendID = backendID;
            FrontEndID = frontEndID;
        }
    }
}
