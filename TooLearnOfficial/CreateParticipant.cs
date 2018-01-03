﻿using System;
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
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
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
            con.Open();
            if (labelAvailableUsername.ForeColor == System.Drawing.Color.Green)
            {
                if (TextboxPassword.Text == TextboxReTypePassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into participant(F_name, p_username, p_password) Values('" + TextboxName.Text + "','" + TextboxUsername.Text + "','" + TextboxPassword.Text + "')", con);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextboxPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TextboxReTypePassword_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
