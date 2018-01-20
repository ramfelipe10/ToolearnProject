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
    public partial class MyClassParticipant : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public MyClassParticipant()
        {
            InitializeComponent();
            load_data();
        }


        void load_data()
        {

            try
            {
                comboBox1.Items.Clear();


                SqlCommand cmd = new SqlCommand("SELECT class_name from classrooms c, classlist cl where c.class_id = cl.class_id AND cl.participant_id = '" + Program.par_id + "'", con);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


                SqlDataAdapter sda = new SqlDataAdapter("select fullname AS 'Name' from participant p,classlist cl where p.participant_id=cl.participant_id AND class_id=(select class_id from classrooms where class_name = '" + comboBox1.SelectedItem + "') ", con);
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
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
