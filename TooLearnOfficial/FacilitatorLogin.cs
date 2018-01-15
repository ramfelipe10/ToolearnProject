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

                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    //
                    SqlDataAdapter adapt = new SqlDataAdapter("Select facilitator_id From facilitator Where username='" + TextboxUsername.Text + "' ", con);
                    DataTable data = new DataTable();
                    adapt.Fill(data);
                    int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Facilitator
                    //

                    Program.ID = ID.ToString();

                    Program.Session_id = TextboxUsername.Text; //For Session
                    Dialogue.Show("Login Successful!", "", "Ok", "Cancel");
                    this.Hide();

                    MainMenu mm = new MainMenu();
                    mm.Show();
                }
                else
                {

                    Dialogue.Show("Login Failed!   Please Check your Username and Password!", "", "Ok", "Cancel");
                    //MessageBox.Show("Please Check your Username and Password");
                }



            }



           
                 catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void passbox_OnValueChanged(object sender, EventArgs e)
        {
            if (passbox.Text.Length <= 0)
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

                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        Program.Session_id = TextboxUsername.Text; //For Session
                        Dialogue.Show("Login Successful!", "", "Ok", "Cancel");
                        this.Hide();

                        MainMenu mm = new MainMenu();
                        mm.Show();
                    }
                    else
                    {

                        Dialogue.Show("Login Failed!   Please Check your Username and Password!", "", "Ok", "Cancel");
                        //MessageBox.Show("Please Check your Username and Password");
                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void passbox_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From facilitator Where username='" + TextboxUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and password= '" + passbox.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Program.Session_id = TextboxUsername.Text; //For Session

                        Dialogue.Show("Login Successful!", "", "Ok", "Cancel");
                        this.Hide();

                        MainMenu mm = new MainMenu();
                        mm.Show();
                    }
                    else
                    {

                        Dialogue.Show("Login Failed!   Please Check your Username and Password!", "", "Ok", "Cancel");
                        //MessageBox.Show("Please Check your Username and Password");
                    }



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }




    }
    }

