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
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TooLearnOfficial
{
    public partial class QuizBank : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        string QuizName;
        public QuizBank()
        {
            InitializeComponent();
            Load_Quiz();
        }



        void Load_Quiz()
        {
                      
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select quiz_title AS 'Title' ,date_created AS 'Created' from quizzes where facilitator_id= '" + Program.user_id + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel1.Visible = true;

                }
                
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel1.Visible = false;

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            LobbyFacilitator lobby = new LobbyFacilitator();
            lobby.ShowDialog();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)
            {
                QuizName = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                label4.Text = QuizName;
       

            }

        }

        private void DeleteQuiz_Click(object sender, EventArgs e)
        {
            try
            {

                if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
                {

                    SqlDataAdapter adapt = new SqlDataAdapter("select quiz_id from quizzes where quiz_title= '" + QuizName + "'", con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Quiz


                    DialogResult result = Dialogue1.Show("Are You Sure?", "", "Ok", "Cancel");
                    if (result == DialogResult.Yes)
                    {

                        con.Open();

                        String qer = "DELETE FROM QuestionAnswers WHERE quiz_id= '" + ID + "' ";
                        String query = "DELETE FROM quizzes WHERE quiz_id= '" + ID + "' AND facilitator_id = '" + Program.user_id + "' ";
                        SqlDataAdapter sad = new SqlDataAdapter(qer, con);
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        int n = sad.SelectCommand.ExecuteNonQuery();
                        int m = sda.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        if (n >= 0 && m > 0)
                        {
                            Load_Quiz();
                            bunifuCustomDataGrid1.ClearSelection();
                           
                            Dialogue.Show("Successfully Deleted!", "", "Ok", "Cancel");
                            

                        }

                        else
                        {
                            Dialogue.Show("Fail to Delete!", "", "Ok", "Cancel");
                            
                            bunifuCustomDataGrid1.ClearSelection();
                           

                        }
                    }//end if result


                }

                else
                {
                    Dialogue.Show("Nothing Selected", "", "Ok", "Cancel");
                }


            }//try


            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }
        }

        private void QuizBank_Load(object sender, EventArgs e)
        {

        }
    }
}
