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
    public partial class EditParticipantProfile : Form
    {

        //SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        SqlConnection con = new SqlConnection("Data Source='" + Program.source + "' ; Initial Catalog='" + Program.db + "'; User ID='" + Program.id + "';Password='" + Program.password + "'");

        public EditParticipantProfile()
        {
            InitializeComponent();
            load_account();
        }


        void load_account()
        {

            try
            {


                SqlDataAdapter sda = new SqlDataAdapter("Select fullname,p_username,p_password from participant Where participant_id='" + Program.par_id + "' ", con);
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

                            DialogResult result = Dialogue1.Show("Are you sure ?", "", "Ok", "Cancel");
                            if (result == DialogResult.Yes)
                            {

                                fullname.Enabled = false;
                                username.Enabled = false;
                                password.Enabled = false;
                                MyAccountEdit.Text = "Edit";




                                con.Open();
                                String query = "UPDATE participant SET fullname= '" + fullname.Text + "', p_username='" + username.Text + "', p_password = '" + password.Text + "' WHERE participant_id= '" + Program.par_id + "' ";
                                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                int n = sda.SelectCommand.ExecuteNonQuery();

                                con.Close();

                                password.isPassword = true;

                                load_account();


                            }
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

