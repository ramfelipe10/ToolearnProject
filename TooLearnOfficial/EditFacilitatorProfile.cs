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
    public partial class EditFacilitatorProfile : Form
    {


        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public EditFacilitatorProfile()
        {
            InitializeComponent();
            load_account();
        }


        void load_account()
        {

            try
            {
                          
                
                SqlDataAdapter sda = new SqlDataAdapter("Select name,username,password from facilitator Where facilitator_id='" + Program.user_id + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    fullname.Text = dt.Rows[0][0].ToString();
                    username.Text = dt.Rows[0][1].ToString();
                    password.Text = dt.Rows[0][2].ToString();
                }
                else { }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void MyAccountEdit_Click(object sender, EventArgs e)
        {


            switch (MyAccountEdit.Text)
            {
                case "Edit":
                    {
                        fullname.Enabled = true;
                        username.Enabled = true;
                        password.Enabled = true;
                        MyAccountEdit.Text = "Save";
                        password.isPassword = false;

                    }
                    break;

                case "Save":
                    {

                        if (fullname.Text != "" && username.Text != "" && password.Text != "")
                        {
                            fullname.Enabled = false;
                            username.Enabled = false;
                            password.Enabled = false;
                            MyAccountEdit.Text = "Edit";




                            con.Open();
                            String query = "UPDATE facilitator SET name= '" + fullname.Text + "', username='" + username.Text + "', password = '" + password.Text + "' WHERE facilitator_id= '" + Program.user_id + "' ";
                            SqlDataAdapter sda = new SqlDataAdapter(query, con);
                            int n = sda.SelectCommand.ExecuteNonQuery();

                            con.Close();

                            password.isPassword = true;

                            load_account();
                        }

                        else
                        {
                            Dialogue.Show("Please Fill all Fields!", "", "Ok", "Cancel");
                        }

                    }
                    break;
            }


        }



    }
}
