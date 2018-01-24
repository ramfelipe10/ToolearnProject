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

namespace TooLearnOfficial
{
    public partial class ParticipantSQLConnect : Form
    {
        SqlConnection con;

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

           

            if (Server.SelectedItem != null)
            {
                Source = Server.SelectedItem.ToString();
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
                        DialogResult result= Dialogue1.Show("Connected", "", "Ok", "Cancel");
                        con.Close();
                        if (result == DialogResult.Yes)
                        {
                            Program.source = Source.ToString();
                            Program.db = DB;
                            Program.id = ID;
                            Program.password = Password;

                            this.Hide();
                            ParticipantLogin PL = new ParticipantLogin();
                            PL.Show();
                           
                        }

                        else
                        {
                            IDbox.Text = "";
                            Passwordbox.Text = "";
                            Server.SelectedItem = null;
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


    }
}
