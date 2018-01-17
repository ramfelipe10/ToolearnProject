using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TooLearnOfficial.User_Control_Participant
{
    public partial class AccountParticipant : UserControl
    {
        public AccountParticipant()
        {
            InitializeComponent();
            load_account();
        }




        //Alternative
        static class Helper
        {
            public static string ConnectionString
            {
                get
                {
                    string str = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                    return str;
                }
            }
        }
        //Alternative 

        void load_account()
        {

            try
            {

                //Alternative
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Helper.ConnectionString;

                //Alternative-End


                SqlDataAdapter sda = new SqlDataAdapter("Select fullname,p_username,p_password from participant Where p_username='" + Program.PSession_id + "' ", con);
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
                MessageBox.Show(ex.Message.ToString());
            }
        }

  
        private void AccountParticipant_Load(object sender, EventArgs e)
        {

        }

        private void MyAccountEdit_Click_1(object sender, EventArgs e)
        {
            //Alternative
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Helper.ConnectionString;

            //Alternative-End




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
                            String query = "UPDATE participant SET fullname= '" + fullname.Text + "', p_username='" + username.Text + "', p_password = '" + password.Text + "' WHERE participant_id= '" + Program.par_id + "' ";
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
