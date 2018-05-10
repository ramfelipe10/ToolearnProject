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
    public partial class ViewScoreRecordGroup : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        string PG = ScoreRecordFacilitator.PN;
        string CR = ScoreRecordFacilitator.CR;
        SqlDataAdapter adaptersd;
        DataTable datasd;

        public ViewScoreRecordGroup()
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

        private void ViewScoreRecordGroup_Load(object sender, EventArgs e)
        {
            filldgridGroup();
        }
        public void filldgridGroup()
        {
            SqlDataAdapter name = new SqlDataAdapter("select group_id from groups where group_name='" + PG + "' ", con);
            DataTable dt = new DataTable();
            name.Fill(dt);
            string pid = dt.Rows[0][0].ToString();

            SqlDataAdapter classname = new SqlDataAdapter("select class_id from classrooms where class_name='" + CR + "' ", con);
            DataTable data = new DataTable();
            classname.Fill(data);
            string cid = data.Rows[0][0].ToString();

            SqlDataAdapter sed = new SqlDataAdapter("select group_id from groups where class_id=(select class_id from classrooms where class_name= '" + CR + "') ", con);
            DataTable data1 = new DataTable();
            sed.Fill(data1);
            string ID = data1.Rows[0][0].ToString();

            adaptersd = new SqlDataAdapter("select q.quiz_title AS 'Quiz Title',q.date_created AS 'Date Created',s.quiz_score AS 'Score',q.total_score AS 'Quiz Total Points' from scoreRecords s,quizzes q where q.quiz_id=s.quiz_id AND s.group_id is NOT NULL AND s.group_id='" + pid + "'AND s.class_id='" + cid + "' ", con);
            datasd = new DataTable();
            adaptersd.Fill(datasd);
            BindingSource bsa = new BindingSource();
            bsa.DataSource = datasd;
            DataGridViewGrade.DataSource = bsa;

            SqlDataAdapter sda = new SqlDataAdapter("select sum(sc.quiz_score)/sum(q.total_score)*100 AS 'Percentage' from groups g, scoreRecords sc, quizzes q where sc.group_id = '" + ID + "' AND g.group_id = sc.group_id AND q.quiz_id = sc.quiz_id group by g.group_name, sc.quiz_score, q.total_score ", con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            //MessageBox.Show(Convert.ToInt32(dt.Rows[0][0]).ToString());
            bunifuCircleProgressbar2.Value = Convert.ToInt32(dt1.Rows[0][0]);

            ////

            //SqlDataAdapter seds = new SqlDataAdapter("select group_id from groups where class_id=(select class_id from classrooms where class_name= '" + CR + "') ", con);
            //DataTable data11 = new DataTable();
            //seds.Fill(data11);
            //string IDS = data11.Rows[0][0].ToString();


            //SqlDataAdapter sdas = new SqlDataAdapter("select sum(sc.quiz_score)/sum(q.total_score)*100 AS 'Percentage' from scoreRecords sc, quizzes q where sc.participant_id = '" + IDS + "' AND q.quiz_id = sc.quiz_id group by sc.quiz_score, q.total_score ", con);
            //DataTable dt11 = new DataTable();
            //sdas.Fill(dt11);
            //BindingSource bt = new BindingSource();
            //bt.DataSource = dt11;
            //int aa;
            //if (dt11.Rows.Count == 0 || dt11.Rows[0][0].ToString() == "")
            //{
            //    aa = 0;
            //}
            //else
            //{
            //    aa = Convert.ToInt32(dt11.Rows[0][0]);
            //}
            //bunifuCircleProgressbar2.Value = aa;

        }
    }
}
