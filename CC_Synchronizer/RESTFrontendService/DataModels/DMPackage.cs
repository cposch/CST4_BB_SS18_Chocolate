using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTFrontendService.DataModels
{
    public class DMPackage
    {
        // only Oracle Backend values. table name = PACKAGE

        public Guid PackageID { get; set; }
        public string PackageName { get; set; }
        public float PackagePrice { get; set; }

        // constructor
        public DMPackage()
        {

        }

        public DMPackage(Guid packageID, string packageName, float packagePrice)
        {
            PackageID = packageID;
            PackageName = packageName;
            PackagePrice = packagePrice;
        }
    }
}