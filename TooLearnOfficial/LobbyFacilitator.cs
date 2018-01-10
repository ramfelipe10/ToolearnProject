using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace TooLearnOfficial
{
    public partial class LobbyFacilitator : Form
    {
        public LobbyFacilitator()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); //get my IP
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    textBoxIPAddress.Text = address.ToString();
                }
            }

            IPAddress localAddr = IPAddress.Parse(textBoxIPAddress.Text);
            Int32 port = 8080;
            TcpListener serverSocket = new TcpListener(localAddr, port);
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;
            /*
            while (true)
            {
                counter += 1;
                countParticipant.Text += 1; //to be change... count participant who entered the lobby
                clientSocket = serverSocket.AcceptTcpClient();
                handleClient client = new handleClient();
                client.startClient(clientSocket, Convert.ToString(counter));
            }
            */
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

            }
        }

        private void LobbyFacilitator_Load(object sender, EventArgs e)
        {

        }

    }
}
