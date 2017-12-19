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
                MessageBox.Show("Please Check your Username and Password");
            }
        }

        private void TextboxUsername_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
