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
        string Class="";
        //string Class1 = "";

        SqlConnection con= new SqlConnection("Data Source=Localhost,1433;Initial Catalog=TooLearn;User ID=TOOLEARN;Password=Toolearn");

        public Score()
        {

            if (!this.DesignMode)
            {
                InitializeComponent();
            Load_Class();
            Trigger_Combo();
            SetDoubleBuffered(bunifuGradientPanel1);
            SetDoubleBuffered(bunifuGradientPanel2);

            }

           
       
        }


        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion



        public void Load_Class()
        {
       

            try
            {
                comboBox1.Items.Clear();


                SqlCommand cmd = new SqlCommand("Select class_name from classrooms WHERE facilitator_id= '" + Program.user_id + "' ", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["class_name"]);
                    comboBox3.Items.Add(dr["class_name"]);
                }
                dr.Close();
                con.Close();
            }

              catch (Exception ex)
             {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
             }
              

             }
              
          
               
               public Image generate_Progress(double pass)
               {
                       double dg = double.Parse(dgpp.Width.ToString());
                        double x = 0;
                        x = (pass * dg) / 100;
                        pictureBox3.Width = (int)Math.Round(x, 0);
                        if (pass <= 74)
                        {
                            pictureBox3.BackColor = Color.Red;
                        }

                          else
                        {
                            pictureBox3.BackColor = Color.Green;
                        }

                            return PanelToBitmap(dgpp); 

               }  

        private static Image PanelToBitmap(Control pnl)
            {
                var bmp = new Bitmap(pnl.Width, pnl.Height);
                pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                return bmp; 
    }

        private string remarks(double grade)
        {
            string remarks;

            if (grade <= 74)
            {
                remarks = "Need to Work Hard!";
            }

            else
            {
                remarks = "Keep It Up!";
            }

            return remarks;
        }


        void Trigger_Combo()
        {
         
                try {
                if (bunifuFlatButton2.selected == true)
                {
                    SqlDataAdapter sed = new SqlDataAdapter("select class_id from classrooms where class_name= '" + Class + "' ", con);
                    DataTable data = new DataTable();
                    sed.Fill(data);
                    string ID = data.Rows[0][0].ToString();

                    //SqlDataAdapter sda = new SqlDataAdapter("select p.fullname, sum(s.quiz_score)/sum(q.total_score)*100 AS 'Percentage' from quizzes q,participant p,scoreRecords s where p.participant_id=s.participant_id AND s.quiz_id=q.quiz_id AND class_id= '" + ID + "' AND group_id is null group by p.fullname,s.group_id,s.quiz_score,q.total_score ", con);
                    //SqlDataAdapter sda = new SqlDataAdapter("select Distinct( p.fullname )from participant p, scoreRecords s where p.participant_id=s.participant_id AND class_id= '29' AND group_id is null", con);
                    SqlDataAdapter sda = new SqlDataAdapter("select Distinct( p.fullname ), sum(s.quiz_score)/sum(q.total_score)*100 AS 'Percentage' from quizzes q, participant p, scoreRecords s where p.participant_id=s.participant_id AND s.quiz_id=q.quiz_id AND class_id= '" + ID + "' AND group_id is null group by p.fullname", con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        bunifuCustomLabel1.Visible = true;
                    }

                    else
                    {
                        bunifuCustomLabel1.Visible = false;
                    }
                    int Count = dt.Rows.Count;
                    int R = 0;
                    int C = 1;
                    bunifuCustomDataGrid1.Rows.Clear();
                    while (C <= Count)
                    {


                        bunifuCustomDataGrid1.Rows.Add();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[0].Value = dt.Rows[R][0].ToString();
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[1].Value = remarks(Convert.ToDouble(dt.Rows[R][1]));
                        bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[2].Value = generate_Progress(Convert.ToDouble(dt.Rows[R][1]));



                        R++;
                        C++;
                    }
                   

                }//end IF

                else
                {
                    /* SqlDataAdapter sed = new SqlDataAdapter("select group_id from groups where class_id=(select class_id from classrooms where class_name= '" + Class + "') ", con);
                     DataTable data = new DataTable();
                     sed.Fill(data);
                     string ID = data.Rows[0][0].ToString();*/

                    SqlDataAdapter sed = new SqlDataAdapter("select class_id from classrooms where class_name= '" + Class + "' ", con);
                    DataTable data = new DataTable();
                    sed.Fill(data);
                    string ID = data.Rows[0][0].ToString();


                   // SqlDataAdapter sda = new SqlDataAdapter("select g.group_name, sum(sc.quiz_score)/sum(q.total_score)*100 AS 'Percentage' from groups g, scoreRecords sc, quizzes q where sc.group_id = '" + ID + "' AND g.group_id = sc.group_id AND q.quiz_id = sc.quiz_id group by g.group_name, sc.quiz_score, q.total_score ", con);

                    SqlDataAdapter sda = new SqlDataAdapter("select DISTINCT g.group_name, sum(sc.quiz_score)/sum(q.total_score)*100 AS 'Percentage' from groups g, scoreRecords sc, quizzes q where sc.class_id='" + ID + "' AND g.group_id = sc.group_id AND q.quiz_id = sc.quiz_id group by g.group_name", con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        bunifuCustomLabel2.Visible = true;
                    }

                    else
                    {
                        bunifuCustomLabel2.Visible = false;
                    }

                    int Count = dt.Rows.Count;
                    int R = 0;
                    int C = 1;
                    bunifuCustomDataGrid2.Rows.Clear();
                    while (C <= Count)
                    {


                        bunifuCustomDataGrid2.Rows.Add();
                        bunifuCustomDataGrid2.Rows[bunifuCustomDataGrid2.Rows.Count - 1].Cells[0].Value = dt.Rows[R][0].ToString();
                        bunifuCustomDataGrid2.Rows[bunifuCustomDataGrid2.Rows.Count - 1].Cells[1].Value = remarks(Convert.ToDouble(dt.Rows[R][1]));
                        bunifuCustomDataGrid2.Rows[bunifuCustomDataGrid2.Rows.Count - 1].Cells[2].Value = generate_Progress(Convert.ToDouble(dt.Rows[R][1]));


                        R++;
                        C++;
                    }
                }//end Else


                bunifuCustomDataGrid2.Refresh();
                bunifuCustomDataGrid2.Update();

                }

                catch (Exception ex)
                {
                   // Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
                }

                 
   
        }    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Class =comboBox1.SelectedItem.ToString();
            Trigger_Combo();
            Cursor.Current = Cursors.Default;

        }

        private void Score_Load(object sender, EventArgs e)
        {
            
        }



        public event EventHandler StatusUpdated;

        private void FunctionThatRaisesEvent()
        {
            //Null check makes sure the main page is attached to the event
            if (this.StatusUpdated != null)
                this.StatusUpdated(this, new EventArgs());
        }




        public string PN;
        public string CR;
        public string Data
        {
            get { return PN; }
            set { PN = value; }
        }

        public string Data1
        {
            get { return CR; }
            set { CR = value; }
        }



        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

  
            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)

            {
                PN = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                CR = comboBox1.SelectedItem.ToString();

                FunctionThatRaisesEvent();
                ViewScoreRecord VSR = new ViewScoreRecord();
                VSR.ShowDialog();

            }

            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          bunifuGradientPanel1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           bunifuGradientPanel2.BringToFront();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Class = comboBox3.SelectedItem.ToString();
          Trigger_Combo();
            Cursor.Current = Cursors.Default;
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           if (bunifuCustomDataGrid2.CurrentRow.Index != -1)

            {
                PN = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                CR = comboBox3.SelectedItem.ToString();

                FunctionThatRaisesEvent();
                ViewScoreRecordGroup VSR = new ViewScoreRecordGroup();
                VSR.ShowDialog();

            }


            

        }
    }
}
