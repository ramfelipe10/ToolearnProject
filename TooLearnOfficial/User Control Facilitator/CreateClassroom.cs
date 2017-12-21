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

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public CreateClassroom()
        {
            InitializeComponent();
        }

       

        private void CreateClassroom_Load(object sender, EventArgs e)
        {

        }

        private void buttonADDClassroom_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO classrooms (class_name) VALUES ('" + textBoxCreateClassroom.Text + "')";
            //comboBoxClassroomList.Items.Add(query);   Sala ni Temporary lng ni saka si query mismo ang tgkakaag dapat si sa combo box tlga ma query
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            Dialogue.Show("Classroom Created!", "", "Ok", "Cancel");
        }

        private void buttonADDParticipant_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO participant (participant_id, name) VALUES ('" + textBoxAddParticipant.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            Dialogue.Show("Participant Added!", "", "Ok", "Cancel");
        }

        private void comboBoxClassroomList_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            SqlDataAdapter sda = new SqlDataAdapter("Select  class_name from classrooms", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBoxClassroomList.Items.Add(sda);




        }
    }
}
