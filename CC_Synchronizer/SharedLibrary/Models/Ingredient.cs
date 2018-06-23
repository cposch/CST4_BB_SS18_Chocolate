using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Ingredient
    {
        public decimal IID { get; set; }
        public decimal Price { get; set; }
        public String Filename { get; set; }
        public String MIMETYPE { get; set; }
        public byte[] Ingredient_Image { get; set; }
        public string Description { get; set; }
        public string Location_Top { get; set; }
        public string Location_Bottom { get; set; }
        public string Location_Choc { get; set; }
        public decimal CategoryId { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Image_Last_Update { get; set; }
        public decimal? FrontendID { get; set; }
        public decimal? ManufacturerID { get; set; }

        public Ingredient()
        {
        }

        public Ingredient(decimal iID, decimal price, string filename, string mIMETYPE, byte[] ingredient_Image, string description, string location_Top, string location_Bottom, string location_Choc, decimal categoryId, string name, int? quantity, DateTime? image_Last_Update, decimal? frontendID, decimal? manufacturerID)
        {
            IID = iID;
            Price = price;
            Filename = filename;
            MIMETYPE = mIMETYPE;
            Ingredient_Image = ingredient_Image;
            Description = description;
            Location_Top = location_Top;
            Location_Bottom = location_Bottom;
            Location_Choc = location_Choc;
            CategoryId = categoryId;
            Name = name;
            Quantity = quantity;
            Image_Last_Update = image_Last_Update;
            FrontendID = frontendID;
            ManufacturerID = manufacturerID;
        }
    }
}
