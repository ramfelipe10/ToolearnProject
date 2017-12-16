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
        public CreateClassroom()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stephen_Kent\Documents\crud2.mdf;Integrated Security=True;Connect Timeout=30");

        private void CreateClassroom_Load(object sender, EventArgs e)
        {

        }

        private void buttonADDClassroom_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO classroom (classroom_id, classroom_name) VALUES ('" + textBoxCreateClassroom.Text + "')";
            comboBoxClassroomList.Items.Add(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Classroom Created!");
        }

        private void buttonADDParticipant_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO participant (participant_id, name) VALUES ('" + textBoxAddParticipant.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Participant Added!");
        }
    }
}
