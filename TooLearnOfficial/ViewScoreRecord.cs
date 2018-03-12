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


            /*
            
                       SqlDataAdapter adapt = new SqlDataAdapter("Select participant_id from participant where fullname='" +Name+ "' ", con);
                       DataTable dt = new DataTable();
                       adapt.Fill(dt);
                        string ID=dt.Rows[0][0].ToString();


                        SqlDataAdapter adapter = new SqlDataAdapter("Select quiz_id,quiz_score from scoreRecords where participant_id='" + ID + "' ", con);
                        DataTable data = new DataTable();
                        adapt.Fill(data);
                        string Qid = data.Rows[0][0].ToString();
                        string Score = data.Rows[0][1].ToString();


                        SqlDataAdapter adapters = new SqlDataAdapter("Select quiz_title from quizzes where quiz_id='" + Qid + "' ", con);
                        DataTable datas = new DataTable();
                        adapt.Fill(datas);
                        string title = datas.Rows[0][0].ToString();




                        SqlDataAdapter adaptersd = new SqlDataAdapter("Q.quiz_title,quiz_score from scoreRecords SR,quizzes Q where SR.participant_id='"+ID+"' AND Q.quiz_id= '" +Qid + "' ", con);
                        DataTable datasd = new DataTable();
                        adaptersd.Fill(datasd);
                        BindingSource bs = new BindingSource();
                        bs.DataSource = datasd;
                        DataGridViewGrade.DataSource = bs;
                        adaptersd.Update(dt);




    */
           

            SqlDataAdapter adaptersd = new SqlDataAdapter("select * from scoreRecords ", con);
            DataTable datasd = new DataTable();
            adaptersd.Fill(datasd);
            BindingSource bs = new BindingSource();
            bs.DataSource = datasd;
            DataGridViewGrade.DataSource = bs;

            //label_average.Text = PG;


            int TotalNumberofQuiz;
                        int TotalScoreonQuiz = 0;
                        double average;
            bunifuCircleProgressbar1.Value = 0;

                        for (int i = 0; i < DataGridViewGrade.Rows.Count; ++i)
                        {
                            TotalScoreonQuiz += Convert.ToInt32(DataGridViewGrade.Rows[i].Cells[1].Value);  
                        }
                        labelTotal.Text += TotalScoreonQuiz.ToString();

                        TotalNumberofQuiz = DataGridViewGrade.Rows.Count;
                        average = TotalScoreonQuiz / TotalNumberofQuiz;

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
        }
    }
}
