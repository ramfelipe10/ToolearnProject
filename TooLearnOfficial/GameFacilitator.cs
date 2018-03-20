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

        DataTable data;

        string music = GameSettings.IsMusic;
        string random = GameSettings.IsRandom;

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        // string i;
        // int time;
        string participant = SelectParticipant.participant.ToString();

        int counter = 0;
        int QuizID = QuizBank.QUIZID;
        int NoOfITems;

        string time;
        string convertedtime;
        int timerstamp;
        string ID = SelectClassroom.ID;

        DataTable dt = new DataTable();
       


        public GameFacilitator()
        {
            InitializeComponent();            
            load_server();
            load_QA();
            load_game(counter);
            string Music = GameSettings.Music;          
            player.URL = Music;

            SetDoubleBuffered(panel2);

        }



        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion



        public void updateScore(string Score)
        {

           
            string up = Score.ToString();

            // string name = up.Substring(8,up.Length-12);
            string name;
            int nameindex= up.LastIndexOf(',');
            name=up.Substring(8, nameindex-8);
            int index= up.LastIndexOf('(');
            string points = up.Substring(index + 1);
            points = points.Substring(0,points.Length-1);

                       
           ThreadHelper.lsbAddItem(this, listBox1, up);            
           this.Invoke((MethodInvoker)(() => updatescore(name,points)));

        }
        private void updatescore(string name,string points)
        {


            for (int i = 0; i < data.Rows.Count; i++)
            {

                try
                {
                    if (data.Rows[i][0].ToString() == name.ToString())
                    {
                        this.Invoke((MethodInvoker)(() => data.Rows[i][1] = points.ToString()));              
                        this.Invoke((MethodInvoker)(() => leaderboard()));
                        this.Invoke((MethodInvoker)(() => bunifuCustomDataGrid1.Update()));
                        this.Invoke((MethodInvoker)(() => bunifuCustomDataGrid1.Refresh()));


                    }
                  






                }




                catch (Exception ex)
                {
                    Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
                }


            }


        }

        private void leaderboard()
        {
            DataView dv = data.DefaultView;
            dv.Sort = "Column2 DESC";
            data.AsEnumerable().Take(5);
         
            bunifuCustomDataGrid1.DataSource = dv.ToTable();

               
          
           

          

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

                   // ThreadHelper.lsbAddItem(this, listBox1, message);

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


        

        private void GameFacilitator_Load(object sender, EventArgs e) // dae nagana ang load
        {


        //    if (music == "true")
        //    {
                player.controls.play();
                player.settings.setMode("loop", true);
            //     }


            //     if (random == "true")
            //     {

            if(participant == "IP")
            {
                try
                {


                    SqlDataAdapter sda = new SqlDataAdapter("SELECT p.fullname,0 AS 'Column2' FROM participant p, classlist c WHERE p.participant_id=c.participant_id AND c.class_id = '" + ID + "' ORDER BY NEWID() ", con);
                    data = new DataTable();
                    sda.Fill(data);
                    if (data.Rows.Count != 0)
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataSource = data;
                        bunifuCustomDataGrid1.DataSource = bs;
                        sda.Update(data);
                    }

                }
                catch (Exception ex)

                {

                    Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");


                }



            }

            else if (participant == "GP")
            {

                try
                {


                    SqlDataAdapter sda = new SqlDataAdapter("SELECT g.group_name,0 AS 'Column2' FROM groups g, grouplist gl WHERE g.group_id=gl.group_id AND g.class_id = '" + ID + "' ORDER BY NEWID() ", con);
                    data = new DataTable();
                    sda.Fill(data);
                    if (data.Rows.Count != 0)
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataSource = data;
                        bunifuCustomDataGrid1.DataSource = bs;
                        sda.Update(data);
                    }

                }
                catch (Exception ex)

                {

                    Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");


                }



            }








        }

                private void load_QA()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select qa.question,qa.answer_a,qa.answer_b,qa.answer_c,qa.answer_d,qa.correct_answer,qa.image,qa.QA_time_limit,qa.points,qa.game_type,qa.item_format,q.total_score from QuestionAnswers qa,quizzes q where qa.quiz_id=q.quiz_id AND qa.quiz_id= '" + QuizID + "'", con);
            adapt.Fill(dt);
            NoOfITems = dt.Rows.Count;//6 rows



       
           

        }


        private void load_game(int counter)
        {

            if (NoOfITems < 1)
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


                }

                else
                {
                    ItemPicture.Enabled = false;



                }

                //Tiglaog //


                string QuizContent = dt.Rows[counter][0].ToString() + Environment.NewLine + dt.Rows[counter][1].ToString() + Environment.NewLine + dt.Rows[counter][2].ToString() + Environment.NewLine + dt.Rows[counter][3].ToString() + Environment.NewLine + dt.Rows[counter][4].ToString() + Environment.NewLine + dt.Rows[counter][5].ToString() + Environment.NewLine + dt.Rows[counter][6].ToString() + Environment.NewLine + dt.Rows[counter][7].ToString() + Environment.NewLine + dt.Rows[counter][8].ToString() + Environment.NewLine + dt.Rows[counter][9].ToString() + Environment.NewLine + dt.Rows[counter][11].ToString() + Environment.NewLine + dt.Rows[counter][10].ToString();               

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

                string cut = dt.Rows[counter][7].ToString();
                int ind = cut.IndexOf('(');
                string form;
                if (ind >= 0)
                {
                    form = cut.Substring(ind + 1, 7);



                }
                else
                {

                    form = cut;
                }


                if (form == "Minutes")
                {
                    timerstamp = timerstamp * 60;
                }

                TimerLabel.Text = timerstamp.ToString();






                timer1.Start();




                //Tiglaog //

            }






          

                      

        }
        
   
        

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

            NoOfITems--;
            counter++;
            
            load_game(counter);
            panel3.Visible = false;
           // timer1.Start();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            SendToAllClients("C1o2mpute");
            //this.Close();
            bunifuFlatButton2.Visible = false;
            bunifuFlatButton3.Visible = true;
            bunifuFlatButton1.Visible = false;

            panel3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {




           
            

             
            timerstamp--;
            if (timerstamp == 0)
            {
          
                timer1.Stop();
                bunifuCustomLabel1.Visible = true;
                TimerLabel.Visible = false;
                panel3.Visible = true;
                label5.Text = "Correct Answer is " + dt.Rows[counter][5].ToString();
                if (NoOfITems == 1)
                {
                    bunifuFlatButton1.Visible = false;
                    bunifuFlatButton2.Visible = true;
                }
                else
                {
                    bunifuFlatButton1.Visible = true;
                }
               
            }
            else
            {
     
                TimerLabel.Text = timerstamp.ToString();
                bunifuCustomLabel1.Visible = false;
                TimerLabel.Visible = true;
                bunifuFlatButton1.Visible = false;
          
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SendToAllClients("PleaseHideThis");
            this.Close();
        }

        private void GameFacilitator_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.controls.stop();
            LobbyFacilitator.listener.Stop();

        }

       
    }
}
