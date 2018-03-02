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
using System.Data.SqlClient;

namespace TooLearnOfficial
{
    public partial class LobbyParticipant : Form
    {
        private TcpClient _client = new TcpClient();
        private const int _buffer_size = 2048;
        private byte[] _buffer = new byte[_buffer_size];
        private string _IPAddress = Program.serverIP;
        private const int _PORT = 13000;
        string name;

        public static string GameType = "";

        SqlConnection con = new SqlConnection("Data Source='" + Program.source + "' ; Initial Catalog='" + Program.db + "'; User ID='" + Program.id + "';Password='" + Program.password + "'");

        public LobbyParticipant()
        {
           InitializeComponent();
            StartConnect();
           
        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LobbyParticipant_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sql = new SqlDataAdapter("Select fullname from participant where participant_id='" +Program.par_id+ "'", con);
            DataTable dt = new DataTable();
            sql.Fill(dt);
           name= dt.Rows[0][0].ToString();

            Send(name);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Send(string message)
        {
            try
            {
                //Translate the message into its byte form
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes(message);

                //Get a client stream for reading and writing
                NetworkStream stream = _client.GetStream();

                //Send the message to the connected server
                //stream.Write(buffer, 0, buffer.length);
                stream.BeginWrite(buffer, 0, buffer.Length, BeginWriteCallback, stream);
            }
            catch (Exception ex)
            {
                ThreadHelper.lsbAddItem(this, lsbWait, ex.ToString());
            }
        }

        private void BeginWriteCallback(IAsyncResult ar)
        {
            NetworkStream stream = (NetworkStream)ar.AsyncState;
            stream.EndWrite(ar);
        }

        private void lsbWait_SelectedIndexChanged(object sender, EventArgs e) //listbox muna dae ko kapa ang DataGridView
        {

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
            
           
                // get the client socket
                TcpClient client = (TcpClient)ar.AsyncState;
                int bytesRead = client.Client.EndReceive(ar);

                string message = System.Text.Encoding.ASCII.GetString(_buffer, 0, bytesRead);

                Receive();

            if (message.Contains("GAMEQB"))
            {
                GameType = "QB";
                GameRules GR = new GameRules();
                GR.ShowDialog();
            }

            else if(message.Contains("GAMEPZ"))
            {
                GameType = "PZ";
                GameRules GR = new GameRules();
                GR.ShowDialog();
            }
               // string type = message;
                //  GameParticipant gf = new GameParticipant();
                //  gf.ShowDialog();
              //  if(type=="Game")
              //  {
                  //  GameType = "QB";
             //   }
             //   else if (message.Contains(" Picture Puzzle"))
            //    {
            //        GameType = "PZ";
             //   }

               

                //client.Client.Shutdown(SocketShutdown.Both);
                //client.Client.Close();
            

            else
            {
                ThreadHelper.lsbAddItem(this, lsbWait, message);
                Receive();

            }
            
             
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Send("DISCONNECT");
        }
    }
}
