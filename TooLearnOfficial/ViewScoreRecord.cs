﻿using System;
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
            SqlDataAdapter name= new SqlDataAdapter("select participant_id from participant where fullname='" + PG + "' " ,con);
            DataTable dt = new DataTable();
            name.Fill(dt);
            string pid=dt.Rows[0][0].ToString();

            SqlDataAdapter classname = new SqlDataAdapter("select class_id from classrooms where class_name='" + CR + "' ", con);
            DataTable data = new DataTable();
            classname.Fill(data);
            string cid = data.Rows[0][0].ToString();           

            SqlDataAdapter adaptersd = new SqlDataAdapter("select q.quiz_title AS 'Quiz Title',q.date_created AS 'Date Created',s.quiz_score AS 'Score',q.total_score AS 'Quiz Total Points' from scoreRecords s,quizzes q where q.quiz_id=s.quiz_id AND s.participant_id='"+ pid +"'AND s.class_id='" + cid +"' ", con);
            DataTable datasd = new DataTable();
            adaptersd.Fill(datasd);
            BindingSource bs = new BindingSource();
            bs.DataSource = datasd;
            DataGridViewGrade.DataSource = bs;

            label_Participant_Name.Text = PG;
            label_Classroom_name.Text = CR;

                        int Total_Number_of_Quiz;                       
                        int Quiz_Total_Score = 0;
                        int Total_Score_on_Quiz = 0;
                        double average = 0;
                        Progressbar_Individual.Value = 0;

            //Total Score on Quiz
                        for (int i = 0; i < DataGridViewGrade.Rows.Count; ++i)
                        {
                            Total_Score_on_Quiz += Convert.ToInt32(DataGridViewGrade.Rows[i].Cells[2].Value);  
                        }
                        label_Total_Score.Text += Total_Score_on_Quiz.ToString();

                        Total_Number_of_Quiz = DataGridViewGrade.Rows.Count;

            //Total Number of Quiz Take
                label_No_of_Taken_Quiz.Text += Total_Number_of_Quiz.ToString();

            //Total Items of Quiz 
                        for (int j = 0; j < DataGridViewGrade.Rows.Count; ++j)
                        {
                            Quiz_Total_Score += Convert.ToInt32(DataGridViewGrade.Rows[j].Cells[3].Value);
                        }
            //Compute the Average Grade
                average = ((Total_Score_on_Quiz / Quiz_Total_Score) * 100);

            //Average Grade
            label_average.Text += average.ToString();

            Progressbar_Individual.Value += Convert.ToInt32(average);
            //Progressbar_Individual.Value = average;

            if (average >= 95 && average <= 100)
            {
                label_Letter_Grade.Text = "A"; // Excellent
                label_Remarks.Text = "Excellent";
            }
            else if (average >= 89 && average <= 94)
            {
                label_Letter_Grade.Text = "B+"; // Very Good
                label_Remarks.Text = "Very Good";
            }
            else if (average >= 83 && average <= 88)
            {
                label_Letter_Grade.Text = "B";  // Very Good
                label_Remarks.Text = "Very Good";
            }
            else if (average >= 77 && average <= 82)
            {
                label_Letter_Grade.Text = "C+";  // Good
                label_Remarks.Text = "Good";
            }
            else if (average >= 71 && average <= 76)
            {
                label_Letter_Grade.Text = "C";  // Satisfaction
                label_Remarks.Text = "Satisfaction";
            }
            else if (average >= 65 && average <= 70)
            {
                label_Letter_Grade.Text = "D+";  // Satisfaction
                label_Remarks.Text = "Satisfaction";
            }
            else if (average >= 60 && average <= 64)
            {
                label_Letter_Grade.Text = "D";  // Passed
                label_Remarks.Text = "Passed";
            }
            else
            {
                label_Letter_Grade.Text = "F"; // Failed
                label_Remarks.Text = "Failed";
            }

            //Count Passed and Failed Quizzes
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
