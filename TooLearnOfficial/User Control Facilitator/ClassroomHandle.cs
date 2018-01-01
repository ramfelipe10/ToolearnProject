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

namespace TooLearnOfficial.User_Control
{
    public partial class ClassroomHandle : UserControl
    {
        public ClassroomHandle()
        {
            InitializeComponent();
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






        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                //Alternative
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Helper.ConnectionString;

                //Alternative-End
                string selected = comboBox1.SelectedItem.ToString();

                //SqlDataAdapter sda = new SqlDataAdapter("SELECT participant_name FROM participant WHERE class_id=(SELECT class_id FROM classrooms WHERE class_name='" + comboBox1.SelectedItem + "' )", con);
                SqlDataAdapter sda = new SqlDataAdapter("select p_username AS 'Username',p_password AS 'Password',F_name AS 'First Name',L_name AS 'Last Name' from participant p,classlist cl where p.participant_id=cl.participant_id AND class_id=(select class_id from classrooms where class_name = '" + comboBox1.SelectedItem + "') ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel1.Visible = true;
                }


                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel1.Visible = false;
                }

            }

            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
            }

        }

        private void ClassroomHandle_Load(object sender, EventArgs e)
        {

            try
            {


                //Alternative
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Helper.ConnectionString;

                //Alternative-End

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT class_name FROM classrooms";
                cmd.Connection = con;

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["class_name"]);
                }
                dr.Close();
                con.Close();
            }

            catch(Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddParticipantAccount pa = new AddParticipantAccount();
            pa.Show();
            this.Hide();
        }
    }
}
