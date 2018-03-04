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
using System.Data.SqlClient;

namespace TooLearnOfficial.User_Control_Participant
{
    public partial class JoinQuiz : UserControl
    {

        private TcpClient _client = new TcpClient();
        private const int _buffer_size = 2048;
        private byte[] _buffer = new byte[_buffer_size];
        private string _IPAddress = "127.0.0.1";
        private const int _PORT = 13000;


        public JoinQuiz()
        {
            InitializeComponent();
        }



        //Alternative
        static class Helper
        {
            public static string ConnectionString
            {
                get
                {
                    string str = "Data Source='" + Program.source + "' ; Initial Catalog='" + Program.db + "'; User ID='" + Program.id + "';Password='" + Program.password + "'";
                    return str;
                }
            }
        }
        //Alternative  



      

           


            private void buttonEnterGame_Click(object sender, EventArgs e)
        {

            //Alternative
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Helper.ConnectionString;

            //Alternative-End 

         SqlDataAdapter sda = new SqlDataAdapter("Select Game_Pin From Pincode", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                Dialogue.Show("No Host Server Detected! Please Wait for the Host to Start.", "", "Ok", "Cancel");

            }

            else
            {

                string code = dt.Rows[0][0].ToString();


                if (code == bunifuMetroTextbox1.Text)
                {   

                    LobbyParticipant lobby = new LobbyParticipant();
                    lobby.ShowDialog();
                }

                else if (bunifuMetroTextbox1.Text == null || bunifuMetroTextbox1.Text == "")
                {
                    bunifuCustomLabel1.Text = "* Please Enter Code";

                }
                else
                {
                    bunifuCustomLabel1.Text = "* Code is Invalid!";

                }


            }//end else */
        }




        public void StartConnect()
        {
            try
            {
                if (_client.Connected == false)
                {
                    _client = new TcpClient();
                }
                _client.NoDelay = true;

                //Begin connecting to server
                _client.BeginConnect(IPAddress.Parse(_IPAddress), _PORT, BeginConnectCallBack, _client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BeginConnectCallBack(IAsyncResult ar)
        {
            try
            {
                TcpClient _client = (TcpClient)ar.AsyncState;
                _client.EndConnect(ar);
                Receive();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Receive()
        {
            try
            {
                _client.Client.BeginReceive(_buffer, 0, _buffer_size, SocketFlags.None, BeginReceiveCallback, _client
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BeginReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // get the client socket
                TcpClient client = (TcpClient)ar.AsyncState;
                int bytesRead = client.Client.EndReceive(ar);

                string message = System.Text.Encoding.ASCII.GetString(_buffer, 0, bytesRead);

                if (message.Contains("DISCONNECT"))
                {
                    client.Client.Shutdown(SocketShutdown.Both);
                    client.Client.Close();
                }
                else
                {

                    Receive();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
