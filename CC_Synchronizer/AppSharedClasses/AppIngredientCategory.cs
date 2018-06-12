namespace AppSharedClasses
{
    public class AppIngredientCategory
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }

        public AppIngredientCategory() { }

        public AppIngredientCategory(int id, string name, int backendID, int frontEndID)
        {
            Id = id;
            Name = name;
            BackendID = backendID;
            FrontEndID = frontEndID;
        }
    }
}
