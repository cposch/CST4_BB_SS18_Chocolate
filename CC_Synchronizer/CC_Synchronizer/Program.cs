using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC_Synchronizer.AppService;
using CC_Synchronizer.FrontendService;

namespace CC_Synchronizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chocolate Costumizer Syncronizer\n\nPress any key to end.");
            //Console.ReadLine();

            AppServer appServer = new AppServer();
            Console.ReadLine();
            //FrontendHost feHost = new FrontendHost();
        }
    }
}
