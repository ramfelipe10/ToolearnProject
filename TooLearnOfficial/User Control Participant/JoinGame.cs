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
            var host = Dns.GetHostEntry(Dns.GetHostName()); //get my IP
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    bunifuMetroTextbox1.Text = ip.ToString();
                }
            }
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
            try
            {
                IPAddress localAddr = IPAddress.Parse(bunifuMetroTextbox1.Text);
                Int32 port = 13000;
                clientSocket.Connect(localAddr, port);
                LobbyParticipant lp = new LobbyParticipant();
                lp.Show();
            }
            catch
            {
                MessageBox.Show("No Server yet");
            }
            
        }
    }
}
