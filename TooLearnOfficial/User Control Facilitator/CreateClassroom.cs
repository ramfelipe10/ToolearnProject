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


namespace TooLearnOfficial.User_Control_Facilitator
{
    public partial class CreateClassroom : UserControl
    {
        string className;
     //SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public CreateClassroom()
        {
            InitializeComponent();
            load_class();
        }

       

        private void CreateClassroom_Load(object sender, EventArgs e)
        {

        }

//Alternative
        static class Helper {
            public static string ConnectionString {
                get {
                    string str = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                return str;
                }
            }
        }
 //Alternative

        void load_class()
       {
            

                        try
                        {

                //Alternative
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Helper.ConnectionString;

            //Alternative-End

                            SqlDataAdapter sda = new SqlDataAdapter("Select class_name from classrooms", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            BindingSource bs = new BindingSource();
                            bs.DataSource = dt;
                            bunifuCustomDataGrid1.DataSource = bs;
                            sda.Update(dt);
                        }

                        catch (Exception ex)
                        {
                           // MessageBox.Show(ex.Message);
                        }  
                        
        }





        void load_participant()
        {


            try
            {

                //Alternative
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Helper.ConnectionString;

                //Alternative-End

                // SqlDataAdapter sda = new SqlDataAdapter("Select participant_name from participant Where class_id = (select class_id from classrooms where class_name = '" + className + "' )", con);
                SqlDataAdapter sda = new SqlDataAdapter("select F_name AS 'First Name',L_name AS 'Last Name' from participant p,classlist cl where p.participant_id=cl.participant_id AND class_id=(select class_id from classrooms where class_name = '" + className + "') ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    label6.Text = "";
                    Dialogue.Show("Classroom Empty!", "", "Ok", "Cancel");
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid2.DataSource = bs;
                    sda.Update(dt);
                    pictureBox2.Visible = false;
                    label6.Text = "";
                }
                else
                {
                    label6.Text = "Of " + className + " ";
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid2.DataSource = bs;
                    sda.Update(dt);
                    pictureBox2.Visible = true;
                    
                }


                

            }

            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

        }


      

        private void createC_Click(object sender, EventArgs e)
        {
            //
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Helper.ConnectionString;
            //
            con.Open();
            String query = "INSERT INTO classrooms (class_name) VALUES ('" + textBoxCreateClassroom.Text + "')";
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
            className = "";
            load_class();
            textBoxCreateClassroom.Text = "";
            
            load_participant();
        }

        private void createP_Click(object sender, EventArgs e)
        {
            //
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Helper.ConnectionString;
            //

            SqlDataAdapter adapt = new SqlDataAdapter("Select class_id from classrooms WHERE class_name = '" + className + "' ", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            int ID = int.Parse(dt.Rows[0][0].ToString());

           




            con.Open();

           
            String query = "INSERT INTO participant (participant_name,class_id) VALUES ('" + textBoxAddParticipant.Text + "','" + ID + "')";
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
            load_participant();
            textBoxAddParticipant.Text = "";
        }

       

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)
            {
                className = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                
                load_participant();
            }
        }





    }
}
