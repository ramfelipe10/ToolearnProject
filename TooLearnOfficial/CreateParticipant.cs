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
    public partial class CreateParticipant : Form
    {
       // SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlConnection con = new SqlConnection("Data Source='" + Program.source + "' ; Initial Catalog='" + Program.db + "'; User ID='" + Program.id + "';Password='" + Program.password + "'");
        public CreateParticipant()
        {
            InitializeComponent();
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextboxName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TextboxName_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            ParticipantLogin pl = new ParticipantLogin();
            pl.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TextboxUsername_OnValueChanged_1(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From participant Where p_username='" + TextboxUsername.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (String.IsNullOrWhiteSpace(TextboxUsername.Text))
            {
                labelAvailableUsername.Text = null;
                ErrorImage.Visible = false;
                CheckImage.Visible = false;
            }


            else if (int.Parse(dt.Rows[0][0].ToString()) == 0)
            {
                labelAvailableUsername.Text = TextboxUsername.Text + " is Available";
                this.labelAvailableUsername.ForeColor = System.Drawing.Color.Green;
                ErrorImage.Visible = false;
                CheckImage.Visible = true;

            }




            else if (int.Parse(dt.Rows[0][0].ToString()) > 0)
            {
                labelAvailableUsername.Text = TextboxUsername.Text + " is Not Available";
                this.labelAvailableUsername.ForeColor = System.Drawing.Color.Red;
                CheckImage.Visible = false;
                ErrorImage.Visible = true;
            }


            else { }

        }

        private void CreateParticipant_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFacilitatorCreateAccount_Click(object sender, EventArgs e)
        {


           
            if (TextboxName.Text == "" || TextboxMName.Text == "" || TextboxLName.Text == "" || TextboxUsername.Text == "" || TextboxPassword.Text == "" || TextboxReTypePassword.Text == "")
            {
                Dialogue.Show("Fill All Fields!", "", "Ok", "Cancel");
            }

            else
            {

                if (labelAvailableUsername.ForeColor == System.Drawing.Color.Green)
                {
                    if (TextboxPassword.Text == TextboxReTypePassword.Text)
                    {
                        con.Open();


                        SqlCommand cmd = new SqlCommand("Insert into participant(fullname,F_name, M_name, L_name, p_username, p_password) Values('" + TextboxName.Text + " " + TextboxMName.Text + " " + TextboxLName.Text + "','" + TextboxName.Text + "','" + TextboxMName.Text + "','" + TextboxLName.Text + "','" + TextboxUsername.Text + "','" + TextboxPassword.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        Dialogue.Show("Successfully Inserted", "", "Ok", "Cancel");
                       
                        con.Close();

                        this.Hide();

                        ParticipantLogin cf = new ParticipantLogin();
                        cf.Show();

                    }
                    else
                    {

                        Dialogue.Show("Your Password does not Match", "", "Ok", "Cancel");
                
                    }
                }
                else
                {
                    Dialogue.Show("Please use Available Username", "", "Ok", "Cancel");
                    
                }


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextboxPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TextboxReTypePassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TextboxMName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TextboxLName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
