using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendServiceProvider.DataModels
{
    public class DMProduct
    {
        // only Oracle Backend values. table name = DEMO_PRODUCT_INFO
        // ToDo: add values from PHP myAdmin database
        // how many values do we need?
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public long ProductPrice { get; set; }

        // add constructor



    }
}
