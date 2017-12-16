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
        public CreateFacilitator()
        {
            InitializeComponent();
        }

        private void TextboxUsername_OnValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stephen_Kent\Documents\TooLearnDatabase.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (int.Parse(dt.Rows[0][0].ToString()) == 0)
            {
                labelAvailableUsername.Text = TextboxUsername.Text + " is Available";
                this.labelAvailableUsername.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelAvailableUsername.Text = TextboxUsername.Text + " is Not Available";
                this.labelAvailableUsername.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ButtonFacilitatorCreateAccount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stephen_Kent\Documents\TooLearnDatabase.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            if (labelAvailableUsername.ForeColor == System.Drawing.Color.Green)
            {
                if (TextboxPassword.Text == TextboxReTypePassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into facilitator(name, username, password) Values('" + TextboxName.Text + "','" + TextboxPassword.Text + "','" + TextboxReTypePassword.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Inserted");
                    con.Close();

                    this.Hide();

                    FacilitatorLogin cf = new FacilitatorLogin();
                    cf.Show();

                }
                else
                {
                    MessageBox.Show("Your Password does not Match");
                }
            }
            else
            {
                MessageBox.Show("Please use Available Username");
            }
        }

        
    }
}
