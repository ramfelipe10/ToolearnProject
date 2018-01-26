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
using System.Threading;

namespace TooLearnOfficial
{
    public partial class GameParticipant : Form
    {
        private TcpClient _client = new TcpClient();
        private const int _buffer_size = 2048;
        private byte[] _buffer = new byte[_buffer_size];
        private string _IPAddress = Program.serverIP;
        private const int _PORT = 13000;

       

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        // string i;
        //  string correct;
        public GameParticipant()
        {
            InitializeComponent();
            StartConnect();

        }
        private void Send(string message)
        {
            try
            {
                //Translate the message into its byte form
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes(message + " is ready!");

                //Get a client stream for reading and writing
                NetworkStream stream = _client.GetStream();

                //Send the message to the connected server
                //stream.Write(buffer, 0, buffer.length);
                stream.BeginWrite(buffer, 0, buffer.Length, BeginWriteCallback, stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        /*                                   */

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




        /*                                             */
       

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

                string message = System.Text.Encoding.ASCII.GetString(_buffer, 0, bytesRead); //ini si may laman kang message

                
                
                

                if (message.Contains("DISCONNECT"))
                {


                    this.Close();
                    client.Client.Shutdown(SocketShutdown.Both);
                    client.Client.Close();
                }
                else
                {
                    ThreadHelper.lsbAddItem(this, listBox1, message);
                    ThreadHelper.lblAddLabel(this, lblArray0, message);
                    Receive();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BeginWriteCallback(IAsyncResult ar)
        {
            NetworkStream stream = (NetworkStream)ar.AsyncState;
            stream.EndWrite(ar);
        }

        private void GameParticipant_Load(object sender, EventArgs e)
        {

            /*   SqlDataAdapter sda = new SqlDataAdapter("Select min(quiz_id) from QuestionAnswers", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);

               i = Convert.ToInt32(dt.Rows[0][0].ToString());
   
            i = (ScalarReturn("Select min(quiz_id) from QuestionAnswers"));

            LabelTimer.Text = ScalarReturn("select QA_time_limit from QuestionAnswers where quiz_id='" + i + "'");
            lblArray0.Text =ScalarReturn ("select question from QuestionAnswers where quiz_id='"+ i + "'");
            bunifuFlatButton1.Text = ScalarReturn("select answer_a from QuestionAnswers where quiz_id='" + i + "'");
            bunifuFlatButton2.Text = ScalarReturn("select answer_b from QuestionAnswers where quiz_id='" + i + "'");
            bunifuFlatButton3.Text = ScalarReturn("select answer_c from QuestionAnswers where quiz_id='" + i + "'");
            bunifuFlatButton4.Text = ScalarReturn("select answer_d from QuestionAnswers where quiz_id='" + i + "'");
            correct = ScalarReturn("select correct_answer from QuestionAnswers where quiz_id='" + i + "'");  */
        }
        private string ScalarReturn(string q)
        {
            string s;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, con);

                s = cmd.ExecuteScalar().ToString();
            }
            catch(Exception)
            {
                s = "";
            }
            con.Close();
            return s;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send(textBox1.Text);
        }
    }
}
