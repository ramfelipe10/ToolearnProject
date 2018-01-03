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


                SqlDataAdapter sda = new SqlDataAdapter("Select F_name,p_username from participant Where p_username='" + Program.Session_id + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    bunifuMetroTextbox1.Text = dt.Rows[0][0].ToString();
                    accountuname.Text = dt.Rows[0][1].ToString();
                }
                else { }

            }

            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }








    }
}
