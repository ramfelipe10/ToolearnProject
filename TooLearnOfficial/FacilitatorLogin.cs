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
    public partial class FacilitatorLogin : Form
    {
        public FacilitatorLogin()
        {
            InitializeComponent();
        }

        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stephen_Kent\Documents\TooLearnDatabase.mdf;Integrated Security=True;Connect Timeout=30;"); //Steph Sipalay con string
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Toolearn.mdf;Integrated Security=True;Connect Timeout=30"); //Ram Felipe con string
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\BOC\Documents\GitHub\ToolearnProject\TooLearnOfficialDatabase.mdf; Integrated Security = True; Connect Timeout = 30"); //Kyle Boclot con string
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername.Text + "' and password= '" + passbox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                MainMenu mm = new MainMenu();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }
        }

        private void FacilitatorLogin_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFacilitatorCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreateFacilitator cf = new CreateFacilitator();
            cf.Show();
        }

        private void TextboxUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (passbox.isPassword == true)
            {
                passbox.isPassword = false;

            }

            else
            {

                passbox.isPassword = true;

            }

        }

    }
    }

