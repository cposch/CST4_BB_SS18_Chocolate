namespace AppSharedClasses
{
    public class AppIngredient
    {
        private int Id { get; set; }
        public float Price { get; set; }
        public byte LocationTop { get; set; }
        public byte LocationBottom { get; set; }
        public byte LocationChoc { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public AppIngredient() { }

        public AppIngredient(int id, float price, byte locationTop, byte locationBottom, byte locationChoc, int categoryId, string name, int quantity)
        {
            Id = id;
            Price = price;
            LocationTop = locationTop;
            LocationBottom = locationBottom;
            LocationChoc = locationChoc;
            CategoryId = categoryId;
            Name = name;
            Quantity = quantity;
        }
    }
}
