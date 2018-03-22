using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;

namespace TooLearnOfficial
{
    public partial class PublicJoin : Form
    {
        public static string NameFREE;
        int Time = 2;
        public PublicJoin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseUser CU = new ChooseUser();
            CU.Show();
        }

        private void buttonEnterGame_Click(object sender, EventArgs e)
        {

         


            string server = IPBox.Text;
            if (IPBox.Text == null || IPBox.Text == "")
            {


                Dialogue.Show("Enter Server IP", "", "Ok", "Cancel");


            }

            else
            {
                try
                {
                    IPHostEntry host = Dns.GetHostEntry(server);
                    foreach (IPAddress ip in host.AddressList)
                    {

                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        {
                            Program.serverIP = ip.ToString();
                            timer1.Start();

                        }

                      

                    }
                }//end try

                catch 
                {
                    Dialogue.Show("Connection Failed", "", "Ok", "Cancel");
                   
                }

               
            }        
                      

            
        
           

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            bunifuMetroTextbox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            bunifuImageButton6.Visible = false;
            label3.Visible = false;
            IPBox.Visible = false;
            label1.Visible = false;
            buttonEnterGame.Visible = false;
            IPBox.Text = "";
            Time--;
            if (Time == 0)
            {
                timer1.Stop();
                pictureBox1.Visible = false;                
                panel1.Visible = true;
                bunifuImageButton6.Visible = true;
                label3.Visible = true;
                IPBox.Visible = true;
                label1.Visible = true;
                buttonEnterGame.Visible = true;
                Time = 2;
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == null || bunifuMetroTextbox1.Text == "")
            {
                Dialogue.Show("Please Provide a Screen Name", "", "Ok", "Cancel");

            }

            else
            {

                NameFREE = bunifuMetroTextbox1.Text;
                this.Hide();
                LobbyParticipant con = new LobbyParticipant();
                con.Show();
            }
        }


    }
}
