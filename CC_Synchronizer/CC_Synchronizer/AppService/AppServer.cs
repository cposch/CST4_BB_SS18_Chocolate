using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CC_Synchronizer.AppService
{
    public class AppServer
    {
        Socket serverSocket;
        List<ClientHandler> clients = new List<ClientHandler>();

        public AppServer()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 8181));
            serverSocket.Listen(100);
            Console.WriteLine("App Server started");
            Task.Factory.StartNew(StartAccepting);
        }

        private void StartAccepting()
        {
            while (true)
                clients.Add(new ClientHandler(serverSocket.Accept()));
        }
    }
}
