using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class RuleCategory
    {
        public decimal RCID { get; set; }
        public decimal ProductID { get; set; }
        public decimal CategoryID { get; set; }
        public decimal? FrontendID { get; set; }
        public decimal? ManufacturerID { get; set; }

        public RuleCategory()
        {
        }

        public RuleCategory(decimal rCID, decimal productID, decimal categoryID, decimal? frontendID, decimal? manufacturerID)
        {
            RCID = rCID;
            ProductID = productID;
            CategoryID = categoryID;
            FrontendID = frontendID;
            ManufacturerID = manufacturerID;
        }
    }
}
