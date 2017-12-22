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
    public partial class QuizMultipleChoice : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public QuizMultipleChoice()
        {
            InitializeComponent();
        }

        private void resetAll()
        {
            textBoxQuizQuestion.Text = null;
            textBoxQuizChoiceA.Text = null; textBoxQuizChoiceB.Text = null; textBoxQuizChoiceC.Text = null; textBoxQuizChoiceD.Text = null;
            textBoxRightAnswer.Text = null;
        }
        private void enableFields()
        {
            textBoxQuizQuestion.Enabled = true;
            textBoxQuizChoiceA.Enabled = true; textBoxQuizChoiceB.Enabled = true; textBoxQuizChoiceC.Enabled = true; textBoxQuizChoiceD.Enabled = true;
            dataGridViewQuestion.Enabled = true;
        }
        private void disableFields()
        {
            textBoxQuizQuestion.Enabled = false;
            textBoxQuizChoiceA.Enabled = false; textBoxQuizChoiceB.Enabled = false; textBoxQuizChoiceC.Enabled = false; textBoxQuizChoiceD.Enabled = false;
        }
        private void QuizMultipleChoice_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            comboBoxQuizSubject.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select class_name from classrooms order by class_id asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxQuizSubject.Items.Add(dr["class_name"].ToString());
            }
            con.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }


        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (textBoxQuizChoiceA.Text == textBoxRightAnswer.Text)
            {
                con.Open();
                String query1 = "INSERT INTO quiz_multiple_choice(question, choice_a, choice_b, choice_c, choice_d, right_answer) VALUES ('" + textBoxQuizQuestion.Text + "', '" + textBoxQuizChoiceA.Text + "', '" + textBoxQuizChoiceB.Text + "', '" + textBoxQuizChoiceC.Text + "', '" + textBoxQuizChoiceD.Text + "', '" + textBoxRightAnswer.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                //MessageBox.Show("Question Created!");
                con.Close();

            }
            else if (textBoxQuizChoiceB.Text == textBoxRightAnswer.Text)
            {
                con.Open();
                String query2 = "INSERT INTO quiz_multiple_choice(question, choice_a, choice_b, choice_c, choice_d, right_answer) VALUES ('" + textBoxQuizQuestion.Text + "', '" + textBoxQuizChoiceA.Text + "', '" + textBoxQuizChoiceB.Text + "', '" + textBoxQuizChoiceC.Text + "', '" + textBoxQuizChoiceD.Text + "', '" + textBoxRightAnswer.Text + "')";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                sda2.SelectCommand.ExecuteNonQuery();
                //MessageBox.Show("Question Created!");
                con.Close();

            }
            else if (textBoxQuizChoiceC.Text == textBoxRightAnswer.Text)
            {
                con.Open();
                String query3 = "INSERT INTO quiz_multiple_choice(question, choice_a, choice_b, choice_c, choice_d, right_answer) VALUES ('" + textBoxQuizQuestion.Text + "', '" + textBoxQuizChoiceA.Text + "', '" + textBoxQuizChoiceB.Text + "', '" + textBoxQuizChoiceC.Text + "', '" + textBoxQuizChoiceD.Text + "', '" + textBoxRightAnswer.Text + "')";
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
                sda3.SelectCommand.ExecuteNonQuery();
                //MessageBox.Show("Question Created!");
                con.Close();

            }
            else if (textBoxQuizChoiceD.Text == textBoxRightAnswer.Text)
            {
                con.Open();
                String query4 = "INSERT INTO quiz_multiple_choice(question, choice_a, choice_b, choice_c, choice_d, right_answer) VALUES ('" + textBoxQuizQuestion.Text + "', '" + textBoxQuizChoiceA.Text + "', '" + textBoxQuizChoiceB.Text + "', '" + textBoxQuizChoiceC.Text + "', '" + textBoxQuizChoiceD.Text + "', '" + textBoxRightAnswer.Text + "')";
                SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                sda4.SelectCommand.ExecuteNonQuery();
                //MessageBox.Show("Question Created!");
                con.Close();

            }
            else
            {
                MessageBox.Show("The correct answer does not Match");
            }
            //ADD
            con.Open();
            String query = "SELECT question, choice_a, choice_b, choice_c, choice_d, right_answer FROM quiz_multiple_choice";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewQuestion.DataSource = dt;
            con.Close();
            resetAll();
        }

        private void dataGridViewInformation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxQuizQuestion.Text = dataGridViewQuestion.SelectedRows[0].Cells[1].Value.ToString();
            textBoxQuizChoiceA.Text = dataGridViewQuestion.SelectedRows[0].Cells[2].Value.ToString();
            textBoxQuizChoiceB.Text = dataGridViewQuestion.SelectedRows[0].Cells[3].Value.ToString();
            textBoxQuizChoiceC.Text = dataGridViewQuestion.SelectedRows[0].Cells[4].Value.ToString();
            textBoxQuizChoiceD.Text = dataGridViewQuestion.SelectedRows[0].Cells[5].Value.ToString();
            textBoxRightAnswer.Text = dataGridViewQuestion.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
