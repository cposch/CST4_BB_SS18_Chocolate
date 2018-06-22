using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class ReciepeIngredients
    {
        public decimal RIID { get; set; }
        public decimal ReciepeID { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal IngredientID { get; set; }
        public decimal? FrontendID { get; set; }
        public decimal? ManufacturerID { get; set; }

        public ReciepeIngredients()
        {
        }

        public ReciepeIngredients(decimal rIID, decimal reciepeID, decimal quantity, decimal unitPrice, decimal ingredientID, decimal? frontendID, decimal? manufacturerID)
        {
            RIID = rIID;
            ReciepeID = reciepeID;
            Quantity = quantity;
            UnitPrice = unitPrice;
            IngredientID = ingredientID;
            FrontendID = frontendID;
            ManufacturerID = manufacturerID;
        }
    }
}
