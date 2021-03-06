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

        DataTable data;
        DataTable EmptyData;
        DataColumn dc;

        private TcpListener listener = LobbyFacilitator.listener;
        bool music = GameSettings.IsMusic;
        bool random = GameSettings.IsRandom;

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        
       
        string participant = SelectParticipant.participant.ToString();

        int counter = 0;
        int QuizID = QuizBank.QUIZID;
        int NoOfITems;
      

        string time,des;
        string convertedtime;
        int timerstamp;
        string ID = SelectClassroom.ID;

        DataTable dt = new DataTable();
        DataTable dts = new DataTable();
        DataTable dtsd = new DataTable();
        DataTable participants = new DataTable();



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

        public void PUZZLEScore(string Score)
        {


            string up = Score.ToString();

            // string name = up.Substring(8,up.Length-12);
            string name;
            int nameindex = up.LastIndexOf(',');
            name = up.Substring(8, nameindex - 8);
            int index = up.LastIndexOf('(');
            string points = up.Substring(index + 1);
            points = points.Substring(0, points.Length - 1);


            ThreadHelper.lsbAddItem(this, listBox1, up + "(" + DateTime.Now.TimeOfDay + ")");
            this.Invoke((MethodInvoker)(() => updatescore(name, points)));

        }

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

                       
           ThreadHelper.lsbAddItem(this, listBox1, up +"("+DateTime.Now.TimeOfDay+")");            
           this.Invoke((MethodInvoker)(() => updatescore(name,points)));

        }
        private void updatescore(string name,string points)
        {
            if (participant == "PUBLIC")
            {
                int counter = 0;
                for (int i = 0; i < EmptyData.Rows.Count; i++)
                {

                    if (EmptyData.Rows[i][0].ToString()== name.ToString())
                    {
                        this.Invoke((MethodInvoker)(() => EmptyData.Rows[i][1] = points.ToString()));                       
                        this.Invoke((MethodInvoker)(() => leaderboardFREE()));
                        this.Invoke((MethodInvoker)(() => bunifuCustomDataGrid1.Update()));
                        this.Invoke((MethodInvoker)(() => bunifuCustomDataGrid1.Refresh()));
                        counter++;

                    }
                   


                }

                if (counter == 0)
                {

                   

                    DataRow DR = EmptyData.NewRow();                   
                    this.Invoke((MethodInvoker)(() => DR[0] = name.ToString()));
                    this.Invoke((MethodInvoker)(() => DR[1] = points.ToString()));
                    this.Invoke((MethodInvoker)(() => EmptyData.Rows.Add(DR)));

                    this.Invoke((MethodInvoker)(() => leaderboardFREE()));
                    this.Invoke((MethodInvoker)(() => bunifuCustomDataGrid1.Update()));
                    this.Invoke((MethodInvoker)(() => bunifuCustomDataGrid1.Refresh()));

                }



            }

            else
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

        }

        private void leaderboardFREE()
        {
            DataView dv = EmptyData.DefaultView;
            dv.Sort = "Column2 DESC";
            EmptyData.AsEnumerable().Take(5);
            bunifuCustomDataGrid1.DataSource = dv.ToTable();


        }

        private void leaderboard()
        {
            DataView dv = data.DefaultView;
            dv.Sort = "Column2 DESC";
            data.AsEnumerable().Take(5);         
            bunifuCustomDataGrid1.DataSource = dv.ToTable();                         

          
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


        

        private void GameFacilitator_Load(object sender, EventArgs e) // dae nagana ang load
        {
                              
           

            if (music == false)
            {
                player.controls.stop();
                bunifuImageButton1.Visible = false;
                bunifuImageButton2.Visible = false;
           }
            else
            {
                player.controls.play();
                player.settings.setMode("loop", true);
                bunifuImageButton1.Visible = true;
                bunifuImageButton2.Visible = true;
            }


           

            if(participant == "IP")
            {
                try
                {


                    SqlDataAdapter sda = new SqlDataAdapter("SELECT p.fullname,0 AS 'Column2' FROM participant p, classlist c WHERE p.participant_id=c.participant_id AND c.class_id = '" + ID + "'", con);
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

            else if(participant == "GP")
            {

                try
                {


                    SqlDataAdapter sda = new SqlDataAdapter("SELECT group_name,0 AS 'Column2' FROM groups WHERE class_id = '" + ID + "'", con);
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


            else
            {
                EmptyData = new DataTable();
                dc = new DataColumn("Column1", typeof(String));
                EmptyData.Columns.Add(dc);

                dc = new DataColumn("Column2", typeof(String));
                EmptyData.Columns.Add(dc);



                BindingSource bs = new BindingSource();
                bs.DataSource = EmptyData;
                bunifuCustomDataGrid1.DataSource = bs;

            }




        }

           void slice_image(string picture)
            {




                var imgarray = new Image[9];

               // System.Drawing.Image img = System.Drawing.Image.FromFile()


               var img = Image.FromFile(picture, true); //Use ImageLocation Of Recent Upload

                for (int x = 0; x < 3; x++) //Row
                {
                    for (int y = 0; y < 3; y++) //Column
                    {
                        var index = x * 3 + y;

                        int PictureWidth = img.Width;
                        int PictureHeight = img.Height;

                        imgarray[index] = new Bitmap(PictureWidth / 3, PictureHeight / 3);
                        var graphics = Graphics.FromImage(imgarray[index]);
                        graphics.DrawImage(img, new Rectangle(0, 0, 86, 56), new Rectangle(x * (PictureWidth / 3),
                                         y * (PictureHeight / 3),
                                         PictureWidth / 3,
                                        PictureHeight / 3), GraphicsUnit.Pixel);
                        graphics.Dispose();

                    }
                }




                pictureBox1.Image = imgarray[0];
                pictureBox2.Image = imgarray[1];
                pictureBox4.Image = imgarray[2];
                pictureBox5.Image = imgarray[3];
                pictureBox6.Image = imgarray[4];
                pictureBox7.Image = imgarray[5];
                pictureBox8.Image = imgarray[6];
                pictureBox9.Image = imgarray[7];
                pictureBox10.Image = imgarray[8];



            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

        } 




        private void load_QA()
       {

           SqlDataAdapter adapter = new SqlDataAdapter("select puzzle_image from quizzes where quiz_id= '" + QuizID + "'", con);
            adapter.Fill(dts);
            if (dts.Rows[0][0].ToString() == null || dts.Rows[0][0].ToString() == "")
            {

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;


                bunifuCustomLabel10.Visible = false;


            }
            else
            {



                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                slice_image(dts.Rows[0][0].ToString());
                bunifuCustomLabel10.Visible = true;


                SqlDataAdapter adapt = new SqlDataAdapter("select image_description from quizzes where quiz_id= '" + QuizID + "'", con);
                adapt.Fill(dtsd);
                des = dtsd.Rows[0][0].ToString();


            }


            if (random == false)
            {

                SqlDataAdapter adapt = new SqlDataAdapter("select qa.question,qa.answer_a,qa.answer_b,qa.answer_c,qa.answer_d,qa.correct_answer,qa.image,qa.QA_time_limit,qa.points,qa.game_type,qa.item_format,q.total_score from QuestionAnswers qa,quizzes q where qa.quiz_id=q.quiz_id AND qa.quiz_id= '" + QuizID + "'", con);
                adapt.Fill(dt);
                NoOfITems = dt.Rows.Count;//6 rows

            }

            else
            {


                SqlDataAdapter adapt = new SqlDataAdapter("select qa.question,qa.answer_a,qa.answer_b,qa.answer_c,qa.answer_d,qa.correct_answer,qa.image,qa.QA_time_limit,qa.points,qa.game_type,qa.item_format,q.total_score from QuestionAnswers qa,quizzes q where qa.quiz_id=q.quiz_id AND qa.quiz_id= '" + QuizID + "' Order by NEWID()", con);
                adapt.Fill(dt);
                NoOfITems = dt.Rows.Count;//6 rows


            }

       
           

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



                if (dt.Rows[counter][6].ToString() == null || dt.Rows[counter][6].ToString() == "")
                {
                    ItemPicture.ImageLocation = "";
                    ItemPicture.Enabled = false;
                    bunifuCustomLabel11.Visible = false;


                }

                else
                {
                    

                    ItemPicture.ImageLocation = dt.Rows[counter][6].ToString();
                    ItemPicture.Enabled = true;
                    bunifuCustomLabel11.Visible = true;



                }

                //Tiglaog //


                string QuizContent = dt.Rows[counter][0].ToString() + Environment.NewLine + dt.Rows[counter][1].ToString() + Environment.NewLine + dt.Rows[counter][2].ToString() + Environment.NewLine + dt.Rows[counter][3].ToString() + Environment.NewLine + dt.Rows[counter][4].ToString() + Environment.NewLine + dt.Rows[counter][5].ToString() + Environment.NewLine + dt.Rows[counter][6].ToString() + Environment.NewLine + dt.Rows[counter][7].ToString() + Environment.NewLine + dt.Rows[counter][8].ToString() + Environment.NewLine + dt.Rows[counter][9].ToString() + Environment.NewLine + dt.Rows[counter][11].ToString() + Environment.NewLine + des + Environment.NewLine + dt.Rows[counter][10].ToString();               

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

                //  TimerLabel.Text = timerstamp.ToString();

                TimerLabel.Text = TimerFormat(timerstamp);




                timer1.Start();




                //Tiglaog //

            }






          

                      

        }
        
   
        

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            listener.Stop();

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

            bunifuCustomLabel8.Text = (Convert.ToInt32(bunifuCustomLabel8.Text) + 1).ToString();
            // timer1.Start();

            PictureBox[] box = new PictureBox[9];
            box[0] = pictureBox1;
            box[1] = pictureBox2;
            box[2] = pictureBox4;
            box[3] = pictureBox5;
            box[4] = pictureBox6;
            box[5] = pictureBox7;
            box[6] = pictureBox8;
            box[7] = pictureBox9;
            box[8] = pictureBox10;

            box[counter].Visible = true;
          
        }


        private void Insert_Score()
        {
            try
            {
               if (participant == "IP")
              {

                    con.Open();

                    for (int i = 0; i < data.Rows.Count; i++)
                    {


                        //  bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[0].Value

                        //    SqlDataAdapter adapt = new SqlDataAdapter("select participant_id from participant where fullname= '" + bunifuCustomDataGrid1.Rows[i].Cells[0].Value.ToString() + "' ", con);
                        //  SqlDataAdapter adapt = new SqlDataAdapter("select participant_id from participant where fullname= '" + data.Rows[i][0].ToString() + "' ", con);
                        //  adapt.Fill(participants);
                        // string id = participants.Rows[0][0].ToString();

                        string name = data.Rows[i][0].ToString();
                        string score = data.Rows[i][1].ToString();
                        string querys = "select participant_id from participant where fullname= '" + name + "' ";
                        SqlCommand cmd = new SqlCommand(querys, con);
                        string getValue = cmd.ExecuteScalar().ToString();
                       


                        String query = "INSERT INTO scoreRecords(quiz_score,date_time,quiz_id,participant_id,class_id) VALUES ('" + score + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + QuizID + "','" + getValue + "', '" + ID + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        int n = sda.SelectCommand.ExecuteNonQuery();

                       getValue = "";
                        score = "";



                    }
                    con.Close();

               }
                else if (participant == "GP")
               {

                    con.Open();

                    for (int i = 0; i < data.Rows.Count; i++)
                    {

                        //  SqlDataAdapter adapt = new SqlDataAdapter("select group_id from groups where group_name= '" + bunifuCustomDataGrid1.Rows[i].Cells[0].Value.ToString() + "' ", con);
                        // SqlDataAdapter adapt = new SqlDataAdapter("select group_id from groups where group_name= '" + data.Rows[i][0].ToString() + "' ", con);
                        //  adapt.Fill(participants);
                        //  string id = participants.Rows[0][0].ToString();


                        string name = data.Rows[i][0].ToString();
                        string score = data.Rows[i][1].ToString();

                        string querys = "select group_id from groups where group_name= '" + name + "' ";
                        SqlCommand cmd = new SqlCommand(querys, con);
                        string getValue = cmd.ExecuteScalar().ToString();

                        String query = "INSERT INTO scoreRecords(quiz_score,date_time,quiz_id,group_id,class_id) VALUES ('" + score + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + QuizID + "','" + getValue + "', '" + ID + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        int n = sda.SelectCommand.ExecuteNonQuery();

                        getValue = "";
                        score = "";


                    }
                    con.Close();
                }

            }//try

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 

        }



        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            Insert_Score();


            SendToAllClients("C1o2mpute");
            //this.Close();
            bunifuFlatButton2.Visible = false;
            bunifuFlatButton3.Visible = true;
            bunifuFlatButton1.Visible = false;

            panel3.Visible = true;//fALSE BEFORE
            panel5.Visible = true;
        }


        private void image_trigger()
        {

          /*  PictureWidth = pictureBox11.Image.Width;
            PictureHeight = pictureBox11.Image.Height;
            slice_image(n); */
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

                      

            timerstamp--;
            if (timerstamp == 0)
            {
          
                timer1.Stop();
               //bunifuCustomLabel1.Visible = true;
                TimerLabel.Visible = false;
                panel3.Visible = true;
                label5.Text = "Correct Answer is " + dt.Rows[counter][5].ToString().ToUpper();
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
                TimerLabel.Text = TimerFormat(timerstamp);
              //  TimerLabel.Text = timerstamp.ToString();
                bunifuCustomLabel1.Visible = false;
                TimerLabel.Visible = true;
                bunifuFlatButton1.Visible = false;
          
            }
        }

        private string TimerFormat(int secs)
        {
            TimeSpan t = TimeSpan.FromSeconds(secs);
            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                (int)t.TotalHours,
                t.Minutes,
                t.Seconds);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SendToAllClients("PleaseHideThis");
            listener.Stop();
            LobbyFacilitator.clientSockets.Clear();//ADDED
            this.Close();
           
        }

        private void GameFacilitator_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.controls.stop();


            listener.Stop();
            LobbyFacilitator.clientSockets.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           panel4.Visible = true;
            button1.Visible = false;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            button1.Visible = true;
        }
    }
}
