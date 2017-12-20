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
    public partial class ParticipantLogin : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public ParticipantLogin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreateParticipant cp = new CreateParticipant();
            cp.Show();
        }

        private void ParticipantLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonParticipantSignIn_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From participant Where username='" + TextboxUsername.Text + "' and password= '" + TextboxPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                MainMenu2 mm = new MainMenu2();
                mm.Show();
            }
            else
            {
                Dialogue.Show("Login Failed! \r\n Please Check your Username and Password!", "", "Ok", "Cancel");
            }
        }

        private void TextboxUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            ChooseUser h = new ChooseUser();
            h.Show();
            this.Hide();
        }

        private void TextboxPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (TextboxPassword.Text.Length <= 0)
            {
                bunifuImageButton1.Visible = false;
            }

            else
            {
                bunifuImageButton1.Visible = true;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (TextboxPassword.isPassword == true)
            {
                TextboxPassword.isPassword = false;

            }

            else
            {

                TextboxPassword.isPassword = true;

            }

        }
    }
}
