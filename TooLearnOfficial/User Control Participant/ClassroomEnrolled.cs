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
    public partial class ClassroomEnrolled : UserControl
    {
        public ClassroomEnrolled()
        {
            InitializeComponent();
            load_data();
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




        void load_data()
        {

            try
            {

                //Alternative
                SqlConnection con = new SqlConnection();
        con.ConnectionString = Helper.ConnectionString;

                //Alternative-End

                SqlDataAdapter sda = new SqlDataAdapter("SELECT class_name AS Classroom from classrooms c,classlist cl where c.class_id=cl.class_id AND cl.participant_id='" + Program.par_id + "'", con);


                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    BindingSource bs = new BindingSource();
        bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel1.Text = "Empty";


                }


                else
                {
                    BindingSource bs = new BindingSource();
    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel1.Text = "";
                    
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


    }

        private void ClassroomEnrolled_Load(object sender, EventArgs e)
        {

        }
    }
}
