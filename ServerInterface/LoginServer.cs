using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace ServerInterface
{
    public class LoginServer : Server
    {

        
        public void StartConnectionListening(int port)
        {
             StartServer(port);
            _tcpListener.BeginAcceptTcpClient(OnConnect, _tcpListener);
        }


        private void OnConnect(IAsyncResult ar)
        {
            var connected = _tcpListener.EndAcceptTcpClient(ar);
            AddClient(connected);

            void ClientLoginStart() => ClientLoginThread(connected);
            var clientLoginThread = new Thread(ClientLoginStart);
            clientLoginThread.Start();

            _tcpListener.BeginAcceptTcpClient(OnConnect, _tcpListener);
        }

        private void ClientLoginThread(TcpClient client)
        {
            var stream = client.GetStream();
            var clientReader = new StreamReader(stream);
            var clientWriter = new StreamWriter(stream);

            while (stream.CanRead)
            {
                var readLine = clientReader.ReadLine();
                if (readLine == null) continue;
                
                var loginData = readLine.Split(',');
                if (loginData.Length > 2 || loginData.Length == 0 || loginData.Length == 1)
                {
                    clientWriter.WriteLine(Err.Codes.FailedLogin.ToString());
                    clientWriter.Flush();
                }
                else
                {
                    bool valid_login = validate_login(loginData, Serv.L_PATH);
                }
            }
        }

        private bool validate_login(string[] login_data, string directory_path)
        {
            bool isValid = false;
            var data_path = directory_path + login_data[0];

            if (!File.Exists(data_path))
            {
                return false;
            }

            var user_file = new StreamReader(data_path + "//login");

            if (user_file.ReadLine() == login_data[1])
                isValid = true;
           
            

            return isValid;
        }
    }
}
