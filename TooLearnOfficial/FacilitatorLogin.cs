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
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public FacilitatorLogin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    SqlCommand cmd = new SqlCommand("Select facilitator_id from facilitator where username='" + TextboxUsername1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Program.user_id = Convert.ToInt32(dr["facilitator_id"]);

                    }
                    dr.Close();
                    con.Close();
                                                         

                    Program.Session_id = TextboxUsername1.Text; //For Session
                  
                        this.Hide();

                        MainMenu mm = new MainMenu();
                        mm.Show();
                   
                }
                else
                {

                    Dialogue.Show("Login Failed!   Please Check your Username and Password!", "", "Ok", "Cancel");
                   
                }


            }

           
                 catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");

            }


        }

        private void FacilitatorLogin_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select username from facilitator", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            while(dr.Read())
            {
                auto.Add(dr.GetString(0));
            }
            TextboxUsername1.AutoCompleteCustomSource = auto;
            con.Close();
        }

        private void ButtonFacilitatorCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreateFacilitator cf = new CreateFacilitator();
            cf.Show();
        }   

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (passbox1.isPassword == true)
            {
                passbox1.isPassword = false;

            }

            else
            {

                passbox1.isPassword = true;

            }

        }

        private void passbox_OnValueChanged(object sender, EventArgs e)
        {
            if (passbox1.Text.Length <= 0)
            {
                bunifuImageButton1.Visible = false;
            }

            else
            {
                bunifuImageButton1.Visible = true;
            }
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

        private void TextboxUsername_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {


                        SqlCommand cmd = new SqlCommand("Select facilitator_id from facilitator where username='" + TextboxUsername1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);

                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Program.user_id = Convert.ToInt32(dr["facilitator_id"]);

                        }
                        dr.Close();
                        con.Close();

                        Program.Session_id = TextboxUsername1.Text; //For Session

                        this.Hide();

                        MainMenu mm = new MainMenu();
                        mm.Show();
                    }
                    else
                    {

                        Dialogue.Show("Login Failed!   Please Check your Username and Password!", "", "Ok", "Cancel");
    
                    }


                }


                catch (Exception ex)
                {
                    Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");

                }

                e.SuppressKeyPress = true;
            }


        }

        private void passbox_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {


                        SqlCommand cmd = new SqlCommand("Select facilitator_id from facilitator where username='" + TextboxUsername1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);

                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Program.user_id = Convert.ToInt32(dr["facilitator_id"]);

                        }
                        dr.Close();
                        con.Close();


                        Program.Session_id = TextboxUsername1.Text; //For Session

               
                        this.Hide();

                        MainMenu mm = new MainMenu();
                        mm.Show();
                    }
                    else
                    {

                        Dialogue.Show("Login Failed!   Please Check your Username and Password!", "", "Ok", "Cancel");
                      
                    }



                }

                catch (Exception ex)
                {
                    Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");


                }

                e.SuppressKeyPress = true;

            }

        }




    }
    }

