using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TooLearnOfficial.User_Control_Facilitator
{
    public partial class Score : UserControl
    {
        string Class;

        public Score()
        {

            if (!this.DesignMode)
            {
                InitializeComponent();
                Load_Class();
                Trigger_Combo();
                
            }

           
       
        }



        //Alternative
        static class Helper
        {
            public static string ConnectionString
            {
                get
                {
                    string str = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                    return str;
                }
            }
        }
        //Alternative  



        public void Load_Class()
        {

           //Alternative
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Helper.ConnectionString;

            //Alternative-End 

            try
            {
                comboBox1.Items.Clear();


                SqlCommand cmd = new SqlCommand("Select class_name from classrooms WHERE facilitator_id= '" + Program.user_id + "' ", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["class_name"]);
                }
                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }
             

        }


        Random r = new Random();
        void additem(string _name, string _quiz, string _format, string _score, double _prog)
        {
            bunifuCustomDataGrid1.Rows.Add();
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[0].Value = _name;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[1].Value = _quiz;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[2].Value = _format;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[3].Value = _score;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[4].Value = generate_Progress(_prog);



        }

        public Image generate_Progress(double pass)
        {
            double dg = double.Parse(dgpp.Width.ToString());
            double x = 0;
            x = (pass * dg) / 100;
            pictureBox3.Width = (int)Math.Round(x, 0);
            if (pass <= 60)
            {
                pictureBox3.BackColor = Color.Red;
            }

            return PanelToBitmap(dgpp);

        }

        private static Image PanelToBitmap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }




        void Trigger_Combo()
        {
            //Alternative
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Helper.ConnectionString;

            //Alternative-End

            try
            {
               string Selected= comboBox2.SelectedItem.ToString();
                if (Selected == "No")
                {
                    SqlDataAdapter sed = new SqlDataAdapter("select class_id from classrooms where class_name= '" + Class + "' ", con);
                    DataTable data = new DataTable();
                    sed.Fill(data);
                    string ID = data.Rows[0][0].ToString();

                    SqlDataAdapter sda = new SqlDataAdapter("select user_id,date_time,quiz_id,group_id,quiz_score from scoreRecords where class_id= '" + ID + "' AND group_id IS NULL ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int Count = dt.Rows.Count;
                    int R = 0;
                    int C = 1;
                    bunifuCustomDataGrid1.Rows.Clear();
                    while (C <= Count)
                    {


                        bunifuCustomDataGrid1.Rows.Add();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[0].Value = dt.Rows[R][0].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[1].Value = dt.Rows[R][1].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[2].Value = dt.Rows[R][2].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[3].Value = dt.Rows[R][3].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[4].Value = generate_Progress(Convert.ToDouble(dt.Rows[R][4]));

                        R++;
                        C++;
                    }


                }//end If


                else
                {
                

                    SqlDataAdapter sda = new SqlDataAdapter("select user_id,date_time,quiz_id,group_id,quiz_score from scoreRecords", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int Count = dt.Rows.Count;
                    int R = 0;
                    int C = 1;
                    bunifuCustomDataGrid1.Rows.Clear();
                    while (C <= Count)
                    {


                        bunifuCustomDataGrid1.Rows.Add();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[0].Value = dt.Rows[R][0].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[1].Value = dt.Rows[R][1].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[2].Value = dt.Rows[R][2].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[3].Value = dt.Rows[R][3].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[4].Value = generate_Progress(Convert.ToDouble(dt.Rows[R][4]));

                        R++;
                        C++;
                    }


                }

            }

            catch (Exception ex)
            {
               // Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class=comboBox1.SelectedItem.ToString();
            Trigger_Combo();

        }

        private void Score_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "No";
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)

            {
            string    QuizName = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

            }

            ViewScoreRecord VSR = new ViewScoreRecord();
            VSR.ShowDialog();


        }




    }
}
