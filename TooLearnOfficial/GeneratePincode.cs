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
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    public partial class GeneratePincode : Form
    {
        public GeneratePincode()
        {
            InitializeComponent();
        }

        

        private void ButtonGeneratePincode_Click(object sender, EventArgs e)
        {
            con.Open();
            //String query = "INSERT INTO classroom (classroom_id, classroom_name) VALUES ('" + textBoxCreateClassroom.Text + "')";

            Random random = new Random();
            int randomNumber = random.Next(101010, 999999 + 1);
            textBoxPincode.Text = Convert.ToString(randomNumber);

            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //sda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        private void GeneratePincode_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPincode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
