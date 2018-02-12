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
    public partial class CreateFacilitator : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public CreateFacilitator()
        {
            InitializeComponent();
        }

        private void TextboxUsername_OnValueChanged(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername.Text + "' ", con);
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

            


            else if(int.Parse(dt.Rows[0][0].ToString()) > 0)
            {
                labelAvailableUsername.Text = TextboxUsername.Text + " is Not Available";
                this.labelAvailableUsername.ForeColor = System.Drawing.Color.Red;
                CheckImage.Visible = false;
                ErrorImage.Visible = true;
            }


            else { }
        }

        private void ButtonFacilitatorCreateAccount_Click(object sender, EventArgs e)
        {
            
            con.Open();
            if (labelAvailableUsername.ForeColor == System.Drawing.Color.Green)
            {
                if (TextboxPassword.Text == TextboxReTypePassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into facilitator(name, username, password) Values('" + TextboxName.Text + "','" + TextboxUsername.Text + "','" + TextboxPassword.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    Dialogue.Show("Successfully Inserted", "", "Ok", "Cancel");
                    con.Close();

                    this.Hide();

                    FacilitatorLogin cf = new FacilitatorLogin();
                    cf.Show();

                }
                else if(TextboxPassword.Text != TextboxReTypePassword.Text)
                {
                    Dialogue.Show("Your Password does not Match", "", "Ok", "Cancel");
                    con.Close();
                }
            }
            else
            {
                Dialogue.Show("Please use Available Username", "", "Ok", "Cancel");
                con.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextboxName_OnValueChanged(object sender, EventArgs e)
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
            FacilitatorLogin fl = new FacilitatorLogin();
            fl.Show();
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextboxReTypePassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextboxPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ErrorImage_Click(object sender, EventArgs e)
        {

        }

        private void CheckImage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAvailableUsername_Click(object sender, EventArgs e)
        {

        }

        private void CreateFacilitator_Load(object sender, EventArgs e)
        {
           
        }
    }
}
