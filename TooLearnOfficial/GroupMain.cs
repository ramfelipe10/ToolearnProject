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
    public partial class GroupMain : Form
    {
        SqlConnection con = new SqlConnection("Data Source='" + Program.source + "' ; Initial Catalog='" + Program.db + "'; User ID='" + Program.id + "';Password='" + Program.password + "'");

        public GroupMain()
        {
            InitializeComponent();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonEnterGame_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Game_Pin From Pincode", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                Dialogue.Show("No Host Server Detected! Please Wait for the Host to Start.", "", "Ok", "Cancel");

            }

            else
            {

                string code = dt.Rows[0][0].ToString();


                if (code == bunifuMetroTextbox1.Text)
                {

                    LobbyParticipant lobby = new LobbyParticipant();
                    lobby.ShowDialog();
                }

                else if (bunifuMetroTextbox1.Text == null || bunifuMetroTextbox1.Text == "")
                {
                    bunifuCustomLabel1.Text = "* Please Enter Code";

                }
                else
                {
                    bunifuCustomLabel1.Text = "* Code is Invalid!";

                }


            }//end else */
        }
    }
}
