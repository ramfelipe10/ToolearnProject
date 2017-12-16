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
        public CreateParticipant()
        {
            InitializeComponent();
        }

        private void ButtonParticipantCreateAccount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stephen_Kent\Documents\TooLearnDatabase.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            if (labelAvailableUsername.ForeColor == System.Drawing.Color.Green)
            {
                if (TextboxPassword.Text == TextboxReTypePassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into participant(name, username, password) Values('" + TextboxName.Text + "','" + TextboxPassword.Text + "','" + TextboxReTypePassword.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Inserted");
                    con.Close();

                    this.Hide();

                    ParticipantLogin cf = new ParticipantLogin();
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

        private void TextboxUsername_OnValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stephen_Kent\Documents\TooLearnDatabase.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            if (labelAvailableUsername.ForeColor == System.Drawing.Color.Green)
            {
                if (TextboxPassword.Text == TextboxReTypePassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into participant(name, username, password) Values('" + TextboxName.Text + "','" + TextboxPassword.Text + "','" + TextboxReTypePassword.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Inserted");
                    con.Close();

                    this.Hide();

                    ParticipantLogin cf = new ParticipantLogin();
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
