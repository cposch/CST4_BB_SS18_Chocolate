using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendServiceProvider.DataModels
{
    public class DMRecipe
    {
        // only Oracle Backend values. table name = RECIEPE
        // ToDo: add values from PHP myAdmin database
        // how many values do we need?
        public int ProductID { get; set; }
        public string ReciepeDescription { get; set; }

        // add constructor
    }
}
