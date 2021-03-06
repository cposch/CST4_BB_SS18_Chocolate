﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTFrontendService.DataModels
{
    public class DMRecipe
    {
        // only Oracle Backend values. table name = RECIEPE

        public Guid RecipeID { get; set; }
        public string ReciepeDescription { get; set; }

        // constructor
        public DMRecipe()
        {

        }

        public DMRecipe(Guid recipeID, string reciepeDescription)
        {
            RecipeID = recipeID;
            ReciepeDescription = reciepeDescription;
        }
    }
}