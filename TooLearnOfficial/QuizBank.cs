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

namespace TooLearnOfficial
{
    public partial class QuizBank : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public QuizBank()
        {
            InitializeComponent();
            Load_Quiz();
        }



        void Load_Quiz()
        {
                      
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select quiz_title AS 'Title' ,date_created AS 'Created' from quizzes where facilitator_id= '" + Program.user_id + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel1.Visible = true;

                }
                
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel1.Visible = false;

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            LobbyFacilitator lobby = new LobbyFacilitator();
            lobby.Show();
        }
    }
}
