using FrontendServiceProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FrontendHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(FrontendService));
            host.Open();
            Console.WriteLine("HOST HAS STARTED");
            Console.ReadLine();
        }
    }
}
