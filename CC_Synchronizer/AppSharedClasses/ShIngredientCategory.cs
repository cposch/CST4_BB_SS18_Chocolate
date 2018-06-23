using System;

namespace AppSharedClasses
{
    public class ShIngredientCategory
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? BackendID { get; set; }
        public int? FrontEndID { get; set; }
        public DateTime? Lastmodified { get; set; }

        public ShIngredientCategory() { }

        public ShIngredientCategory(int? id, string name, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            Id = id;
            Name = name;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }

        public ShIngredientCategory(string name, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            Name = name;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }
    }
}
