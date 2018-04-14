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
using System.Text.RegularExpressions;


namespace TooLearnOfficial
{
    public partial class GameParticipant : Form
    {
        private TcpClient _client = new TcpClient();
        private const int _buffer_size = 2048;
        private byte[] _buffer = new byte[_buffer_size];
        private string _IPAddress = Program.serverIP;
        private const int _PORT = 13000;

        string GameType = LobbyParticipant.GameType;
        string correctanswer,points,Pname;
        string time;
        int convertedtime;
        string Total;
      

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
       
        public GameParticipant()
        {
            InitializeComponent();
            StartConnect();
            SetDoubleBuffered(panel1);
            SetDoubleBuffered(panel2);
            SetDoubleBuffered(panel3);
            SetDoubleBuffered(panel4);


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
               // MessageBox.Show(ex.ToString());
            }
        }


        private void SendScore(string message)
        {
            try
            {
                //Translate the message into its byte form
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes("(SCORE),"+Pname+",("+message+")");

                //Get a client stream for reading and writing
                NetworkStream stream = _client.GetStream();

                //Send the message to the connected server
                //stream.Write(buffer, 0, buffer.length);
                stream.BeginWrite(buffer, 0, buffer.Length, BeginWriteCallback, stream);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
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

        private string get(string answer)
        {
            string RA = answer;
            string value = "";

            char[] answerchar = RA.ToArray();
            for (int i = 0; i < RA.Count(); i++)
            {
                if ((i % 2) == 0)
                {
                    value += answerchar[i].ToString();
                }

            }

            return value;
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


                   
                    ThreadHelper.Hide(this);
                    client.Client.Shutdown(SocketShutdown.Both);
                    client.Client.Close();
                    
                }



                else if (message.Contains("StartGame"))
                {

                    ThreadHelper.PanelOut(this, panel1, false);
                    Receive();

                }

               else if (message.Contains("C1o2mpute"))
                {
                   int rawscore= Convert.ToInt32(bunifuCustomLabel5.Text);
                   
                    ThreadHelper.SetText(this, label6, rawscore.ToString());
                   
                    ThreadHelper.SetText(this, label10, Total);
                    
                   
                    double converted_total = Convert.ToInt32(Total);
                    double converted_rawscore = rawscore;
                    double comp = (converted_rawscore / converted_total) * 100;//bawal zero
                    int compute = Convert.ToInt32(comp);
                    
                    if (compute < Convert.ToInt32("60")){
                      

                        ThreadHelper.SetText(this, label9, compute.ToString() + "% You Need Improvement, Study and Play!");
                    }
                    else if(compute == Convert.ToInt32("100"))
                    {
                        
                        ThreadHelper.SetText(this, label9, compute.ToString() + "% Excellent!");
                    }

                    else
                    {
                      
                        ThreadHelper.SetText(this, label9, compute.ToString() + "% Not Bad!, aim for a Perfect Score Next Time ");
                    }

                    ThreadHelper.PanelOut(this, panel4, true);
                    ThreadHelper.PanelOut(this, panel1, true);//for this panel4 to show because of dock

                    Receive();
                }

               else if (message.Contains("PleaseHideThis"))
                {
                    Send("DISCONNECT");                    
                    ThreadHelper.Hide(this);
                   
                   
                   
                } 

                else 
                {                   


                    var array = message.Split('\n');


               



                    if (array[11].ToString() =="Multiple Choice")//Item Format
                    {
                        ThreadHelper.PanelOut(this, panel2, false);
                        ThreadHelper.PanelOut(this, panel3, false);

                        ThreadHelper.lblAddLabel(this, label1, array[0].ToString());  //Question
                        ThreadHelper.btnAddTxtButton(this, bunifuFlatButton1, array[1].ToString());  //A
                        ThreadHelper.btnAddTxtButton(this, bunifuFlatButton2, array[2].ToString());  //B
                        ThreadHelper.btnAddTxtButton(this, bunifuFlatButton3, array[3].ToString());  //C
                        ThreadHelper.btnAddTxtButton(this, bunifuFlatButton4, array[4].ToString());  //D
                        correctanswer = array[5].ToString();  //CorrectAnswer
                        points = array[8].ToString();

                      Total = array[10].ToString();

                        ThreadHelper.ControlHide(this, bunifuFlatButton1, true);
                        ThreadHelper.ControlHide(this, bunifuFlatButton2, true);
                        ThreadHelper.ControlHide(this, bunifuFlatButton3, true);
                        ThreadHelper.ControlHide(this, bunifuFlatButton4, true);
                        ThreadHelper.imgbtnIN(this, bunifuImageButton1, false);
                        ThreadHelper.BunifuBoxHide(this, bunifuMetroTextbox1, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton5, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton6, false);


                        string str = array[7].ToString();
                        int index = str.IndexOf('(');

                        if (index >= 0)
                        {
                            time = str.Substring(0, index);



                        }
                        else
                        {

                            time = str;
                        }


                        convertedtime = Convert.ToInt32(time);//timer


                        string cut = array[7].ToString();
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
                            convertedtime = convertedtime * 60;
                        }


                      



                        this.Invoke(new ThreadStart(delegate () { timer1.Enabled = true; timer1.Start(); }));



                    }
                   else if(array[11].ToString() == "True/False")
                    {
                       
                        ThreadHelper.PanelOut(this, panel2, false);
                        ThreadHelper.PanelOut(this, panel3, false);

                        ThreadHelper.lblAddLabel(this, label1, array[0].ToString());  //Question
                        correctanswer = array[5].ToString();  //CorrectAnswer
                        points = array[8].ToString();
                        Total = array[10].ToString();

                        ThreadHelper.imgbtnIN(this, bunifuImageButton1, false);
                        ThreadHelper.BunifuBoxHide(this, bunifuMetroTextbox1, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton1, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton2, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton3, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton4, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton5, true);
                        ThreadHelper.ControlHide(this, bunifuFlatButton6, true);

                        
                       

                        string str = array[7].ToString(); 
                        int index = str.IndexOf('(');

                        if (index >= 0)
                        {
                            time = str.Substring(0, index);



                        }
                        else
                        {

                            time = str;
                        }


                       convertedtime = Convert.ToInt32(time);//timer



                        string cut = array[7].ToString();
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
                            convertedtime = convertedtime * 60;
                        }


                     

                        this.Invoke(new ThreadStart(delegate () { timer1.Enabled = true; timer1.Start(); }));
                    }

                    else
                    {

                        ThreadHelper.PanelOut(this, panel2, false);
                        ThreadHelper.PanelOut(this, panel3, false);

                        ThreadHelper.lblAddLabel(this, label1, array[0].ToString());  //Question
                        correctanswer = array[5].ToString(); ;  //CorrectAnswer
                        points = array[8].ToString();
                        Total = array[10].ToString();

                        ThreadHelper.imgbtnIN(this, bunifuImageButton1, true);
                        ThreadHelper.BunifuBoxHide(this, bunifuMetroTextbox1, true);
                        ThreadHelper.ControlHide(this, bunifuFlatButton1, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton2, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton3, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton4, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton5, false);
                        ThreadHelper.ControlHide(this, bunifuFlatButton6, false);

                        string str = array[7].ToString();
                        int index = str.IndexOf('(');

                        if (index >= 0)
                        {
                            time = str.Substring(0, index);



                        }
                        else
                        {

                            time = str;
                        }


                        convertedtime = Convert.ToInt32(time);//timer




                        string cut = array[7].ToString();
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
                            convertedtime = convertedtime * 60;
                        }

                      
                        this.Invoke(new ThreadStart(delegate () { timer1.Enabled = true; timer1.Start(); }));

                      
                        
                     
                        
                    }

              

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
            try
            {
                SqlDataAdapter Name = new SqlDataAdapter("Select fullname from participant where participant_id='" + Program.par_id + "' ", con);
                DataTable dt = new DataTable();
                Name.Fill(dt);
                Pname = dt.Rows[0][0].ToString(); //tg balik ko



                if (GameType == "QB")
                {
                    label2.Text = "Quiz Bee";
                    label3.Text = System.IO.File.ReadAllText(@"QuizBeeRules.txt");

                }

                else if (GameType == "PZ")
                {
                    label2.Text = "Picture Puzzle";
                    label3.Text = System.IO.File.ReadAllText(@"PicturePuzzleRules.txt");
                }

                

           

            }

