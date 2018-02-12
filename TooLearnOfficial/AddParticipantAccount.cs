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
    public partial class AddParticipantAccount : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public AddParticipantAccount()
        {
            InitializeComponent();
        }

        private void ButtonFacilitatorCreateAccount_Click(object sender, EventArgs e)
        {

            if (FName.Text == "" || Mname.Text == "" || Lname.Text == "")
            {
                Dialogue.Show("Fill All Fields!", "", "Ok", "Cancel");
            }

            else {


                /////Password

                char[] letters = "q1we2rty3uio4pas5dfgh6jklz7x8cv9bnm0".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 9; i++) //i < # depends how long the password
                {
                    randomString += letters[r.Next(0, 34)].ToString();
                }
                // MessageBox.Show(randomString);




                /////Username

                string fName = FName.Text;
                string mName = Mname.Text;
                string lName = Lname.Text;

                string usernameFormat = String.Format("{0}_" + "{1}" + "{2}", lName.ToLower(), fName.Substring(0, 3), mName.Substring(0, 1));

                // MessageBox.Show(usernameFormat);





                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into participant(fullname,p_username,p_password,F_name,M_name,L_name) Values('" + fName + " " + mName + " " + lName + "','" + usernameFormat + "','" + randomString + "','" + fName + "','" + mName + "','" + lName + "')", con);
                int n = cmd.ExecuteNonQuery();
                con.Close();


                if (n > 0)
                {
                    Dialogue.Show("Successfully Created", "", "Ok", "Cancel");
                    FName.Text = null;
                    Mname.Text = null;
                    Lname.Text = null;
                    

                }

                else
                {
                    Dialogue.Show("Failed! Please Retry", "", "Ok", "Cancel");
                }

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

        ////

    }
}
