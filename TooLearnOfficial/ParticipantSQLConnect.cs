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

namespace TooLearnOfficial
{
    public partial class ParticipantSQLConnect : Form
    {
        SqlConnection con;

        string Role = ChooseUser.Role;

        public ParticipantSQLConnect()
        {
            InitializeComponent();            
            load_server();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }


      


        private void load_server()
        {
            

            Cursor.Current = Cursors.WaitCursor;        
            
            DataTable table = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow server in table.Rows)
            {
                Server.Items.Add(server[table.Columns["ServerName"]].ToString());
            }
            
            Cursor.Current = Cursors.Default;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            ChooseUser CU = new ChooseUser();
            CU.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Server.Items.Clear();
            load_server();
        }


        private void Connect_Click(object sender, EventArgs e)
        {

            String  DB, ID, Password;
            Object Source;
            string servername = Server.SelectedItem.ToString();
            try
            {
                IPHostEntry host = Dns.GetHostEntry(servername); //get the ServerIP
                foreach (IPAddress ip in host.AddressList)
                {

                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Program.serverIP = ip.ToString();

                    }
                }
            }//end try

            catch(SocketException ex)
            {

                Dialogue.Show(" " + ex.Message.ToString() + " ", "", "Ok", "Cancel");
            }


            if (Server.SelectedItem != null)
            {
                Source = Server.SelectedItem.ToString() + ",1433";
                DB = "Toolearn";
                ID = IDbox.Text;
                Password = Passwordbox.Text;

                con = new SqlConnection("Data Source='" + Source + "' ; Initial Catalog='" + DB + "'; User ID='" + ID + "';Password='" + Password + "'");
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    con.Open();
                    Cursor.Current = Cursors.Default;
                    if (con.State == ConnectionState.Open)
                    {
                       
                        con.Close();
                      
                            Program.source = Source.ToString();
                            Program.db = DB;
                            Program.id = ID;
                            Program.password = Password;


                        if (Role == "Individual")
                        {

                            this.Hide();
                            ParticipantLogin PL = new ParticipantLogin();
                            PL.Show();

                        }

                        else
                        {
                            this.Hide();
                            GroupLogin GL = new GroupLogin();
                            GL.Show();
                        }
                    
                           
                    }


                    else
                    {
                        Dialogue.Show("Connection Failed", "", "Ok", "Cancel");
                    }

                }

                catch (Exception ex)
                {
                    Dialogue.Show(" " + ex.Message.ToString() + " ", "", "Ok", "Cancel");
                }


            }

            else
            {

                Dialogue.Show("No Server Selected", "", "Ok", "Cancel");
            }
        }

        private void ParticipantSQLConnect_Load(object sender, EventArgs e)
        {

        }

       
    }
}
