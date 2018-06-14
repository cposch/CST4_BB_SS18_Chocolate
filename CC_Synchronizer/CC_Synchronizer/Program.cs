using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendDataHandler;
using CC_Synchronizer.AppService;
using CC_Synchronizer.FrontendService;
using SharedLibrary.Models;

namespace CC_Synchronizer
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Insert Product Test -- there be dragons!
            BackendDataHandling BDH = new BackendDataHandling();
            Product testproduct = new Product(98, "Test2", "TestBeschreibung", "TestCategory", "Y", 33, new byte[100], "image//jpg", "shirt.jpg", new DateTime(), "Sweet", 44, new DateTime(), new DateTime());
            BDH.AddProduct(testproduct);*/
            Console.WriteLine("Chocolate Costumizer Syncronizer\n\nPress any key to end.");
            Console.ReadLine();

            //AppServer appServer = new AppServer();

            //FrontendHost feHost = new FrontendHost();
        }
    }
}
