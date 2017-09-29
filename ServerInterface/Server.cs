using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ServerInterface
{
    public class Server
    {
                 
        protected ArrayList _clientsList = new ArrayList();
        protected ArrayList _loggedIn = new ArrayList();
        protected TcpListener _tcpListener;
        private static bool _serverOn;

        private ThreadStart connectionMonitorTS;
        private Thread connectionMonitorThread;

        public void StartServer(int port)
        {
            _serverOn = true;
            _tcpListener = new TcpListener(IPAddress.Any, port);
            connectionMonitorTS = connection_monitor;
            connectionMonitorThread = new Thread(connectionMonitorTS);
            connectionMonitorThread.Start();
        }

        public void StopServer()
        {
            _tcpListener.Stop();
            _serverOn = false;
            connectionMonitorThread.Join();
            clear_clients();
        }

        public static bool ServerStatus()
        {
            return _serverOn;
        }


        protected void AddClient(TcpClient client)
        {
            _clientsList.Add(client);
        }

        protected void RemoveClient(TcpClient client)
        {               
            _clientsList.Remove(client);
            client.Close();
        }

        protected void RemoveClientAddToLoggedIn(TcpClient client)
        {
            _clientsList.Remove(client);
            _loggedIn.Add(client);
        }

        protected void RemoveLoggedInClient(TcpClient client)
        {
            _loggedIn.Remove(client);
            client.Close();
        }


        private void clear_clients()
        {
            if (_clientsList.Count > 0)
            {
                foreach (TcpClient client in _clientsList)
                {
                    RemoveClient(client);
                }
            }
        }

        private void connection_monitor()
        {

            while (_serverOn)
            {
                if (_clientsList.Count > 0)
                {
                    foreach (TcpClient client in _clientsList)
                    {

                        if (!client.Connected)
                            RemoveClient(client);
                        else
                        {
                            var stream = client.GetStream();
                            if (!stream.CanRead)
                            {
                                RemoveClient(client);
                            }
                        }
                    }
                }
            }
            
        }
        
                
    }
}