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
    public partial class CreateMyClassroom : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        string className, participantName;

        public CreateMyClassroom()
        {
            InitializeComponent();
            Load_Class();
        }


        void Load_Class()
        {


            try
            {              

                SqlDataAdapter sda = new SqlDataAdapter("Select class_name from classrooms WHERE facilitator_id='" + Program.user_id + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                bunifuCustomDataGrid1.DataSource = bs;
                sda.Update(dt);
            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            

        }





        void Load_Participant()
        {


            try
            {                           
                 
                SqlDataAdapter sda = new SqlDataAdapter("select fullname AS 'Name' from participant p,classlist cl where p.participant_id=cl.participant_id AND class_id=(select class_id from classrooms where class_name = '" + className + "') ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    label6.Text = "";
                    bunifuCustomLabel1.Visible = true;                   
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid2.DataSource = bs;
                    sda.Update(dt);
                    pictureBox2.Visible = true;
                    label6.Text = "";
                }
                else
                {
                    label6.Text = "Of " + className + " ";
                    bunifuCustomLabel1.Visible = false;
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid2.DataSource = bs;
                    sda.Update(dt);
                    pictureBox2.Visible = true;

                }
                                
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

        private void createC_Click(object sender, EventArgs e)
        {
            if (textBoxCreateClassroom.Text == " ")
            {
                Dialogue.Show("Invalid Input or Empty", "", "Ok", "Cancel");
            }

            else
            {





                con.Open();
                String query = "INSERT INTO classrooms (class_name,facilitator_id) VALUES ('" + textBoxCreateClassroom.Text + "','" + Program.user_id + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                int n = sda.SelectCommand.ExecuteNonQuery();

                con.Close();
                if (n > 0)
                {
                    Dialogue.Show("Classroom Created!", "", "Ok", "Cancel");
                    label6.Text = "";






                }
                else
                {
                    Dialogue.Show("Creation Failed!", "", "Ok", "Cancel");




                }
                className = " ";
                Load_Class();
                textBoxCreateClassroom.Text = " ";

                Load_Participant();


            }

        }

        private void createP_Click(object sender, EventArgs e)
        {

            string selected = comboBox1.SelectedItem.ToString();//Getting the Value From COMBO BOX


            if (selected == "")
            {
                Dialogue.Show("Invalid Input or Empty", "", "Ok", "Cancel");
            }


            else
            {
                SqlDataAdapter adapt = new SqlDataAdapter("Select class_id from classrooms WHERE class_name = '" + className + "' ", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                int ID = int.Parse(dt.Rows[0][0].ToString()); //Getting the ID of The Classroom


                SqlDataAdapter add = new SqlDataAdapter("Select participant_id from participant WHERE fullname = '" + selected + "' ", con);
                DataTable data = new DataTable();
                add.Fill(data);
                int id = int.Parse(data.Rows[0][0].ToString());//Getting the ID of The Participant

                try
                {

                    con.Open();
                    
                    String query = "INSERT INTO classlist (participant_id,class_id,facilitator_id) VALUES ('" + id + "','" + ID + "','" + Program.user_id + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    int n = sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    if (n > 0)
                    {
                        Dialogue.Show("Participant Added!", "", "Ok", "Cancel");
                    }
                    
                    else
                    {
                        Dialogue.Show("Fail to Add!", "", "Ok", "Cancel");
                    }
                    Load_Participant();
                   

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void textBoxCreateClassroom_Enter(object sender, EventArgs e)
        {


            bunifuCustomDataGrid1.ClearSelection();



            comboBox1.Enabled = false;
            createP.Enabled = false;
            bunifuCustomDataGrid2.Enabled = false;
            editP.Enabled = false;
            deleteP.Enabled = false;
            pictureBox2.Visible = false;

            if (this.bunifuCustomDataGrid2.DataSource != null)
            {
                this.bunifuCustomDataGrid2.DataSource = null;
            }
            else
            {
                this.bunifuCustomDataGrid2.Rows.Clear();
            }

        }

        private void deleteC_Click(object sender, EventArgs e)
        {
            try
            {

                if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
                {



                    SqlDataAdapter adapt = new SqlDataAdapter("select class_id from classrooms where class_name= '" + className + "'", con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Classroom


                    DialogResult result = Dialogue1.Show("Are You Sure?", "", "Ok", "Cancel");
                    if (result == DialogResult.Yes)
                    {

                        con.Open();

                        String qer = "DELETE FROM classlist WHERE class_id= '" + ID + "' ";
                        String query = "DELETE FROM classrooms WHERE class_name= '" + className + "' AND facilitator_id = '" + Program.user_id + "' ";
                        SqlDataAdapter sad = new SqlDataAdapter(qer, con);
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        int n = sad.SelectCommand.ExecuteNonQuery();
                        int m = sda.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        if (n >= 0 && m > 0)
                        {
                            Load_Class();
                            Load_Participant();
                            Dialogue.Show("Successfully Deleted!", "", "Ok", "Cancel");

                        }

                        else
                        {
                            Dialogue.Show("Fail to Delete!", "", "Ok", "Cancel");
                            Load_Class();
                            Load_Participant();
                        }
                    }//end if result


                }

                else
                {
                    Dialogue.Show("Nothing Selected", "", "Ok", "Cancel");
                }


            }//try


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void deleteP_Click(object sender, EventArgs e)
        {

            if (bunifuCustomDataGrid2.SelectedCells.Count > 0)
            {

                SqlDataAdapter adapt = new SqlDataAdapter("select class_id from classrooms where class_name= '" + className + "'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Classroom




                SqlDataAdapter add = new SqlDataAdapter("select participant_id from participant where fullname= '" + participantName + "'", con);
                DataTable data = new DataTable();
                add.Fill(data);
                int id = int.Parse(data.Rows[0][0].ToString());//Getting the ID of The Participant



                DialogResult result = Dialogue1.Show("Are You Sure?", "", "Ok", "Cancel");
                if (result == DialogResult.Yes)
                {

                    con.Open();


                    String query = "DELETE FROM classlist WHERE class_id= '" + ID + "' AND facilitator_id = '" + Program.user_id + "' AND participant_id= '" + id + "' ";

                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

                    int m = sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    if (m > 0)
                    {

                        Load_Class();
                        Load_Participant();
                        Dialogue.Show("Successfully Deleted!", "", "Ok", "Cancel");

                    }


                    else
                    {
                        Dialogue.Show("Fail to Delete!", "", "Ok", "Cancel");
                        Load_Class();
                        Load_Participant();
                    }
                }//end if result

            }

            else
            {
                Dialogue.Show("Nothing Selected", "", "Ok", "Cancel");
            }


        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid2.CurrentRow.Index != -1)
            {
                participantName = bunifuCustomDataGrid2.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)
            {
                className = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();

                Load_Participant();


                comboBox1.Enabled = true;
                createP.Enabled = true;
                bunifuCustomDataGrid2.Enabled = true;
                editP.Enabled = true;
                deleteP.Enabled = true;


                comboBox1.Items.Clear();

            }


            try
            {
                             
                SqlDataAdapter adapt = new SqlDataAdapter("Select class_id from classrooms WHERE class_name = '" + className + "' ", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Classroom




                SqlCommand cmd = new SqlCommand("Select DISTINCT fullname from participant p left join classlist cl on p.participant_id =cl.participant_id where cl.class_id != '" + ID + "' OR cl.class_id IS NULL", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["fullname"]);

                }
                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }




        }





    }
}
