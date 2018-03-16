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
    public partial class SelectClassroom : Form
    {

        public static string ID;
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public SelectClassroom()
        {
            InitializeComponent();
            Load_Class();
        }




        void Load_Class()
        {

            try
            {
                comboBox1.Items.Clear();


                SqlCommand cmd = new SqlCommand("Select class_name from classrooms WHERE facilitator_id= '" + Program.user_id + "' ", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["class_name"]);
                }
                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }


        }




        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SelectClassroom_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                SqlDataAdapter cd = new SqlDataAdapter("SELECT class_id FROM classrooms where class_name='" + comboBox1.SelectedItem.ToString() + "' ", con);
                DataTable dt = new DataTable();
                cd.Fill(dt);
                ID = dt.Rows[0][0].ToString();

                GameSettings LF = new GameSettings();
                LF.ShowDialog();
            }
            else
            {
                Dialogue.Show("Select Class First.", "", "Ok", "Cancel");
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
