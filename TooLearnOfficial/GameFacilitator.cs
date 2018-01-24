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

    public partial class GameFacilitator : Form
    {
        // Set Buffer size for the data being sent and recieved
        private const int buffer_size = 2048;
        // Set Buffer as holder of data being sent and received
        private byte[] buffer = new byte[buffer_size];
        // Set the TCPListeneer on port 13000;
        public static string hostIP;
        private TcpListener listener;
        // Set a list of client sockets
        private Dictionary<string, TcpClient> clientSockets = new Dictionary<string, TcpClient>();

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        string i;
        int time;
        public GameFacilitator()
        {
            InitializeComponent();
            load_server();
            listener = new TcpListener(IPAddress.Parse(hostIP), 13000);
            listener.Start(100);
            try
            {
                //Accept the connection
                //This method creates the accepted socket
                listener.BeginAcceptTcpClient(DoAcceptSocketCallback, listener);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void DoAcceptSocketCallback(IAsyncResult ar)
        {
            try
            {
                // Get the listener that handles the client request
                TcpListener listener = (TcpListener)ar.AsyncState;

                //End operation and display the received data on the screen
                TcpClient clientSocket = listener.EndAcceptTcpClient(ar);

                //Add client to client list
                clientSockets.Add(clientSocket.Client.RemoteEndPoint.ToString(), clientSocket);

                //Send a confirmation message to client
                Send("", clientSocket);

                //Acccept another TCPClient connection
                listener.BeginAcceptTcpClient(DoAcceptSocketCallback, listener);

                //Begin recieving data from the client socket
                Receive(clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Send(string text, TcpClient client)
        {
            try
            {
                //Set a NetworkStream for sending data
                NetworkStream stream = client.GetStream();
                //Store the message into the buffer
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes(text);
                //Begin writing into the stream bufer for sending
                stream.BeginWrite(buffer, 0, buffer.Length, BeginSendCallback, stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void BeginSendCallback(IAsyncResult ar)
        {
            //Get the current asynchronous state of the stream
            NetworkStream stream = (NetworkStream)ar.AsyncState;
            //End or complete the sending of stream buffer
            stream.EndWrite(ar);
        }


        private void Receive(TcpClient clientSocket)
        {
            try
            {
                clientSocket.Client.BeginReceive(buffer, 0, buffer_size, SocketFlags.None,
                    new AsyncCallback(BeginReceiveCallback), clientSocket);
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
                //Get the client socket
                TcpClient clientSocket = (TcpClient)ar.AsyncState;
                //Get the received bytes from the client
                int received = clientSocket.Client.EndReceive(ar);
                // Get the string value of the received buffer
                string message = System.Text.Encoding.ASCII.GetString(buffer, 0, received);

                //Check if a disconenct flag was received
                if (!message.Contains("DISCONNECT"))
                {
                    //Begin receiving data from the client socket
                    Receive(clientSocket);
                    //Send a confirmation message to the client
                    Send("You sent " + message, clientSocket);
                }
                else
                {
                    clientSockets.Remove(clientSocket.Client.RemoteEndPoint.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SendToAllClients(string message)
        {
            foreach (KeyValuePair<string, TcpClient> client in clientSockets)
            {
                Send(message, client.Value);
            }
        }

        void load_server()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName()); //get my IP
            foreach (var ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {

                    hostIP = ip.ToString();
                }
            }
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
            catch (Exception)
            {
                s = "";
            }
            con.Close();
            return s;

        }

        private void GameFacilitator_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            i = (ScalarReturn("Select min(quiz_id) from QuestionAnswers"));

            LabelTimer.Text = ScalarReturn("select QA_time_limit from QuestionAnswers where quiz_id='" + i + "'");

           

            time = Convert.ToInt32(LabelTimer.Text);


            bunifuCircleProgressbar1.Value = time;

         
                timer1.Start();
                bunifuCircleProgressbar1.Value -= 1;

            if (bunifuCircleProgressbar1.Value == 0)
            {
                i = i + 1;
                LabelQuestion.Text = ScalarReturn("select question from QuestionAnswers where quiz_id='" + i + "'");


                timer1.Stop();
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
