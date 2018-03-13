using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace TooLearnOfficial.User_Control
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }
        public static string GetLocalIPAddress()  //get local ip address
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void buttonIPAddress_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetLocalIPAddress());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GameCode GC = new GameCode();
            //GC.Show();
        }
    }
}
