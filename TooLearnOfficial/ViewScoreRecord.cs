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

        string PG = ScoreRecordFacilitator.PN;
        string CR = ScoreRecordFacilitator.CR;
        
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

            SqlDataAdapter name= new SqlDataAdapter("select participant_id from participant where fullname='" +PG+ "' " ,con);
            DataTable dt = new DataTable();
            name.Fill(dt);
            string pid=dt.Rows[0][0].ToString();



            SqlDataAdapter classname = new SqlDataAdapter("select class_id from classrooms where class_name='" + CR + "' ", con);
            DataTable data = new DataTable();
            classname.Fill(data);
            string cid = data.Rows[0][0].ToString();

            
           
           

            SqlDataAdapter adaptersd = new SqlDataAdapter("select q.quiz_title AS 'Quiz Title',q.date_created AS 'Date Created',s.quiz_score AS 'Score',q.total_score AS 'Quiz Total Points' from scoreRecords s,quizzes q where q.quiz_id=s.quiz_id AND s.participant_id='"+pid+"'AND s.class_id='" +cid+"' ", con);
            DataTable datasd = new DataTable();
            adaptersd.Fill(datasd);
            BindingSource bs = new BindingSource();
            bs.DataSource = datasd;
            DataGridViewGrade.DataSource = bs;

            labelPName.Text = PG;


                        int TotalNumberofQuiz;
                        
                        int TotalItemsofQuiz = 0;
                        int TotalScoreonQuiz = 0;
                        int average;
                        bunifuCircleProgressbar1.Value = 0;


            //Total Score on Quiz
                        for (int i = 0; i < DataGridViewGrade.Rows.Count; ++i)
                        {
                            TotalScoreonQuiz += Convert.ToInt32(DataGridViewGrade.Rows[i].Cells[2].Value);  
                        }
                        labelTotal.Text += TotalScoreonQuiz.ToString();

                        TotalNumberofQuiz = DataGridViewGrade.Rows.Count;

                        //Total Nuber of Quiz Take
                        labelQuizTake.Text += TotalNumberofQuiz.ToString();

            // Total Number of Quiz Take / Total Items of all the Quiz X 100


            //Total Items of Quiz 
            for (int i = 0; i < DataGridViewGrade.Rows.Count; ++i)
            {
                TotalItemsofQuiz += Convert.ToInt32(DataGridViewGrade.Rows[i].Cells[3].Value);
            }
            //labelTotal.Text += TotalScoreonQuiz.ToString();

            //TotalnumberItemsofQuiz = DataGridViewGrade.Rows.Count - 1;
            


           average = (TotalScoreonQuiz / TotalItemsofQuiz) * 100;

            //average = TotalScoreonQuiz / TotalNumberofQuiz;

                        //Average Grade
                        //label_average.Text += average.ToString();


            bunifuCircleProgressbar1.Value = Convert.ToInt32(average);
            
            



            if (average >= 95 && average <= 100)
            {
                labelLetterGrade.Text = "A"; // Excellent
                labelRemarks.Text = "Excelent";
            }
            else if (average >= 89 && average <= 94)
            {
                labelLetterGrade.Text = "B+"; // Very Good
                labelRemarks.Text = "Very Good";
            }
            else if (average >= 83 && average <= 88)
            {
                labelLetterGrade.Text = "B";  // Very Good
                labelRemarks.Text = "Very Good";
            }
            else if (average >= 77 && average <= 82)
            {
                labelLetterGrade.Text = "C+";  // Good
                labelRemarks.Text = "Good";
            }
            else if (average >= 71 && average <= 76)
            {
                labelLetterGrade.Text = "C";  // Satisfaction
                labelRemarks.Text = "Satisfaction";
            }
            else if (average >= 65 && average <= 70)
            {
                labelLetterGrade.Text = "D+";  // Satisfaction
                labelRemarks.Text = "Satisfaction";
            }
            else if (average >= 60 && average <= 64)
            {
                labelLetterGrade.Text = "D";  // Passed
                labelRemarks.Text = "Passed";
            }
            else
            {
                labelLetterGrade.Text = "F"; // Failed
                labelRemarks.Text = "Failed";
            }

            // Count Passed and Failed Quizzes
            int a = 0, b = 0;
            for (int i = 0; i < DataGridViewGrade.Rows.Count; ++i)
            {              
                if (((Convert.ToInt32(DataGridViewGrade.Rows[i].Cells[2].Value) / (Convert.ToInt32(DataGridViewGrade.Rows[i].Cells[3].Value))  * 100 >= 75)))
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            labelPassed.Text = a.ToString();
            labelFailed.Text = b.ToString();

            
        }
    }
}
