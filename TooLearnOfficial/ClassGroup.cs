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
    public partial class ClassGroup : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public static string SetValueForText1 = "", SetValueForText2 = "", SetValueForText3 = "";
        string Class,GroupName;

        public ClassGroup()
        {
            InitializeComponent();
            Load_Class();
        }


        public void Load_Group()
        {
            try
            {
                

                SqlDataAdapter sda = new SqlDataAdapter("select group_name,g_username,g_password from groups g,classrooms c where g.class_id=c.class_id AND c.class_id=(select class_id from classrooms where class_name = '" + comboBox1.SelectedItem + "') ", con);
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

                    bunifuCustomDataGrid1.ClearSelection();

                }


            }

            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }
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

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {



                SqlDataAdapter sda = new SqlDataAdapter("select group_name,g_username,g_password from groups g,classrooms c where g.class_id=c.class_id AND c.class_id=(select class_id from classrooms where class_name = '" + comboBox1.SelectedItem + "') ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


               
               

               Class = comboBox1.SelectedItem.ToString();

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

                    bunifuCustomDataGrid1.ClearSelection();

                }

            }

            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                Dialogue.Show("Classroom Not Specified", "", "Ok", "Cancel");
            }

            else
            {
                SetValueForText1 = Class;
                AddGroup AG = new AddGroup();
                AG.ShowDialog();
            }
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {

                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {



                  

                    DialogResult result = Dialogue1.Show("Are You Sure?", "", "Ok", "Cancel");
                    if (result == DialogResult.Yes)
                    {

                        con.Open();

                        String q = "DELETE FROM grouplist WHERE group_id=(select group_id from groups where group_name= '" + GroupName + "')";
                        SqlDataAdapter s = new SqlDataAdapter(q, con);
                        int n = s.SelectCommand.ExecuteNonQuery();


                        String query = "DELETE FROM groups WHERE group_name= '" + GroupName + "' ";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                       int m = sda.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        if (m > 0)
                        {
                            Load_Group();
                            bunifuCustomDataGrid1.ClearSelection();
                 
                            Dialogue.Show("Successfully Deleted!", "", "Ok", "Cancel");

                        }

                        else
                        {
                            Load_Group();
                            Dialogue.Show("Fail to Delete!", "", "Ok", "Cancel");                          
                            bunifuCustomDataGrid1.ClearSelection();                    

                        }
                    }//end if result


                }

                else
                {
                    Dialogue.Show("Nothing Selected", "", "Ok", "Cancel");
                }


            }//try


            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            

                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {

                SetValueForText2 = GroupName;
                SetValueForText3 = Class;

                ViewGroupParticipant VGP = new ViewGroupParticipant();
                VGP.ShowDialog();
                




                }

                else
                {
                    Dialogue.Show("Nothing Selected", "", "Ok", "Cancel");
                }

          


        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)
            {
                GroupName = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();

                
            }

        }

    }
}
