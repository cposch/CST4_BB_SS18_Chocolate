using System;

namespace AppSharedClasses
{
    public class ShRecipe
    {
        public int? Id { get; set; }
        public int? ProductId { get; set; }
        public string Description { get; set; }
        public int? BackendID { get; set; }
        public int? FrontEndID { get; set; }
        public DateTime? Lastmodified { get; set; }

        public ShRecipe() { }

        public ShRecipe(int? id, int? productId, string description, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            Id = id;
            ProductId = productId;
            Description = description;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }

        public ShRecipe(int? productId, string description, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            ProductId = productId;
            Description = description;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }
    }
}
