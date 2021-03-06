﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Rule
    {
        public decimal RID { get; set; }
        public decimal ProductID { get; set; }
        public decimal? FrontendID { get; set; }
        public decimal? ManufacturerID { get; set; }

        public Rule()
        {
        }

        public Rule(decimal rID, decimal productID, decimal? frontendID, decimal? manufacturerID)
        {
            RID = rID;
            ProductID = productID;
            FrontendID = frontendID;
            ManufacturerID = manufacturerID;
        }
    }
}
