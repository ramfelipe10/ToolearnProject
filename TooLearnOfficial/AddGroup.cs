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
    public partial class AddGroup : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        string classroom = ClassGroup.SetValueForText1;
        
        public AddGroup()
        {
            InitializeComponent();
            
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sed = new SqlDataAdapter("select class_id from classrooms where class_name= '" + classroom + "' ", con);
            DataTable det = new DataTable();
            sed.Fill(det);
            int id = Convert.ToInt32(det.Rows[0][0]);

            SqlDataAdapter adapt = new SqlDataAdapter("select count(group_id) from groups where group_name= '" + GroupNameBox.Text + "' AND class_id= '" + id + "' ", con);
            DataTable dat = new DataTable();
            adapt.Fill(dat);
            int Count = int.Parse(dat.Rows[0][0].ToString());

            if (string.IsNullOrWhiteSpace(GroupNameBox.Text) && GroupNameBox.Text.Length > 0 || GroupNameBox.Text == "")
            {
                Dialogue.Show("Invalid Input or Empty", "", "Ok", "Cancel");
            }


            else if (Count != 0)
            {

                Dialogue.Show("Group Already Exist!", "", "Ok", "Cancel");
            }


            else
            {
                char[] letters = "q1we2rty3uio4pas5dfgh6jklz7x8cv9bnm0".ToCharArray();
                Random r = new Random();
                string Pass = "";
                for (int i = 0; i < 4; i++) //i < # depends how long the password
                {
                    Pass += letters[r.Next(0, 34)].ToString();
                }


                string usernameFormat = String.Format("{0}", GroupNameBox.Text.ToLower());

                SqlDataAdapter sd = new SqlDataAdapter("select class_id from classrooms where class_name= '" + classroom + "' ", con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                int ID = Convert.ToInt32(dt.Rows[0][0]);

                con.Open();
                String query = "INSERT INTO groups (group_name,g_username,g_password,class_id) VALUES ('" + GroupNameBox.Text + "','" +usernameFormat+ "','" +Pass+ "',' " + ID + " ')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                int n = sda.SelectCommand.ExecuteNonQuery();

                con.Close();

                if (n > 0)
                {

                    ClassGroup CC = (ClassGroup)Application.OpenForms["ClassGroup"];
                    CC.Load_Group();

                    Dialogue.Show("Created", "", "Ok", "Cancel");
                    this.Close();
                }
                else
                {
                    Dialogue.Show("Failed", "", "Ok", "Cancel");
                    this.Close();
                }


            }
        }


    }
}
