using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace TooLearnOfficial.User_Control
{
    public partial class MyQuiz : UserControl
    {
        public MyQuiz()
        {
            InitializeComponent();
            var host = Dns.GetHostEntry(Dns.GetHostName()); //get my IP
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    textBoxIPAddress.Text = ip.ToString();
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            LobbyFacilitator lf = new LobbyFacilitator();
            lf.Show();
            IPAddress localAddr = IPAddress.Parse(textBoxIPAddress.Text);//("192.168.56.1");
            Int32 port = 13000;
            TcpListener serverSocket = new TcpListener(localAddr, port);
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;
            serverSocket.Start();
            

            while (true)
            {
                counter += 1;
                //label2.Text = counter + " # of participant ";
                clientSocket = serverSocket.AcceptTcpClient();
                handleClient client = new handleClient();
                client.startClient(clientSocket, Convert.ToString(counter));
            }
            clientSocket.Close();
            serverSocket.Stop();

        }
        public class handleClient //function that handle each client request seperately (multi client)
        {
            TcpClient clientSocket;
            string clientNo;
            public void startClient(TcpClient inClientSocket, string clientLineNo)
            {
                this.clientSocket = inClientSocket;
                this.clientNo = clientLineNo;
                Thread ctThread = new Thread(joinLobby);
                ctThread.Start();
            }
            private void joinLobby() //participant join the lobby of facilitator
            {
                int requestCount = 0;
                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;
                Byte[] sendBytes = null;
                string serverResponse = null;
                string rCount = null;
                requestCount = 0;
                while ((true))
                {
                    try
                    {
                        requestCount = requestCount + 1;
                        NetworkStream networkStream = clientSocket.GetStream();
                        networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                        dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                        rCount = Convert.ToString(requestCount);
                        serverResponse = clientNo + rCount;
                        sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                        networkStream.Write(sendBytes, 0, sendBytes.Length);
                        networkStream.Flush();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
