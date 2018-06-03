using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendServiceProvider.DataModels
{
    public class DMPackage
    {
        // only Oracle Backend values. table name = PACKAGE
        // ToDo: add values from PHP myAdmin database
        // how many values do we need?
        public int ProductID { get; set; }
        public string PackageName { get; set; }
        public float PackagePrice { get; set; }

        // add constructor
    }
}
