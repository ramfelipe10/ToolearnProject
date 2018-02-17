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
    public partial class EditQuizBEE : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlConnection con2 = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public EditQuizBEE()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EditQuizBEE_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM quizzes WHERE quiz_id = '114' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {

                textBoxQuizTitle.Text = (string)dr[("quiz_title")];
                textBox7.Text = Convert.ToString((int)dr[("quiz_time_limit")]);

                try
                {
                    con2.Open();
                    SqlCommand cd = new SqlCommand("SELECT * FROM quizzes WHERE quiz_id = '114' ", con2);
                    SqlDataReader d = cd.ExecuteReader();
                    while (d.Read() == true)
                    {
                        ListViewItem exams = new ListViewItem();
                        exams.Text = (string)dr[("quiz_title")];
                        exams.SubItems.Add(Convert.ToString((int)dr[("quiz_time_limit")]));
                        // exams.SubItems.Add((string)dr[("answer_b")]);
                        // exams.SubItems.Add((string)dr[("answer_c")]);
                        // exams.SubItems.Add((string)dr[("answer_d")]);
                        //  exams.SubItems.Add((string)dr[("correct_answer")]);
                        //
                        exams.SubItems.Add("hahahahaha");
                        exams.SubItems.Add("hahahahaha");
                        exams.SubItems.Add("hahahahaha");

                        //  exams.SubItems.Add(textBox11.Text);
                        //   exams.SubItems.Add(textBox2.Text);
                        //
                        MultipleChoiceLV.Items.Add(exams);
                    }
                }


                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }


    }
}
