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
    public partial class GameCode : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public GameCode()
        {
            InitializeComponent();
        }


        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameCode_Load(object sender, EventArgs e)
        {

            char[] letters = "q1we2rty3uio4pas5dfgh6jklz7x8cv9bnm0".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 9; i++) //i < # depends how long the password
            {
                randomString += letters[r.Next(0, 34)].ToString();
            }

            code.Text=randomString;


            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Pincode(Game_Pin) Values('" + code.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

     

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // LobbyFacilitator LF = new LobbyFacilitator();
            // LF.ShowDialog();
            GameSettings GS = new GameSettings();
            GS.ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParticipantSQLConnect pc = new ParticipantSQLConnect();
            pc.Show();
        }
    }
}
