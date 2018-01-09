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
    public partial class QuizBee : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlConnection con2 = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlDataReader dr;
        int numOfItems, currentNumOfItems;
        string RightAnswer;

        List<Panel> listPanel = new List<Panel>();


        public QuizBee()
        {
            InitializeComponent();
        }

        private void resetAllMC()
        {
            textBox11.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;
            pictureBox3.ImageLocation = null;

           textBoxQuizQuestion.Text = null;
            textBoxQuizChoiceA.Text = null; textBoxQuizChoiceB.Text = null; textBoxQuizChoiceC.Text = null; textBoxQuizChoiceD.Text = null;
            bunifuCheckbox1.Checked = false; bunifuCheckbox2.Checked = false; bunifuCheckbox3.Checked = false; bunifuCheckbox4.Checked = false;
        }

        private void resetAllSA()
        {
            textBox12.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox9.Text = null;
            textBox8.Text = null;
            pictureBox4.ImageLocation = null;


        }

        private void resetAllTF()
        {
            textBox10.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox13.Text = null;
           
            pictureBox5.ImageLocation = null;


        }




        private void enable_fieldsMC() {

            bunifuFlatButton2.Enabled = true; //multiplechoice
            bunifuFlatButton3.Enabled = true; //trueOrfalse
            bunifuFlatButton4.Enabled = true; //shortAnswer

            //For Multiple Choice
            pictureBox3.Enabled = true;
            textBoxQuizQuestion.Enabled = true;
            bunifuFlatButton1.Enabled = true;
            textBox11.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBoxQuizChoiceA.Enabled = true;
            textBoxQuizChoiceB.Enabled = true;
            textBoxQuizChoiceC.Enabled = true;
            textBoxQuizChoiceD.Enabled = true;


            bunifuCheckbox1.Enabled = true;
            bunifuCheckbox2.Enabled = true;
            bunifuCheckbox3.Enabled = true;
            bunifuCheckbox4.Enabled = true;

            buttonNextQuestion.Enabled = true;

            //For Short Answer
            bunifuFlatButton7.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox12.Enabled = true;
            textBox9.Enabled = true;
            textBox8.Enabled = true;

            //For TrueFalse

            textBox13.Enabled = true;
            bunifuDropdown5.Enabled = true;
            bunifuFlatButton8.Enabled = true;
            textBox10.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;

        }


        private void disable_fieldsMC()
        {

            bunifuFlatButton2.Enabled = false; //multiplechoice
            bunifuFlatButton3.Enabled = false; //trueOrfalse
            bunifuFlatButton4.Enabled = false; //shortAnswer

            //For Multiple Choice
            textBox11.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            bunifuFlatButton1.Enabled = false;
            textBoxQuizQuestion.Enabled = false;
            textBoxQuizChoiceA.Enabled = false;
            textBoxQuizChoiceB.Enabled = false;
            textBoxQuizChoiceC.Enabled = false;
            textBoxQuizChoiceD.Enabled = false;


            bunifuCheckbox1.Enabled = false;
            bunifuCheckbox2.Enabled = false;
            bunifuCheckbox3.Enabled = false;
            bunifuCheckbox4.Enabled = false;

            buttonNextQuestion.Enabled = false;

            //For Short Answer
            bunifuFlatButton7.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox12.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;

            //For TrueFalse

            textBox13.Enabled = false;
            bunifuDropdown5.Enabled = false;
            bunifuFlatButton8.Enabled = false;
            textBox10.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;


        }

        private void updateMC()
        {
            buttonNextQuestion.Text = "Update";
            ListViewItem exams = MultipleChoiceLV.SelectedItems[0];
            textBoxQuizQuestion.Text = exams.Text;
            textBoxQuizChoiceA.Text =exams.SubItems[1].Text;
            textBoxQuizChoiceB.Text =exams.SubItems[2].Text;
            textBoxQuizChoiceC.Text =exams.SubItems[3].Text;
            textBoxQuizChoiceD.Text =exams.SubItems[4].Text;
            switch (exams.SubItems[5].Text)
            {

                case "A":
                    RightAnswer = "A";
                    bunifuCheckbox1.Checked = true;
                    bunifuCheckbox2.Checked = false;
                    bunifuCheckbox3.Checked = false;
                    bunifuCheckbox4.Checked = false;
                    break;

                case "B":
                    RightAnswer = "B";
                    bunifuCheckbox1.Checked = false;
                    bunifuCheckbox2.Checked = true;
                    bunifuCheckbox3.Checked = false;
                    bunifuCheckbox4.Checked = false;
                    break;

                case "C":

                    RightAnswer = "C";
                    bunifuCheckbox1.Checked = false;
                    bunifuCheckbox2.Checked = false;
                    bunifuCheckbox3.Checked = true;
                    bunifuCheckbox4.Checked = false;
                    break;

                case "D":

                    RightAnswer = "D";
                    bunifuCheckbox1.Checked = false;
                    bunifuCheckbox2.Checked = false;
                    bunifuCheckbox3.Checked = false;
                    bunifuCheckbox4.Checked = true;
                    break;

                default:
                    break;
            }



            }


        private void clearAllMC()
        {
            textBoxQuizTitle.Text = null;
            textBox7.Text = null;
            bunifuDropdown6.selectedIndex = -1;
            resetAllMC();
            disable_fieldsMC();
            MultipleChoiceLV.Items.Clear();
            ShortAnswerLV.Items.Clear();
            TrueOrFalseLV.Items.Clear();
            MultipleChoiceLV.Enabled = false;
            ShortAnswerLV.Enabled = false;
            TrueOrFalseLV.Enabled = false;

        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuizBee_Load(object sender, EventArgs e)
        {

            listPanel.Add(MultipleChoice);
            listPanel.Add(trueORfalse);
            listPanel.Add(shortAnswer);


            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MultipleChoice.BringToFront();
            bunifuFlatButton2.selected = true;
            MultipleChoiceLV.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            trueORfalse.BringToFront();
            TrueOrFalseLV.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            shortAnswer.BringToFront();
            ShortAnswerLV.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            String imageLocation = null;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";
                dialog.Filter = "jpg files(*.jpg)|*.jpg"; //ifilter lng ang jpg formats
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox3.ImageLocation = imageLocation;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            String imageLocation = null;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";
                dialog.Filter = "jpg files(*.jpg)|*.jpg"; //ifilter lng ang jpg formats
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox4.ImageLocation = imageLocation;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;


                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

            String imageLocation = null;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";
                dialog.Filter = "jpg files(*.jpg)|*.jpg"; //ifilter lng ang jpg formats
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox5.ImageLocation = imageLocation;
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;


                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            
            if (bunifuDropdown6.selectedIndex == -1)
            {
                Dialogue.Show("Please Indicate Number Of Items", "", "Ok", "Cancel");
            }

            else
            {

                if (textBox7.Text == "")
                {
                    label20.Visible = true; //MC
                    label29.Visible = true;
                    textBox11.Visible = true;


                    label17.Visible = true; //SA
                    label18.Visible = true;
                    textBox12.Visible = true;


                    label24.Visible = true; //TF
                    label23.Visible = true;
                    textBox10.Visible = true;

                    label5.Visible = false; //TimeLimitQuiz
                    textBox7.Visible = false;
                    label14.Visible = false;
                                  
                }


                else
                {
                    label20.Visible = false; //MC
                    label29.Visible = false;
                    textBox11.Visible = false;


                    label17.Visible = false; //SA
                    label18.Visible = false;
                    textBox12.Visible = false;


                    label24.Visible = false; //TF
                    label23.Visible = false;
                    textBox10.Visible = false;


                    label5.Visible = true; //TimeLimitQuiz
                    textBox7.Visible = true;
                    label14.Visible = true;
                    textBox7.Enabled = false;

                }
                numOfItems = int.Parse(bunifuDropdown6.selectedValue); currentNumOfItems = 1;                
                bunifuFlatButton5.Enabled = false;
                bunifuDropdown6.Enabled = false;
                enable_fieldsMC();
                currentnumMC.Text= currentNumOfItems.ToString();
                CurrentnumSA.Text= currentNumOfItems.ToString();
                CurrentNumTF.Text= currentNumOfItems.ToString();
                MultipleChoiceLV.Enabled = true;


            }
            
        }


        private void bunifuImageButton3_Click(object sender, EventArgs e)//Refresh
        {
            DialogResult Result = Dialogue1.Show("Do You Wan't To Continue? \nResetting May Affect Questions and Answers You've Created.", "Confirmation", "Ok", "Cancel");
            if(Result == DialogResult.Yes)
            {

                label20.Visible = true; //MC
                label29.Visible = true;
                textBox11.Visible = true;


                label17.Visible = true; //SA
                label18.Visible = true;
                textBox12.Visible = true;


                label24.Visible = true; //TF
                label23.Visible = true;
                textBox10.Visible = true;

                label5.Visible = true; //TimeLimitQuiz
                textBox7.Visible = true;
                label14.Visible = true;



                numOfItems = 0;
                currentNumOfItems = 0;
                currentnumMC.Text = null;
                CurrentnumSA.Text = null;
                CurrentNumTF.Text = null;
                bunifuDropdown6.selectedIndex = -1;
                bunifuDropdown6.Enabled = true;
                bunifuFlatButton5.Enabled = true;
                MultipleChoiceLV.Items.Clear();
                ShortAnswerLV.Items.Clear();
                TrueOrFalseLV.Items.Clear();
                resetAllMC();
                resetAllSA();
                resetAllTF();
                disable_fieldsMC();
                MultipleChoiceLV.Enabled = false;
                ShortAnswerLV.Enabled = false;
                TrueOrFalseLV.Enabled = false;

                
                buttonNextQuestion.Text = "Next";

                MultipleChoice.BringToFront();
                MultipleChoiceLV.BringToFront();



            }



        }


        private void buttonNextQuestion_Click(object sender, EventArgs e)//for multiple choice next
        {

            switch (buttonNextQuestion.Text)
            {
                case "Next":

                    if (textBoxQuizQuestion.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox11.Text == "" || textBoxQuizChoiceA.Text == "" ||
                        textBoxQuizChoiceB.Text == "" || textBoxQuizChoiceC.Text == "" || textBoxQuizChoiceD.Text == "" || RightAnswer == null)
                    {
                        Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                    }

                    else
                    {
                        if (currentNumOfItems <= numOfItems)
                        {                        //Listview
                            ListViewItem exams = new ListViewItem();
                            exams.Text = textBoxQuizQuestion.Text;
                            exams.SubItems.Add(textBoxQuizChoiceA.Text);
                            exams.SubItems.Add(textBoxQuizChoiceB.Text);
                            exams.SubItems.Add(textBoxQuizChoiceC.Text);
                            exams.SubItems.Add(textBoxQuizChoiceD.Text);
                            exams.SubItems.Add(RightAnswer);
                            MultipleChoiceLV.Items.Add(exams);
                            currentNumOfItems++;

                            if (currentNumOfItems <= numOfItems)
                            {
                                currentnumMC.Text = currentNumOfItems.ToString();
                                CurrentnumSA.Text = currentNumOfItems.ToString();
                                CurrentNumTF.Text = currentNumOfItems.ToString();
                                rightAnswer = null;
                                resetAllMC();
                            }
                            else
                            {
                                disable_fieldsMC();
                                buttonNextQuestion.Text = "Confirm";
                                buttonNextQuestion.Enabled = true;
                               rightAnswer = null;
                                resetAllMC();

                            }
                        }

                    }

                    break;


                case "Update":
                    if (currentNumOfItems > numOfItems)
                    {

                        int listPosition = int.Parse(currentnumMC.Text) - 1;
                        ListViewItem exams = new ListViewItem();
                        exams.Text = textBoxQuizQuestion.Text;
                        exams.SubItems.Add(textBoxQuizChoiceA.Text);
                        exams.SubItems.Add(textBoxQuizChoiceB.Text);
                        exams.SubItems.Add(textBoxQuizChoiceC.Text);
                        exams.SubItems.Add(textBoxQuizChoiceD.Text);
                        exams.SubItems.Add(RightAnswer);
                        MultipleChoiceLV.Items.RemoveAt(listPosition);
                        MultipleChoiceLV.Items.Insert(listPosition, exams);
                        currentnumMC.Text = Convert.ToString(numOfItems);
                        CurrentnumSA.Text = Convert.ToString(numOfItems);
                        CurrentNumTF.Text = Convert.ToString(numOfItems);

                        RightAnswer = null;
                        disable_fieldsMC();
                        resetAllMC();
                        buttonNextQuestion.Text = "Confirm";
                        buttonNextQuestion.Enabled = true;


                    }


                    else
                    {
                        int listPosition = int.Parse(currentnumMC.Text) - 1;
                        ListViewItem exams = new ListViewItem();
                        exams.Text = textBoxQuizQuestion.Text;
                        exams.SubItems.Add(textBoxQuizChoiceA.Text);
                        exams.SubItems.Add(textBoxQuizChoiceB.Text);
                        exams.SubItems.Add(textBoxQuizChoiceC.Text);
                        exams.SubItems.Add(textBoxQuizChoiceD.Text);
                        exams.SubItems.Add(RightAnswer);
                        MultipleChoiceLV.Items.RemoveAt(listPosition);
                        MultipleChoiceLV.Items.Insert(listPosition, exams);
                        currentnumMC.Text = Convert.ToString(MultipleChoiceLV.Items.Count + 1);
                        CurrentnumSA.Text = Convert.ToString(ShortAnswerLV.Items.Count + 1);
                        CurrentNumTF.Text = Convert.ToString(TrueOrFalseLV.Items.Count + 1);
                        RightAnswer = null;
                        resetAllMC(); ;
                        buttonNextQuestion.Text = "Next";
                    }
                    break;

                case "Confirm":

                    if (bunifuDropdown6.selectedValue == null || textBoxQuizTitle.Text=="" )
                    {
                        Dialogue.Show("Please Complete All indicated Field Before You Proceed", "", "Ok", "Cancel");
                    }

                    else
                    {
                        DialogResult result = Dialogue1.Show("Are You Sure You Want To Continue?", "", "Ok", "Cancel");
                        if (result == DialogResult.Yes)
                        {
                            try
                            {

                                con.Open();


                                SqlDataAdapter adapt = new SqlDataAdapter("Select facilitator_id from facilitator WHERE username = '" + Program.Session_id + "' ", con);
                                DataTable dt = new DataTable();
                                adapt.Fill(dt);
                                int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Facilitator

                               


                                
                                
                                String query = "INSERT INTO quizzes (quiz_title,quiz_time_limit,facilitator_id,date_created) VALUES ('" + textBoxQuizTitle.Text + "','" +textBox7.Text+"', '" + ID + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";//limit
                                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                sda.SelectCommand.ExecuteNonQuery();


                                con.Close();
                               

                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                            }
                       
                            try
                            {


                                con.Open();

                                SqlCommand cmd = new SqlCommand("select * from quizzes where quiz_title = '" + textBoxQuizTitle.Text + "' AND facilitator_id = (select facilitator_id from facilitator where username = '" + Program.Session_id + "')", con);


                                dr = cmd.ExecuteReader();
                           
                                    
                                    if (dr.Read() == true)
                                    {
                                        int examID = (int)dr[("quiz_id")];
                                        for (int i = 0; i < MultipleChoiceLV.Items.Count; i++)
                                        {
                                            ListViewItem exams = MultipleChoiceLV.Items[i];
                                            try
                                            {
                                                con2.Open();
                                            
                                                String query = "INSERT INTO QuestionAnswers(question,answer_a,answer_b,answer_c,answer_d,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('" + exams.Text + "','"+ exams.SubItems[1].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[5].Text + "','" + examID + "','" +textBox2.Text+"','" +pictureBox3.ImageLocation+ "','" +textBox7.Text + "')";//limit kulang question_id  RightAnswer
                                                SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                                int n = sda.SelectCommand.ExecuteNonQuery();
                                           
                                               
                                            }
                                            
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }
                                            con2.Close();

                                        }


                                    }
                               
                             
                               
                            }


                             

                            catch (Exception ex)
                            {
                             MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                               
                                 if (dr != null) dr.Close();
                                 if (con != null) con.Close();
                            }

                            clearAllMC();
                            numOfItems = 0;
                            currentNumOfItems = 0;
                            // Program.examID = 0;
                            bunifuDropdown6.Enabled = true;
                            bunifuFlatButton5.Enabled = true;
                            Dialogue.Show("Quiz Saved In the Database", "", "Ok", "Cancel");
                            this.Close();
                            //popop new form to launch or go to home and this.close


                        }
                    }

                    break;


            }
        }


        // delete 
      

        private void button2_Click(object sender, EventArgs e)//for true or false Next
        {
            //Lisview
            ListViewItem exams = new ListViewItem();
            exams.Text = textBox13.Text;
            exams.SubItems.Add(bunifuDropdown5.selectedValue);
            
            TrueOrFalseLV.Items.Add(exams);

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e) //reset
        {
            TrueOrFalseLV.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lisview
            ListViewItem exams = new ListViewItem();
            exams.Text = textBox9.Text;
            exams.SubItems.Add(textBox8.Text);

            ShortAnswerLV.Items.Add(exams);
        }

        // Uptohere

        private void bunifuFlatButton10_Click(object sender, EventArgs e)//reset
        {
            ShortAnswerLV.Items.Clear();
        }

       

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox2.Checked = false; bunifuCheckbox3.Checked = false; bunifuCheckbox4.Checked = false;
            RightAnswer = "A";
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = false; bunifuCheckbox3.Checked = false; bunifuCheckbox4.Checked = false;
            RightAnswer = "B";
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = false; bunifuCheckbox2.Checked = false; bunifuCheckbox4.Checked = false;
            RightAnswer = "C";
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = false; bunifuCheckbox2.Checked = false; bunifuCheckbox3.Checked = false;
            RightAnswer = "D";
        }

        private void MultipleChoiceLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MultipleChoiceLV.Items.Count !=0 && MultipleChoiceLV.SelectedItems.Count !=0)

            {


                if(currentNumOfItems>numOfItems)
                {
                    currentnumMC.Text = Convert.ToString(MultipleChoiceLV.SelectedItems[0].Index + 1);
                    enable_fieldsMC();
                    enable_fieldsMC();
                    updateMC();
                }
                else
                {
                    currentnumMC.Text = Convert.ToString(MultipleChoiceLV.SelectedItems[0].Index + 1);
                    updateMC();
                }

            }      
                    
                    
                    
        }

       

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
