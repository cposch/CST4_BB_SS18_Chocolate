using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Recipe
    {

        public decimal RID { get; set; }
        public decimal ProductID { get; set; }
        public string Description { get; set; }
        public decimal? FrontendID { get; set; }
        public decimal? ManufacturerID { get; set; }
        public DateTime? Last_Updated { get; set; }
        public string Last_Updated_By { get; set; }

        public Recipe(decimal rID, decimal productID, string description, decimal? frontendID, decimal? manufacturerID, DateTime? last_Updated, string last_Updated_By)
        {
            RID = rID;
            ProductID = productID;
            Description = description;
            FrontendID = frontendID;
            ManufacturerID = manufacturerID;
            Last_Updated = last_Updated;
            Last_Updated_By = last_Updated_By;
        }

        public Recipe()
        {
        }
    }
}
