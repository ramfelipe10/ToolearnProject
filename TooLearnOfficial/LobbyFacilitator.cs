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

namespace TooLearnOfficial
{
    public partial class LobbyFacilitator : Form
    {
        // Set Buffer size for the data being sent and recieved
        private const int buffer_size = 2048;
        // Set Buffer as holder of data being sent and received
        private byte[] buffer = new byte[buffer_size];
        // Set the TCPListeneer on port 13000;
        private TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13000);
        // Set a list of client sockets
        private Dictionary<string, TcpClient> clientSockets = new Dictionary<string, TcpClient>();
        public LobbyFacilitator()
        {
            InitializeComponent();
            listener.Start(100);
            lsbJoined.Items.Add("Waiting for connections...");
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

                ThreadHelper.lsbAddItem(this, lsbJoined, "Client connected" + clientSocket.Client.RemoteEndPoint.ToString());

                //Send a confirmation message to client
                Send("You are now connected.", clientSocket);

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
                if (!message.Contains("DISCONNECT"))
                {
                    ThreadHelper.lsbAddItem(this, lsbJoined, message + ".");

                    //Begin receiving data from the client socket
                    Receive(clientSocket);
                    //Send a confirmation message to the client
                    Send("You sent " + message, clientSocket);
                }
                else
                {
                    ThreadHelper.lsbAddItem(this, lsbJoined, clientSocket.Client.RemoteEndPoint.ToString() + " has disconnected.");
                    //send a disconnect flag to the client to complete disconnection
                    Send("DISCONNECT", clientSocket);
                    //remove the client socket from the client list
                    clientSockets.Remove(clientSocket.Client.RemoteEndPoint.ToString());
                }
            }
            catch (Exception ex)
            {
                ThreadHelper.lsbAddItem(this, lsbJoined, ex.ToString());
            }
        }

        private void lsbJoined_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LobbyFacilitator_Load(object sender, EventArgs e)
        {

        }
    }
}
