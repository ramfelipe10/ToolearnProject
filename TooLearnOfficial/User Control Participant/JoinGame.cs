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

namespace TooLearnOfficial.User_Control_Participant
{
    public partial class JoinGame : UserControl
    {
        TcpClient clientSocket = new TcpClient();
        public JoinGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnterGame_Click(object sender, EventArgs e)
        {
            
            IPAddress localAddr = IPAddress.Parse("192.168.254.102");
            Int32 port = 8080;
            clientSocket.Connect(localAddr, port);
            LobbyParticipant lp = new LobbyParticipant();
            lp.Show();
        }
    }
}
