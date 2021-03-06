﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;

namespace TooLearnOfficial
{
    public partial class GameRulesFacilitator : Form
    {


        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        private const int buffer_size = 2048;
       
        private byte[] buffer = new byte[buffer_size];
       
        public static string hostIP;
        private TcpListener listener=LobbyFacilitator.listener;
     
        private Dictionary<string, TcpClient> clientSockets = LobbyFacilitator.clientSockets;

       
        string GameType = LobbyFacilitator.GameType;
        public GameRulesFacilitator()
        {
            InitializeComponent();
            load_server();
        }

        private void GameRulesFacilitator_Load(object sender, EventArgs e)
        {




            if (GameType == "QB")
            {
                bunifuCustomLabel3.Text = "Quiz Bee";
                label3.Text = System.IO.File.ReadAllText(@"QuizBeeRules.txt");

            }

            else if (GameType == "PZ")
            {
                bunifuCustomLabel3.Text = "Picture Puzzle";
                label3.Text = System.IO.File.ReadAllText(@"PicturePuzzleRules.txt");
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

/*
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
        } */

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

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
                         
            
            

            SendToAllClients("StartGame");

            this.Hide();
            GameFacilitator GF = new GameFacilitator();
            GF.ShowDialog();
        }

        private void GameRulesFacilitator_FormClosed(object sender, FormClosedEventArgs e)
        {
            listener.Stop();
            LobbyFacilitator.clientSockets.Clear();
        }
    }
}
