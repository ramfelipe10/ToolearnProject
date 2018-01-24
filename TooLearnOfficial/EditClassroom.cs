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
    public partial class EditClassroom : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        string Cname;

        public EditClassroom()
        {
            InitializeComponent();
        }

        private void EditClassroom_Load(object sender, EventArgs e)
        {
            ClassNameBox.Text = CreateMyClassroom.SetValueForText1;
            Cname = CreateMyClassroom.SetValueForText1;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ClassNameBox.Text) && ClassNameBox.Text.Length > 0 || ClassNameBox.Text == "")
            {
                Dialogue.Show("Invalid Input or Empty", "", "Ok", "Cancel");
                
            }//If End



            else
            {
                DialogResult result = Dialogue1.Show("Are You Sure?", "", "Ok", "Cancel");
                if (result == DialogResult.Yes)
                {

                    SqlDataAdapter adapt = new SqlDataAdapter("select class_id from classrooms where class_name= '" + Cname + "'", con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Classroom


                    con.Open();
                    String query = "UPDATE classrooms SET class_name= '" + ClassNameBox.Text + " '  WHERE facilitator_id= '" + Program.user_id + "' AND class_id= '" + ID + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    int n = sda.SelectCommand.ExecuteNonQuery();

                    con.Close();


                    CreateMyClassroom CC = (CreateMyClassroom)Application.OpenForms["CreateMyClassroom"];


                    CC.Load_Class();
                    CC.Load_Participant();



                    this.Close();

                }

                else
                {
                    Dialogue.Show("Fail to Update", "", "Ok", "Cancel");
                }
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
    }
}
