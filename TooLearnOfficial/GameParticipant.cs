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
                    ThreadHelper.lblAddLabel(this, label1, array[0].ToString());
                    ThreadHelper.btnAddTxtButton(this, button1, array[1].ToString());
                    ThreadHelper.btnAddTxtButton(this, button2, array[2].ToString());
                    ThreadHelper.btnAddTxtButton(this, button3, array[3].ToString());
                    ThreadHelper.btnAddTxtButton(this, button4, array[4].ToString());


                    string Correct = array[5].ToString();

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
            Send(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Send(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Send(button4.Text);
        }

      
    }
}
