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

    public partial class GameFacilitator : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        string i;
        int time;
        public GameFacilitator()
        {
            InitializeComponent();
        

        }

        private string ScalarReturn(string q)
        {
            string s;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, con);

                s = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                s = "";
            }
            con.Close();
            return s;

        }

        private void GameFacilitator_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            i = (ScalarReturn("Select min(quiz_id) from QuestionAnswers"));

            LabelTimer.Text = ScalarReturn("select QA_time_limit from QuestionAnswers where quiz_id='" + i + "'");

           

            time = Convert.ToInt32(LabelTimer.Text);


            bunifuCircleProgressbar1.Value = time;

         
                timer1.Start();
                bunifuCircleProgressbar1.Value -= 1;

            if (bunifuCircleProgressbar1.Value == 0)
            {
                i = i + 1;
                LabelQuestion.Text = ScalarReturn("select question from QuestionAnswers where quiz_id='" + i + "'");


                timer1.Stop();
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
