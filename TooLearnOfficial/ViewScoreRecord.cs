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
    public partial class ViewScoreRecord : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public ViewScoreRecord()
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

        private void ViewScoreRecord_Load(object sender, EventArgs e)
        {

            /*SqlDataAdapter adapt = new SqlDataAdapter("Select quiz_title,", con);
            adapt.Fill(dt);
            NoOfITems = dt.Rows.Count;//6 rows  */


            int TotalNumberofQuiz;
            int TotalScoreonQuiz = 0;
            float average;

            for(int i = 0; i < DataGridViewGrade.Rows.Count; ++i)
            {
                TotalScoreonQuiz += Convert.ToInt32(DataGridViewGrade.Rows[i].Cells[0].Value);  
            }
            //label_average.Text += TotalScoreonQuiz.ToString();

            TotalNumberofQuiz = DataGridViewGrade.Rows.Count;
            average = TotalScoreonQuiz / TotalNumberofQuiz;

            label_average.Text += TotalScoreonQuiz.ToString();

            //if(average >= 90)
            //{
            //    label_pass_or_fail.Text = "A";
            //}
            //else if(average >= 90)
            //{
            //    label_pass_or_fail.Text = "B";
            //}
            //else if (average >= 70)
            //{
            //    label_pass_or_fail.Text = "C";
            //}
            //else if (average <= 74)
            //{
            //    label_pass_or_fail.Text = "F";
            //}
            //else
            //{

            //}
        }
    }
}
