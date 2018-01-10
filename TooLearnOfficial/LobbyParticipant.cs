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
            
           IPAddress localAddr = IPAddress.Parse(textBoxfaciIPAddress.Text);
           Int32 port = int.Parse(textBoxFaciPort.Text);
           clientSocket.Connect(localAddr, port);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LobbyParticipant_Load(object sender, EventArgs e)
        {

        }
    }
}
