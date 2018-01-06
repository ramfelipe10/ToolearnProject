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
        int numOfItems, currentNumOfItems;
        string RightAnswer;

        List<Panel> listPanel = new List<Panel>();


        public QuizBee()
        {
            InitializeComponent();
        }

        private void resetAllMC()
        {
            
           textBoxQuizQuestion.Text = null;
            textBoxQuizChoiceA.Text = null; textBoxQuizChoiceB.Text = null; textBoxQuizChoiceC.Text = null; textBoxQuizChoiceD.Text = null;
            bunifuCheckbox1.Checked = false; bunifuCheckbox2.Checked = false; bunifuCheckbox3.Checked = false; bunifuCheckbox4.Checked = false;
        }

        private void enable_fieldsMC() {

            bunifuFlatButton2.Enabled = true; //multiplechoice
            bunifuFlatButton3.Enabled = true; //trueOrfalse
            bunifuFlatButton4.Enabled = true; //shortAnswer


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



        }


        private void disable_fieldsMC()
        {

            textBoxQuizQuestion.Enabled = false;
            textBoxQuizChoiceB.Enabled = false;
            textBoxQuizChoiceC.Enabled = false;
            textBoxQuizChoiceD.Enabled = false;


            bunifuCheckbox1.Enabled = false;
            bunifuCheckbox2.Enabled = false;
            bunifuCheckbox3.Enabled = false;
            bunifuCheckbox4.Enabled = false;
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
                 numOfItems = int.Parse(bunifuDropdown6.selectedValue); currentNumOfItems = 1;                
                bunifuFlatButton5.Enabled = false;
                bunifuDropdown6.Enabled = false;
                enable_fieldsMC();
                currentnumMC.Text= currentNumOfItems.ToString();
                CurrentnumSA.Text= currentNumOfItems.ToString();
                CurrentNumTF.Text= currentNumOfItems.ToString();

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
                                buttonNextQuestion.Text = "Confirm";
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

                    if (bunifuDropdown6.selectedValue == null)
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
                                SqlDataAdapter adapt = new SqlDataAdapter("Select facilitator_id from facilitator WHERE username = '" + Program.Session_id + "' ", con);
                                DataTable dt = new DataTable();
                                adapt.Fill(dt);
                                int ID = int.Parse(dt.Rows[0][0].ToString());//Getting the ID of The Facilitator




                                con.Open();
                                String query = "INSERT INTO quizzes (quiz_name,quiz_time_limit,facilitator_id,date_created) VALUES ('" + textBoxQuizTitle.Text + "','h', '" + ID + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";//limit
                                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                int n = sda.SelectCommand.ExecuteNonQuery();

                                con.Close();

                                if (n > 0)
                                {
                                    Dialogue.Show("Quiz Added!", "", "Ok", "Cancel");







                                }
                                else
                                {
                                    Dialogue.Show("Creation Failed!", "", "Ok", "Cancel");




                                }

                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                            }
                            try
                            {

                                SqlCommand cmd = new SqlCommand("select * from quizzes where quiz_name = '" + textBoxQuizTitle.Text + "' AND facilitator_id = (select facilitator_id from facilitator where username = '" + Program.Session_id + "')", con);
                                con.Open();

                                SqlDataReader dr = cmd.ExecuteReader();

                                if (dr.Read() == true)
                                {
                                    int examID = (int)dr[("quiz_id")];
                                    for (int i = 0; i < MultipleChoiceLV.Items.Count; i++)
                                    {
                                        ListViewItem exams = MultipleChoiceLV.Items[i];
                                        try
                                        {
                                            con.Open();
                                            String query = "INSERT INTO answers (answer_a,answer_b,answer_c,answer_d,correct_answer,question_id) VALUES ('" + textBoxQuizChoiceA + "','" + textBoxQuizChoiceB + "','" + textBoxQuizChoiceC + "', '" + textBoxQuizChoiceD + "','" + RightAnswer + "', ' 1 ')";//limit kulang question_id
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                            int n = sda.SelectCommand.ExecuteNonQuery();

                                            con.Close();
                                        }

                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }


                                    }

                                    con.Close();
                                }

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                // if (dr != null) datareaderDB.Close();
                                // if (connectDB != null) connectDB.Close();
                            }
                        }
                    }

                    break;


            }
        }
        private void bunifuFlatButton9_Click(object sender, EventArgs e) //reset
        {
            MultipleChoiceLV.Items.Clear();
            
        }

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

        private void bunifuFlatButton10_Click(object sender, EventArgs e)//reset
        {
            ShortAnswerLV.Items.Clear();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
            RightAnswer = "A";
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
