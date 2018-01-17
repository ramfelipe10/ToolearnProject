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
    public partial class GameParticipant : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
       string i;
        string correct;
        public GameParticipant()
        {
            InitializeComponent();
        }

        private void GameParticipant_Load(object sender, EventArgs e)
        {

            /*   SqlDataAdapter sda = new SqlDataAdapter("Select min(quiz_id) from QuestionAnswers", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);

               i = Convert.ToInt32(dt.Rows[0][0].ToString());
    */
            i = (ScalarReturn("Select min(quiz_id) from QuestionAnswers"));

            LabelQuestion.Text =ScalarReturn ("select question from QuestionAnswers where quiz_id='"+ i + "'");
            bunifuFlatButton1.Text = ScalarReturn("select answer_a from QuestionAnswers where quiz_id='" + i + "'");
            bunifuFlatButton2.Text = ScalarReturn("select answer_b from QuestionAnswers where quiz_id='" + i + "'");
            bunifuFlatButton3.Text = ScalarReturn("select answer_c from QuestionAnswers where quiz_id='" + i + "'");
            bunifuFlatButton4.Text = ScalarReturn("select answer_d from QuestionAnswers where quiz_id='" + i + "'");
            correct = ScalarReturn("select correct_answer from QuestionAnswers where quiz_id='" + i + "'");
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
            catch(Exception)
            {
                s = "";
            }
            con.Close();
            return s;

        }
    }
}
