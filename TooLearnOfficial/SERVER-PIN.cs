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

  

    public partial class SERVER_PIN : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);


        public SERVER_PIN()
        {
            InitializeComponent();
            PIN();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PIN()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select PIN from Server ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            pin.Text = dt.Rows[0][0].ToString();
        }
        private void SERVER_PIN_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select PIN from Server ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            pin.Text = dt.Rows[0][0].ToString();
        }

        private void MyAccountEdit_Click(object sender, EventArgs e)
        {
            switch (MyAccountEdit.Text)
            {
                case "Edit":
                    {
                        pin.Enabled = true;

                        MyAccountEdit.Text = "Save";
                       
                    }
                    break;

                case "Save":
                    {

                        if (pin.Text != "")
                        {
                            DialogResult result = Dialogue1.Show("Are you sure ?", "", "Ok", "Cancel");
                            if (result == DialogResult.Yes)
                            {

                                pin.Enabled = false;
                              
                                MyAccountEdit.Text = "Edit";




                                con.Open();
                                String query = "UPDATE SERVER SET PIN= '" + pin.Text + "' ";
                                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                int n = sda.SelectCommand.ExecuteNonQuery();

                                con.Close();

                                PIN();

                            }


                        }

                        else
                        {
                            Dialogue.Show("Please Fill !", "", "Ok", "Cancel");
                        }

                    }
                    break;
            }
    }
    }
}
