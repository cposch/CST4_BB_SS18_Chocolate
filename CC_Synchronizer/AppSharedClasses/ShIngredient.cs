namespace AppSharedClasses
{
    public class ShIngredient
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string LocationTop { get; set; }
        public string LocationBottom { get; set; }
        public string LocationChoc { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }

        public ShIngredient() { }

        public ShIngredient(int id, string description, float price, string locationTop, string locationBottom, string locationChoc, int categoryId, string name, int quantity, int backendID, int frontEndID)
        {
            Id = id;
            Description = description;
            Price = price;
            LocationTop = locationTop;
            LocationBottom = locationBottom;
            LocationChoc = locationChoc;
            CategoryId = categoryId;
            Name = name;
            Quantity = quantity;
            BackendID = backendID;
            FrontEndID = frontEndID;
        }

        public ShIngredient(string description, float price, string locationTop, string locationBottom, string locationChoc, int categoryId, string name, int quantity, int backendID, int frontEndID)
        {
            Description = description;
            Price = price;
            LocationTop = locationTop;
            LocationBottom = locationBottom;
            LocationChoc = locationChoc;
            CategoryId = categoryId;
            Name = name;
            Quantity = quantity;
            BackendID = backendID;
            FrontEndID = frontEndID;
        }
    }
}
