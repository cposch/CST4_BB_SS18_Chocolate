﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendServiceProvider.DataModels
{
    public class DMRecipe
    {
        // only Oracle Backend values. table name = RECIEPE
        // how many values do we need?
        public Guid RecipeID { get; set; }
        public string ReciepeDescription { get; set; }

        // add constructor
    }
}
