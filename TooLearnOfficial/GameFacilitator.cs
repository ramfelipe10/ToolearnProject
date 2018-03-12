﻿using System;
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
using WMPLib;
using System.IO;



namespace TooLearnOfficial

{

    public partial class GameFacilitator : Form
    {

       

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        // Set Buffer size for the data being sent and recieved
        private const int buffer_size = 2048;
        // Set Buffer as holder of data being sent and received
        private byte[] buffer = new byte[buffer_size];
        // Set the TCPListeneer on port 13000;
        public static string hostIP;
       
        // Set a list of client sockets
        private Dictionary<string, TcpClient> clientSockets = LobbyFacilitator.clientSockets;


      

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        // string i;
        // int time;


        int counter = 0;
        int QuizID = QuizBank.QUIZID;
        int NoOfITems;

        string time;
        string convertedtime;
        int timerstamp;
        

        DataTable dt = new DataTable();


        public GameFacilitator()
        {
            InitializeComponent();            
            load_server();
            load_QA();
            load_game(counter);
            string Music = GameSettings.Music;          
            player.URL = Music;

           

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



        private void SendImage(byte[] text, TcpClient client)
        {
            try
            {



                Bitmap bmp = new Bitmap(dt.Rows[counter][6].ToString());
                MemoryStream ms = new MemoryStream();
                // Save to memory using the Jpeg format
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                // read to end
                byte[] bmpBytes = ms.GetBuffer();
                bmp.Dispose();
                ms.Close();

                //Set a NetworkStream for sending data
                NetworkStream stream = client.GetStream();
                //Store the message into the buffer
              
                //Begin writing into the stream bufer for sending
                stream.BeginWrite(bmpBytes, 0, bmpBytes.Length, BeginSendCallback, stream);



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
                  //  Send("You sent " + message, clientSocket);
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


        private void SendToAllClientsImage(byte[] message)
        {


            foreach (KeyValuePair<string, TcpClient> client in clientSockets)
            {
                SendImage(message, client.Value);
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

        

        private void GameFacilitator_Load(object sender, EventArgs e) // dae nagana ang load
        {

            
            player.controls.play();

           




        }

        private void load_QA()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select question,answer_a,answer_b,answer_c,answer_d,correct_answer,image,QA_time_limit,points,game_type,item_format from QuestionAnswers where quiz_id= '" + QuizID + "'", con);
            adapt.Fill(dt);
            NoOfITems = dt.Rows.Count;//6 rows
        }

        private void load_game(int counter)
        {

            string QuizContent = dt.Rows[counter][0].ToString() + Environment.NewLine + dt.Rows[counter][1].ToString() + Environment.NewLine + dt.Rows[counter][2].ToString() + Environment.NewLine + dt.Rows[counter][3].ToString() + Environment.NewLine + dt.Rows[counter][4].ToString() + Environment.NewLine + dt.Rows[counter][5].ToString() + Environment.NewLine + dt.Rows[counter][6].ToString() + Environment.NewLine + dt.Rows[counter][7].ToString() + Environment.NewLine + dt.Rows[counter][8].ToString() + Environment.NewLine + dt.Rows[counter][9].ToString() + Environment.NewLine + dt.Rows[counter][10].ToString();

            SendToAllClients(QuizContent);


            time = dt.Rows[counter][7].ToString();

            string str = time;
            int index = str.IndexOf('(');

            if (index >= 0)
            {
                convertedtime = str.Substring(0, index);



            }
            else
            {

                convertedtime = str;
            }


            timerstamp = Convert.ToInt32(convertedtime);
            TimerLabel.Text = timerstamp.ToString();






            if (NoOfITems == 0)
            {
                bunifuFlatButton1.Visible = false;
                bunifuFlatButton2.Visible = true;
            }

            else
            {
                bunifuFlatButton1.Visible = true;


                LabelQuestion.Text = dt.Rows[counter][0].ToString();         
               


                if (dt.Rows[counter][6].ToString() != null || dt.Rows[counter][6].ToString() != "")
                {
                    
                    ItemPicture.ImageLocation = dt.Rows[counter][6].ToString();
                    ItemPicture.Enabled = true;


                    /*  Size size = new Size(248, 119);
                      ItemPicture.Size=size;

                      Size Panelsize = new Size(761, 134);
                      panel1.Size = Panelsize; */                  

                }

                else
                {
                    ItemPicture.Enabled = false;


                    /*   Size size = new Size(248, 24);
                       ItemPicture.Size = size;


                       Size Panelsize = new Size(761, 215);
                       panel1.Size = Panelsize;  */                   
                }

                              

              


            }


            

           
           

        }
        
    /*    private void timer1_Tick(object sender, EventArgs e)
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
        } */
        

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            

       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Visible = false;
            bunifuImageButton2.Visible = true;
            //player.controls.play();
            player.settings.mute = true;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuImageButton2.Visible = false;
            bunifuImageButton1.Visible = true;
            // player.controls.stop();
            player.settings.mute = false;         

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          

            counter++;
            NoOfITems--;
            load_game(counter);
            timer1.Start();// For Next Question
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {




           
            

             
            timerstamp--;
            if (timerstamp == 0)
            {
                timer1.Stop();
                bunifuCustomLabel1.Visible = true;
                TimerLabel.Visible = false;
            }
            else
            {
                TimerLabel.Text = timerstamp.ToString();
                bunifuCustomLabel1.Visible = false;
                TimerLabel.Visible = true;
            }
        }

        private void GameFacilitator_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.controls.stop();
        }
    }
}
