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
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        private TcpClient _client = new TcpClient();
        private const int _buffer_size = 2048;
        private byte[] _buffer = new byte[_buffer_size];
        private string _IPAddress = "127.0.0.1";
        private const int _PORT = 13000;

        public LobbyParticipant()
        {
            InitializeComponent();
            SqlDataAdapter sda = new SqlDataAdapter("Select fullname from participant Where participant_id='" + Program.par_id + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //txtProfile.Text = ToString(Program.par_id); ang gusto ko mangyare si current participant fullname maglaog sa textbox na iyan
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LobbyParticipant_Load(object sender, EventArgs e)
        {
            
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

        private void btnReady_Click(object sender, EventArgs e)
        {
            Send(txtProfile.Text);
        }

        private void Send(string message)
        {
            try
            {
                //Translate the message into its byte form
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes(message + "is ready!");

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
    }
}
