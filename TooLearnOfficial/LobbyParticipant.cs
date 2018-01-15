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
    public partial class LobbyParticipant : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream;
        public LobbyParticipant()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LobbyParticipant_Load(object sender, EventArgs e)
        {
            /*
            IPAddress localAddr = IPAddress.Parse("192.168.254.102");
            Int32 port = 8080;
            clientSocket.Connect(localAddr, port);
            label2.Text = "Client Socket Program - Server Connected ...";
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
