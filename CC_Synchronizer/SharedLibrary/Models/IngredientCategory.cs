using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class IngredientCategory
    {
        public decimal ICID { get; set; }
        public string Name { get; set; }
        public decimal? FrontendID { get; set; }
        public decimal? ManufacturerID { get; set; }

        public IngredientCategory()
        {
        }

        public IngredientCategory(decimal iCID, string name, decimal? frontendID, decimal? manufacturerID)
        {
            ICID = iCID;
            Name = name;
            FrontendID = frontendID;
            ManufacturerID = manufacturerID;
        }
    }
}
