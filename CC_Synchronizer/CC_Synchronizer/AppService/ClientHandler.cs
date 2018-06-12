using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CC_Synchronizer.AppService
{
    public class ClientHandler
    {
        Socket socket;
        byte[] buffer = new byte[1024];

        public ClientHandler(Socket socket)
        {
            this.socket = socket;

            Console.WriteLine("App Client connected from " + socket.RemoteEndPoint.ToString());
            Task.Factory.StartNew(Recieve);
        }

        private void Recieve()
        {
            int length = 0;
            string recievingString;

            length = socket.Receive(buffer);
            recievingString = Encoding.UTF8.GetString(buffer, 0, length);
            Console.WriteLine(recievingString);

            //ToDo: Try save XML data in classes 

            socket.Send(Encoding.UTF8.GetBytes(recievingString));
            Console.WriteLine("String returned");

            //ToDo: Splitting recievied string?

        }
    }
}
