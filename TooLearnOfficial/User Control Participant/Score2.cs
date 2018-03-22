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

namespace TooLearnOfficial.User_Control_Participant
{
    public partial class Score2 : UserControl
    {
        string Class = "";

        SqlConnection con = new SqlConnection("Data Source=Localhost,1433;Initial Catalog=TooLearn;User ID=TOOLEARN;Password=Toolearn");

        public Score2()
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

                //Facilitator Name in Combo Box
                SqlCommand cmd = new SqlCommand("select f.name from facilitator f, classlist cl where f.facilitator_id=cl.facilitator_id and cl.participant_id= '" + Program.par_id + "' ", con);
                //Select class_name from classrooms WHERE facilitator_id= '" + Program.user_id + "' 
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["name"]);
                    comboBox3.Items.Add(dr["name"]);
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
            double dg = double.Parse(dgpp1.Width.ToString());
            double x = 0;
            x = (pass * dg) / 100;
            pictureBox31.Width = (int)Math.Round(x, 0);
            if (pass <= 74)
            {
                pictureBox31.BackColor = Color.Red;
            }

            else
            {
                pictureBox31.BackColor = Color.Green;
            }

            return PanelToBitmap(dgpp1);

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
                remarks = "Failed: Need to Work Hard!";
            }

            else
            {
                remarks = "Passed: Keep It Up!";
            }

            return remarks;
        }


        void Trigger_Combo()
        {

            try
            {
                if (bunifuFlatButton2.selected == true)
                {                                          //Select f.name from  facilitator f, classrooms c WHERE c.class_id = '" + Class + "' and f.facilitator_id= '" + Program.user_id + "'
                    SqlDataAdapter sed = new SqlDataAdapter("select facilitator_id from facilitator where name='" + Class + "'  ", con);
                    DataTable data = new DataTable();       //select class_id from classrooms where class_name= '" + Class + "'                                                                  //AND cl.participant_id= '" + Program.par_id + "'
                    sed.Fill(data);
                    string ID = data.Rows[0][0].ToString();

                    SqlDataAdapter sda = new SqlDataAdapter("select c.class_name,sum(s.quiz_score)/sum(q.total_score)*100 AS 'Percentage'  from quizzes q, participant p, scoreRecords s, classrooms c where p.participant_id = s.participant_id AND s.quiz_id = q.quiz_id AND c.facilitator_id = '" + ID + "' AND s.participant_id= '" + Program.par_id + "' AND group_id is null group by s.group_id, s.quiz_score, q.total_score, c.class_name ", con);
                                                                    //p.fullname

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
                    SqlDataAdapter sed = new SqlDataAdapter("select class_id from classrooms where class_name= '" + Class + "' ", con);
                    DataTable data = new DataTable();
                    sed.Fill(data);
                    string ID = data.Rows[0][0].ToString();


                    SqlDataAdapter sda = new SqlDataAdapter("select p.fullname,sc.group_id,sc.quiz_score from scoreRecords sc, participant p where sc.class_id= '" + ID + "' AND p.participant_id=sc.participant_id AND group_id IS NOT NULL ", con);
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
                        bunifuCustomDataGrid2.Rows[bunifuCustomDataGrid2.Rows.Count - 1].Cells[1].Value = dt.Rows[R][1].ToString();
                        bunifuCustomDataGrid2.Rows[bunifuCustomDataGrid2.Rows.Count - 1].Cells[2].Value = generate_Progress(Convert.ToDouble(dt.Rows[R][2]));


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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Class = comboBox1.SelectedItem.ToString();
            Trigger_Combo();
            Cursor.Current = Cursors.Default;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Class = comboBox3.SelectedItem.ToString();
            Trigger_Combo();
            Cursor.Current = Cursors.Default;
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)

            {
                PN = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                CR = comboBox1.SelectedItem.ToString();

            }

            FunctionThatRaisesEvent();
            ViewScoreRecord VSR = new ViewScoreRecord();
            VSR.ShowDialog();
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid2.CurrentRow.Index != -1)

            {
                PN = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                CR = comboBox3.SelectedItem.ToString();

            }


            FunctionThatRaisesEvent();
            ViewScoreRecord VSR = new ViewScoreRecord();
            VSR.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.BringToFront();
        }
    }
}
