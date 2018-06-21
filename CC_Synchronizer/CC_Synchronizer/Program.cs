using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BackendDataHandler;
using CC_Synchronizer.AppService;
using CC_Synchronizer.FrontendService;
using SharedLibrary.Models;
using RESTFrontendService;

namespace CC_Synchronizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insert Product Test -- there be dragons!
            //BackendDataHandling BDH = new BackendDataHandling();
            //Product testproduct = new Product("Test3", "TestBeschreibung", "TestCategory", "Y", 33, new byte[100], "image//jpg", "shirt.jpg", new DateTime(), "Sweet", 44, new DateTime(), new DateTime(), null, null);
            //BDH.AddProduct(testproduct);
            /* Update Product Test 
            BackendDataHandling BHD = new BackendDataHandling();
            bool temp;
            temp = BHD.UpdateProductFID(5, 56);
            */
            Console.WriteLine("Chocolate Costumizer Synchronizer\nPress Enter to end the application.\n");

            ServiceHost frontendServiceHost = new ServiceHost(typeof(RestServiceImpl));
            Task.Factory.StartNew(frontendServiceHost.Open);
            Console.WriteLine("Frontend Service Host startet");

            AppServer appServer = new AppServer();
            //FrontendHost feHost = new FrontendHost();
            Console.ReadLine();
        }
    }
}