            catch(Exception ex)
            {

                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }

        }  
       

        private async void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            await Task.Delay(100);

            DialogResult result = Dialogue1.Show("Are you sure you want to Exit?", "", "Ok", "Cancel");
            if (result == DialogResult.Yes)
            {
                Send("DISCONNECT");
              
                
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            convertedtime--;

            if (convertedtime == 0)
            {
                timer1.Stop();
                bunifuCustomLabel2.Visible = true;
                bunifuCustomLabel3.Visible = false;

                bunifuFlatButton1.Enabled = false;
                bunifuFlatButton2.Enabled = false;
                bunifuFlatButton3.Enabled = false;
                bunifuFlatButton4.Enabled = false;//MC

                bunifuFlatButton5.Enabled = false;//TF
                bunifuFlatButton6.Enabled = false;

                bunifuMetroTextbox1.Enabled = false;//SA
                bunifuImageButton1.Enabled = false;




            }
            else
            {
                bunifuCustomLabel3.Text = TimerFormat(convertedtime);
               // bunifuCustomLabel3.Text = convertedtime.ToString();
                bunifuCustomLabel2.Visible = false;
                bunifuCustomLabel3.Visible = true;


                bunifuFlatButton1.Enabled = true;
                bunifuFlatButton2.Enabled = true;
                bunifuFlatButton3.Enabled = true;
                bunifuFlatButton4.Enabled = true;//MC

                bunifuFlatButton5.Enabled = true;//TF
                bunifuFlatButton6.Enabled = true;

                bunifuMetroTextbox1.Enabled = true;//SA
                bunifuImageButton1.Enabled = true;

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


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            string feed = validateSA(bunifuMetroTextbox1.Text);
            int score;

            if (feed=="Correct")
            {

                score=Convert.ToInt32(bunifuCustomLabel5.Text);
                score = score + Convert.ToInt32(points);
                bunifuCustomLabel5.Text = score.ToString();
                panel3.Visible = true;
                panel2.Visible = false;
                label5.Text = "Correct!";

                SendScore(bunifuCustomLabel5.Text.ToString());
            }

            else
            {
                panel2.Visible = true;
                panel3.Visible = false;                
                label4.Text = "Wrong! The Right Answer is " + correctanswer.ToUpper() ;
            }

            bunifuMetroTextbox1.Text = "";

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string feed = validate("B");
            int score;

            if (feed == "Correct")
            {

                score = Convert.ToInt32(bunifuCustomLabel5.Text);
                score = score + Convert.ToInt32(points);
                bunifuCustomLabel5.Text = score.ToString();
                panel3.Visible = true;
                panel2.Visible = false;
                label5.Text = "Correct!";

                SendScore(bunifuCustomLabel5.Text.ToString());
            }

            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
                label4.Text = "Wrong! The Right Answer is " + correctanswer.ToUpper();

            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string feed = validate("C");
            int score;

            if (feed == "Correct")
            {

                score = Convert.ToInt32(bunifuCustomLabel5.Text);
                score = score + Convert.ToInt32(points);
                bunifuCustomLabel5.Text = score.ToString();
                panel3.Visible = true;
                panel2.Visible = false;
                label5.Text = "Correct!";


                SendScore(bunifuCustomLabel5.Text.ToString());
            }

            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
                label4.Text = "Wrong! The Right Answer is " + correctanswer.ToUpper();
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            string feed = validate(bunifuFlatButton5.Text);
            int score;

            if (feed == "Correct")
            {

                score = Convert.ToInt32(bunifuCustomLabel5.Text);
                score = score + Convert.ToInt32(points);
                bunifuCustomLabel5.Text = score.ToString();
                panel3.Visible = true;
                panel2.Visible = false;
                label5.Text = "Correct!";

                SendScore(bunifuCustomLabel5.Text.ToString());
            }

            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
                label4.Text = "Wrong! The Right Answer is " + correctanswer.ToUpper();
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            string feed = validate(bunifuFlatButton6.Text);
            int score;

            if (feed == "Correct")
            {

                score = Convert.ToInt32(bunifuCustomLabel5.Text);
                score = score + Convert.ToInt32(points);
                bunifuCustomLabel5.Text = score.ToString();
                panel3.Visible = true;
                panel2.Visible = false;
                label5.Text = "Correct!";

                SendScore(bunifuCustomLabel5.Text.ToString());
            }

            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
                label4.Text = "Wrong! The Right Answer is " + correctanswer.ToUpper();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            string feed = validate("A");
            int score;

            if (feed == "Correct")
            {

                score = Convert.ToInt32(bunifuCustomLabel5.Text);
                score = score + Convert.ToInt32(points);
                bunifuCustomLabel5.Text = score.ToString();
                panel3.Visible = true;
                panel2.Visible = false;
                label5.Text = "Correct!";

                SendScore(bunifuCustomLabel5.Text.ToString());
            }

            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
                label4.Text = "Wrong! The Right Answer is " + correctanswer.ToUpper();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string feed = validate("D");
            int score;

            if (feed == "Correct")
            {

                score = Convert.ToInt32(bunifuCustomLabel5.Text);
                score = score + Convert.ToInt32(points);
                bunifuCustomLabel5.Text = score.ToString();
                panel3.Visible = true;
                panel2.Visible = false;
                label5.Text = "Correct!";

                SendScore(bunifuCustomLabel5.Text.ToString());
            }

            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
                label4.Text = "Wrong! The Right Answer is " + correctanswer.ToUpper();
            }
        }

       
        private string validate(string answer)
        {
         
            string feed;



            if (correctanswer.ToLower().ToString().Contains(answer.ToLower().ToString()))
            {
                feed = "Correct";

                

            }
            else 
            {
                feed = "Wrong";
              

            }      

           
            return feed;

            
        }


        private string validateSA(string answer)
        {

            string feed;



            if (correctanswer.ToLower().ToString().Contains(answer.ToLower().ToString()) && answer.Length.Equals(correctanswer.Length-1) )
            {
                feed = "Correct";



            }
            else
            {
                feed = "Wrong";

                
            }


            return feed;


        }



    }
}
