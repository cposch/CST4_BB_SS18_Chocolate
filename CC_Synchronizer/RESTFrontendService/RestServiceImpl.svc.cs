using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTFrontendService.DataModels;

namespace RESTFrontendService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestServiceImpl.svc or RestServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class RestServiceImpl : IRestServiceImpl
    {
        /*public string Data(string id)
        {
            return "You requested id: " + id;
        }*/
        public DMProduct Data()
        {
            return new DMProduct(Guid.Parse("09bdd169-12b0-4167-a201-f9494a72e50b"), "chocolate cake", "yummi", 130, new DMRecipe(Guid.Parse("09bdd169-12b0-4167-a201-f9494a72e50b"), "Do this and that"));
        }
    }
}
