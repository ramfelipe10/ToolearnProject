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
    public partial class GroupLogin : Form
    {

        SqlConnection con = new SqlConnection("Data Source='" + Program.source + "' ; Initial Catalog='" + Program.db + "'; User ID='" + Program.id + "';Password='" + Program.password + "'");
        public GroupLogin()
        {
            InitializeComponent();
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

        private void ButtonParticipantSignIn_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From groups Where g_username='" + TextboxUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and g_password= '" + TextboxPassword.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlCommand cmd = new SqlCommand("Select group_id from groups where g_username='" + TextboxUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and g_password= '" + TextboxPassword.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Program.group_id = Convert.ToInt32(dr["group_id"]);

                }
                dr.Close();
                con.Close();

                //Program.PSession_id = TextboxUsername.Text; //For Session
                                                            //  Dialogue.Show("Login Successful!", "", "Ok", "Cancel");
                this.Hide();

                GroupMain mm = new GroupMain();
                mm.Show();
            }
            else
            {
                Dialogue.Show("Login Failed! \r\n Please Check your Username and Password!", "", "Ok", "Cancel");
            }
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

        private void TextboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From groups Where g_username='" + TextboxUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and g_password= '" + TextboxPassword.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        SqlCommand cmd = new SqlCommand("Select group_id from groups where g_username='" + TextboxUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and g_password= '" + TextboxPassword.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);

                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Program.group_id = Convert.ToInt32(dr["group_id"]);

                        }
                        dr.Close();
                        con.Close();

                        //Program.PSession_id = TextboxUsername.Text; //For Session
                        //  Dialogue.Show("Login Successful!", "", "Ok", "Cancel");
                        this.Hide();

                        GroupMain mm = new GroupMain();
                        mm.Show();
                    }
                    else
                    {
                        Dialogue.Show("Login Failed! \r\n Please Check your Username and Password!", "", "Ok", "Cancel");
                    }



                }

                catch (Exception ex)
                {
                    Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");


                }

                e.SuppressKeyPress = true;

            }
        }

        private void GroupLogin_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select g_username from groups", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    auto.Add(dr.GetString(0));
                }
                TextboxUsername.AutoCompleteCustomSource = auto;
                con.Close();


            }


            catch (Exception ex)
            {
                Dialogue.Show(ex.ToString(), "", "Ok", "Cancel");
            }
        }
    }
}
