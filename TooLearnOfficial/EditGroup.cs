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
    public partial class EditGroup : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        string Gname,Cname;

        public EditGroup()
        {
            InitializeComponent();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EditGroup_Load(object sender, EventArgs e)
        {
            GroupNameBox.Text = ClassGroup.SetValueForText4;
            Gname = ClassGroup.SetValueForText4;
            Cname = ClassGroup.SetValueForText3;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
         


            SqlDataAdapter sed = new SqlDataAdapter("select class_id from classrooms where class_name= '" + Cname + "' ", con);
            DataTable det = new DataTable();
            sed.Fill(det);
            int id = Convert.ToInt32(det.Rows[0][0]);


            SqlDataAdapter adapt = new SqlDataAdapter("select count(group_id) from groups where group_name= '" + GroupNameBox.Text + "' AND class_id= '" + id + "'  ", con);
            DataTable dat = new DataTable();
            adapt.Fill(dat);
            int Count = int.Parse(dat.Rows[0][0].ToString());



            if (string.IsNullOrWhiteSpace(GroupNameBox.Text) && GroupNameBox.Text.Length > 0 || GroupNameBox.Text == "")
            {
                Dialogue.Show("Invalid Input or Empty", "", "Ok", "Cancel");

            }//If End

            else if (Count != 0)
            {

                Dialogue.Show("Group Already Exist! Please use Other Name", "", "Ok", "Cancel");
            }

            else
            {
                DialogResult result = Dialogue1.Show("Are You Sure?", "", "Ok", "Cancel");
                if (result == DialogResult.Yes)
                {
                  




                    SqlDataAdapter adapter = new SqlDataAdapter("select group_id from groups where group_name= '" + Gname + "' AND class_id= '" + id + "' ", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Group


                    con.Open();
                    String query = "UPDATE groups SET group_name= '" + GroupNameBox.Text + " '  WHERE group_id= '" + ID + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    int n = sda.SelectCommand.ExecuteNonQuery();

                    con.Close();


                    ClassGroup CG = (ClassGroup)Application.OpenForms["ClassGroup"];


                    CG.Load_Group();                

                    
                    this.Close();

                }

                else
                {
                    Dialogue.Show("Fail to Update", "", "Ok", "Cancel");
                }
            }
        }



    }
}
