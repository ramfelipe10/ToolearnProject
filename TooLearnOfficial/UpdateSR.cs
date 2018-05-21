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
    public partial class UpdateSR : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        string PG = ScoreRecordFacilitator.PN;
        string CR = ScoreRecordFacilitator.CR;
        SqlDataAdapter adaptersd;
        DataTable datasd;
        SqlCommandBuilder builder;
        public UpdateSR()
        {
            InitializeComponent();
        }

        private void UpdateSR_Load(object sender, EventArgs e)
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
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {            
                builder = new SqlCommandBuilder(adaptersd);
                adaptersd.Update(datasd);

            
            
        }
    }
}
