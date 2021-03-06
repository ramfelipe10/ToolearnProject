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
        SqlDataAdapter adaptersd;
        DataTable datasd;
        //SqlCommandBuilder builder;

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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //UpdateSR usr = new UpdateSR();
            //usr.Show();
            //try
            //{
            //    cmdbl = new SqlCommandBuilder(adap);
            //    adap.Update(ds, "");
            //}
            //catch(Exception ex)
            //{
            //    Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok");
            //}

            //builder = new SqlCommandBuilder(adaptersd);
            //adaptersd.Update(datasd);
            //Dialogue.Show("Sucessfully Updated!", "", "Ok", "Cancel");
            //con.Open();
            //String query = "UPDATE scoreRecords set quiz_score='" + DataGridViewGrade.Rows[0].Cells[2].Value.ToString() + "' from scoreRecords s, participant p, facilitator f where s.score_id and p.participant_id=s.participant_id and p.participant_id='" + Program.par_id+ "' and  f.facilitator_id=sc.facilitator_id and facilitator_id= '"+Program.user_id+"' ";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //sda.SelectCommand.ExecuteNonQuery();

            //con.Close();

        }

        private void ViewScoreRecord_Load(object sender, EventArgs e)
        {
          fillgridIndividual(); 
        }
      

        public void fillgridIndividual()
        {
            SqlDataAdapter name = new SqlDataAdapter("select participant_id from participant where fullname='" + PG + "' ", con);
            DataTable dt = new DataTable();
            name.Fill(dt);
            string pid = dt.Rows[0][0].ToString();

            SqlDataAdapter classname = new SqlDataAdapter("select class_id from classrooms where class_name='" + CR + "' ", con);
            DataTable data = new DataTable();
            classname.Fill(data);
            string cid = data.Rows[0][0].ToString();

            adaptersd = new SqlDataAdapter("select q.quiz_title AS 'Quiz Title',q.date_created AS 'Date Created',s.quiz_score AS 'Score',q.total_score AS 'Quiz Total Points' from scoreRecords s,quizzes q where q.quiz_id=s.quiz_id AND s.group_id is NULL AND s.participant_id='" + pid + "' AND s.class_id='" + cid + "' ", con);
            datasd = new DataTable();
            adaptersd.Fill(datasd);
            BindingSource bs = new BindingSource();
            bs.DataSource = datasd;
            DataGridViewGrade.DataSource = bs;

            label_Participant_Name.Text = PG;
            label_Classroom_name.Text = CR;

            int Total_Number_of_Quiz;
            double Quiz_Total_Score = 0;
            double Total_Score_on_Quiz = 0;
            int average;
            double aver;
            Progressbar_Individual.Value = 0;

            //Total Score on Quiz
            for (int i = 0; i < DataGridViewGrade.Rows.Count; ++i)
            {
                Total_Score_on_Quiz += Convert.ToInt32(DataGridViewGrade.Rows[i].Cells[2].Value);
            }
            label_Total_Score.Text += Total_Score_on_Quiz.ToString();

            //Total Number of Quiz Take
            Total_Number_of_Quiz = DataGridViewGrade.Rows.Count;
            label_No_of_Taken_Quiz.Text += Total_Number_of_Quiz.ToString();

            //Total Items of Quiz 
            for (int j = 0; j < DataGridViewGrade.Rows.Count; ++j)
            {
                Quiz_Total_Score += Convert.ToInt32(DataGridViewGrade.Rows[j].Cells[3].Value);
            }
            //label_Class_Rank.Text += Quiz_Total_Score;
            //Compute the Average Grade
            aver = (Total_Score_on_Quiz / Quiz_Total_Score) * 100;
            average = Convert.ToInt32(aver);
            //Average Grade
            label_average.Text += average.ToString();

            Progressbar_Individual.Value += Convert.ToInt32(average);

            if (average >= 96 && average <= 100)
            {
                label_Letter_Grade.Text = "A"; // Excellent
                label_Remarks.Text = "Excellent";
            }
            else if (average >= 91 && average <= 95)
            {
                label_Letter_Grade.Text = "B+"; // Very Good
                label_Remarks.Text = "Very Good";
            }
            else if (average >= 86 && average <= 90)
            {
                label_Letter_Grade.Text = "B";  // Very Good
                label_Remarks.Text = "Very Good";
            }
            else if (average >=81 && average <= 85)
            {
                label_Letter_Grade.Text = "C+";  // Good
                label_Remarks.Text = "Good";
            }
            else if (average >= 76 && average <= 80)
            {
                label_Letter_Grade.Text = "C";  // Satisfaction
                label_Remarks.Text = "Satisfaction";
            }
            else if (average == 75)
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
                if (average >= 75)
                {
                    a++;
                    Progressbar_Individual.ProgressColor = Color.ForestGreen;
                    Progressbar_Individual.ForeColor = Color.ForestGreen;
                    bunifuCircleProgressbar2.ProgressColor = Color.ForestGreen;
                    bunifuCircleProgressbar2.ForeColor = Color.ForestGreen;
                }
                else
                {
                    b++;
                    Progressbar_Individual.ProgressColor = Color.Red;
                    Progressbar_Individual.ForeColor = Color.Red;
                    bunifuCircleProgressbar2.ProgressColor = Color.Red;
                    bunifuCircleProgressbar2.ForeColor = Color.Red;
                }
            }
            labelPassed.Text = a.ToString();
            labelFailed.Text = b.ToString();

            //Rank Query
            SqlDataAdapter rank = new SqlDataAdapter("select p.fullname, sr.quiz_score, DENSE_RANK() over(order by sr.quiz_score desc) as 'Rank' from participant p, scoreRecords sr where sr.class_id = '" + cid + "' and p.participant_id = sr.participant_id AND sr.group_id is NULL ", con);
            DataTable datar = new DataTable();
            rank.Fill(datar);
            for (int i = 0; i < datar.Rows.Count; i++)
            {
                if (datar.Rows[i][0].ToString() == PG)
                {
                    labelClassRank.Text = datar.Rows[i][2].ToString();
                }

            }

            /*           GROUP                          */


            SqlDataAdapter sed = new SqlDataAdapter("select group_id from groups where class_id=(select class_id from classrooms where class_name= '" + CR + "') ", con);
            DataTable data1 = new DataTable();
            sed.Fill(data1);
            string ID = data1.Rows[0][0].ToString();


            SqlDataAdapter sda = new SqlDataAdapter("select sum(sc.quiz_score)/sum(q.total_score)*100 AS 'Percentage' from groups g, scoreRecords sc, quizzes q where sc.group_id = '" + ID + "' AND g.group_id = sc.group_id AND q.quiz_id = sc.quiz_id group by g.group_name, sc.quiz_score, q.total_score ", con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            BindingSource bt = new BindingSource();
            bt.DataSource = dt1;
            int aa;
            if (dt1.Rows.Count == 0 || dt1.Rows[0][0].ToString() == "")
            {
                aa = 0;
            }
            else
            {
                aa = Convert.ToInt32(dt1.Rows[0][0]);
            }
            bunifuCircleProgressbar2.Value = aa;

        }

           
    }
}
