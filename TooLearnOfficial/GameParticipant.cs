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

        string correctanswer,points;

        string time;
        int convertedtime;
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



                else if (message.Contains("StartGame"))
                {

                    ThreadHelper.PanelOut(this, panel1, false);
                    Receive();

                }

                else //else if start game visible false
                {
                    /* string Message = message.Substring(message.Length - 1, 1);


                     switch (Message)
                     {
                         case "1":

                             ThreadHelper.lblAddLabel(this, label1, message);

                             break;


                         case "2":

                             ThreadHelper.btnAddTxtButton(this, button1, message);

                             break;


                         case "3":
                             ThreadHelper.btnAddTxtButton(this, button2, message);
                             break;


                         case "4":

                             ThreadHelper.btnAddTxtButton(this, button3, message);

                             break;


                         case "5":

                             ThreadHelper.btnAddTxtButton(this, button4, message);



                             break;                      
                    
                     }  */

                


                    var array = message.Split('\n');


                    correctanswer=array[5].ToString();

                    points= array[8].ToString();



                    if (array[10].ToString() =="Multiple Choice")//Item Format
                    {

                        ThreadHelper.lblAddLabel(this, label1, array[0].ToString());  //Question
                        ThreadHelper.btnAddTxtButton(this, bunifuFlatButton1, array[1].ToString());  //A
                        ThreadHelper.btnAddTxtButton(this, bunifuFlatButton2, array[2].ToString());  //B
                        ThreadHelper.btnAddTxtButton(this, bunifuFlatButton3, array[3].ToString());  //C
                        ThreadHelper.btnAddTxtButton(this, bunifuFlatButton4, array[4].ToString());  //D
                        string Correct = array[5].ToString();  //CorrectAnswer

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


                        timer1.Start(); /// dae nagana after mag stop dae na na start to be fixed



                    }
                   else if(array[10].ToString() == "True/False")
                    {
                        ThreadHelper.lblAddLabel(this, label1, array[0].ToString());  //Question
                        string Correct = array[5].ToString();  //CorrectAnswer


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



                        timer1.Start();
                    }

                    else
                    {
                        ThreadHelper.lblAddLabel(this, label1, array[0].ToString());  //Question
                        string Correct = array[5].ToString();  //CorrectAnswer



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



                       
                            timer1.Start();
                     

                    }

                /*    ThreadHelper.lblAddLabel(this, label1, array[0].ToString());  //Question
                    ThreadHelper.btnAddTxtButton(this, button1, array[1].ToString());  //A
                    ThreadHelper.btnAddTxtButton(this, button2, array[2].ToString());  //B
                    ThreadHelper.btnAddTxtButton(this, button3, array[3].ToString());  //C
                    ThreadHelper.btnAddTxtButton(this, button4, array[4].ToString());  //D
                    string Correct = array[5].ToString();  //CorrectAnswer
                    */


                    

                   // array[6].ToString());  //Image
                  //  array[7].ToString()); //TimeLimit
                  //  array[8].ToString()); //Points
                  //  array[9].ToString()); //Game Type
                  //  array[10].ToString()); //Item Format

                    Receive();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Timer()
        {

        }


        private void BeginWriteCallback(IAsyncResult ar)
        {
            NetworkStream stream = (NetworkStream)ar.AsyncState;
            stream.EndWrite(ar);
        }

        private void GameParticipant_Load(object sender, EventArgs e)
        {

          

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
       

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Send(bunifuFlatButton1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send(bunifuFlatButton2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Send(bunifuFlatButton3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Send(bunifuFlatButton4.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            convertedtime--;

            if (convertedtime == 0)
            {
                timer1.Stop();
                bunifuCustomLabel2.Visible = true;
                bunifuCustomLabel3.Visible = false;
            }
            else
            {
                timer1.Start();//
                bunifuCustomLabel3.Text = convertedtime.ToString();
                bunifuCustomLabel2.Visible = false;
                bunifuCustomLabel3.Visible = true;
            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            /*string box= bunifuMetroTextbox1.Text;
             string WHAT=validate(box);
             if (WHAT == "Correct")
             {
                int score=Convert.ToInt32(bunifuCustomLabel5.Text);
                int itempoints= Convert.ToInt32(points);
                 score = score + itempoints;

                 bunifuCustomLabel5.Text = score.ToString();

                 MessageBox.Show("tama ka");

             }
             else if(WHAT == "Wrong")
             {
                 MessageBox.Show("sala ka");
             }

             else
             {
                 MessageBox.Show("gg");
             } */

            validate(bunifuMetroTextbox1.Text.ToString());
           // label4.Text = correctanswer;
            //label5.Text = WHAT;
        }


        private string validate(string answer)
        {
            string score;

            string.Compare(answer, correctanswer);
          //  int x=System.StringComparison.OrdinalIgnoreCase(answer, correctanswer);
            if (answer==correctanswer)
            {
                score = "Correct";
               
            }
            else if(answer != correctanswer)
            {
                score = "Wrong";
            }

            else
            {
                score = "anu bya";
            }

           


            label6.Text = answer;

            return score;

            
        }

    }
}
