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
using System.IO;

namespace TooLearnOfficial
{

    public partial class LobbyFacilitator : Form
    {
       
        private const int buffer_size = 2048;        
        private byte[] buffer = new byte[buffer_size];       
        private static string hostIP;
      
        public static TcpListener listener;

        public static Dictionary<string, TcpClient> clientSockets = new Dictionary<string, TcpClient>();// Tg set to Public ko para ma access sa ibang form
        public static string GameType;

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

     

        string gmode = SelectParticipant.participant.ToString();


        public LobbyFacilitator()
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
                lsbJoined.Items.Add(ex.ToString());
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
                
                
                //ThreadHelper.lsbAddItem(this, lsbJoined, "Client connected" + clientSocket.Client.RemoteEndPoint.ToString());

                //Send a confirmation message to client
          //     Send("CONFIRM", clientSocket);

                //Acccept another TCPClient connection
                listener.BeginAcceptTcpClient(DoAcceptSocketCallback, listener);

                //Begin recieving data from the client socket
                Receive(clientSocket);
            }
            catch (Exception ex)
            {
                ThreadHelper.lsbAddItem(this, lsbJoined, ex.ToString());
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
                ThreadHelper.lsbAddItem(this, lsbJoined, ex.ToString());

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
                ThreadHelper.lsbAddItem(this, lsbJoined, ex.ToString());
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
                if (message.Contains("SCORE"))
                {
                    //ThreadHelper.lsbAddItem(this, lsbJoined, message);

                    GameFacilitator GF = (GameFacilitator)Application.OpenForms["GameFacilitator"];
                    GF.updateScore(message.ToString());
                    // Send("You ("+message+ ") are now connected! Please Wait",clientSocket);


                    //Begin receiving data from the client socket
                    Receive(clientSocket);  
                }


                else if (message.Contains("IMAGE"))
                {

                    this.Invoke((MethodInvoker)(() => MessageBox.Show("DONE")));

                    Receive(clientSocket);

                }




                else if (message.Contains("DISCONNECT"))
                {
                    ThreadHelper.lsbAddItem(this, lsbJoined, clientSocket.Client.RemoteEndPoint.ToString() + " has disconnected.");
                    //send a disconnect flag to the client to complete disconnection
                    Send("DISCONNECT", clientSocket);
                    //remove the client socket from the client list
                    clientSockets.Remove(clientSocket.Client.RemoteEndPoint.ToString());

                }

               

                else
                {
                    ThreadHelper.lsbAddItem(this, lsbJoined, message);


                    // Send("You ("+message+ ") are now connected! Please Wait",clientSocket);


                    //Begin receiving data from the client socket
                    Receive(clientSocket);

                }
            }
            catch (Exception ex)
            {
                // ThreadHelper.lsbAddItem(this, lsbJoined, ex.ToString());
                ThreadHelper.lsbAddItem(this, lsbJoined,"Error Detected!,Please Close this Lobby and Reconnect.");
            }
        }

      

        private void LobbyFacilitator_Load(object sender, EventArgs e)
        {

            lsbJoined.Items.Add("Waiting for Participants.....");

            char[] letters = "q1we2rty3uio4pas5dfgh6jklz7x8cv9bnm0".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 9; i++) //i < # depends how long the password
            {
                randomString += letters[r.Next(0, 34)].ToString();
            }

            label3.Text = randomString;

            if (SelectParticipant.participant == "PUBLIC")
            {

                label3.Visible = false;
                label2.Visible = false;
            }

            else
            {
                label3.Visible = true;
                label2.Visible = true;
            }




            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Pincode(Game_Pin,Mode) Values('" + label3.Text + "','" + gmode + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

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

        private void SendToAllClients(string message)
        {
            foreach (KeyValuePair<string, TcpClient> client in clientSockets)
            {
                Send(message, client.Value);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int ID = QuizBank.QUIZID;           

            SqlDataAdapter adapt = new SqlDataAdapter("select game_type from quizzes where quiz_id= '" + ID + "'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            string Type = dt.Rows[0][0].ToString();

            if(Type=="Quiz Bee")
            {
                 GameType = "QB";
            }

            else
            {
               
                GameType = "PZ";
            }

            if (gmode == "IP")
            {

                SendToAllClients("GAMEIP" + "" + GameType + "");
            }

            else if (gmode == "GP")
            {

                SendToAllClients("GAMEGP" + "" + GameType + "");
            }

            else
            {
                SendToAllClients("GAMEFP" + "" + GameType + "");
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From Pincode", con);
            cmd.ExecuteNonQuery();
            con.Close();



           this.Hide();
            GameRulesFacilitator GRF = new GameRulesFacilitator();
            GRF.Show();
           

                   


        }


      

     
   

    private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            lsbJoined.Dispose();
            listener.Stop();

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From Pincode", con);
            cmd.ExecuteNonQuery();
            con.Close();


            this.Close();
        }

        private void LobbyFacilitator_FormClosing(object sender, FormClosingEventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From Pincode", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
