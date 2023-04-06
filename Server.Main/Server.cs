using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Main
{
    public class Server
    {
        private Socket socket;
        private List<KlijentHandler> clients = new List<KlijentHandler>();


        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(endpoint);
                socket.Listen(5);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSocket = socket.Accept();
                    KlijentHandler client = new KlijentHandler(klijentskiSocket);
                    clients.Add(client);
                    client.OdjavljenKlijent += Handler_OdjavljenKlijent;
                    Thread nitKlijenta = new Thread(client.HandleRequests);
                    nitKlijenta.IsBackground = false;
                    nitKlijenta.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        public void Handler_OdjavljenKlijent(object sender, EventArgs args) 
        {
            clients.Remove((KlijentHandler)sender); 
        }

        public void Stop() 
        {
            socket.Close(); 
            foreach (KlijentHandler handler in clients.ToList()) 
            {
                handler.CloseSocket(); 
            }
        }
    }
}
