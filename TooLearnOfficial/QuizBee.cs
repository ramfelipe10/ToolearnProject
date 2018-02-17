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
using System.IO;

namespace TooLearnOfficial
{
    public partial class QuizBee : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlConnection con2 = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlDataReader dr;
        int currentNumOfItems;
        string RightAnswer, imageLocation;
        byte[] imgFile = null;


        List<Panel> listPanel = new List<Panel>();


        public QuizBee()
        {
            InitializeComponent();
        }

        private void resetAllMC()
        {
            textBox11.Text = null;
           
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
           
            textBox9.Text = null;
            textBox8.Text = null;
            pictureBox4.ImageLocation = null;


        }

        private void resetAllTF()
        {
            textBox10.Text = null;
            textBox5.Text = null;
           
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
           
            textBoxQuizChoiceA.Enabled = true;
            textBoxQuizChoiceB.Enabled = true;
            textBoxQuizChoiceC.Enabled = true;
            textBoxQuizChoiceD.Enabled = true;


            bunifuCheckbox1.Enabled = true;
            bunifuCheckbox2.Enabled = true;
            bunifuCheckbox3.Enabled = true;
            bunifuCheckbox4.Enabled = true;

            buttonNextQuestion.Enabled = true;
            button3.Enabled = true;

            //For Short Answer
            bunifuFlatButton7.Enabled = true;
            textBox3.Enabled = true;
          
            textBox12.Enabled = true;
            textBox9.Enabled = true;
            textBox8.Enabled = true;

            //For TrueFalse

            textBox13.Enabled = true;
            bunifuDropdown5.Enabled = true;
            bunifuFlatButton8.Enabled = true;
            textBox10.Enabled = true;
            textBox5.Enabled = true;
          

        }


        private void disable_fieldsMC()
        {

            bunifuFlatButton2.Enabled = false; //multiplechoice
            bunifuFlatButton3.Enabled = false; //trueOrfalse
            bunifuFlatButton4.Enabled = false; //shortAnswer

            //For Multiple Choice
            textBox11.Enabled = false;
            textBox2.Enabled = false;
           
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
            button3.Enabled = false;

            //For Short Answer
            bunifuFlatButton7.Enabled = false;
            textBox3.Enabled = false;
           
            textBox12.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;

            //For TrueFalse

            textBox13.Enabled = false;
            bunifuDropdown5.Enabled = false;
            bunifuFlatButton8.Enabled = false;
            textBox10.Enabled = false;
            textBox5.Enabled = false;
           


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
            pictureBox3.ImageLocation = exams.SubItems[6].Text;
            textBox11.Text= exams.SubItems[7].Text;
            textBox2.Text= exams.SubItems[8].Text;
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

        private void updateTF()
        {
            button2.Text = "Update";
            ListViewItem exams = TrueOrFalseLV.SelectedItems[0];
            textBox13.Text = exams.Text;
            pictureBox5.ImageLocation = exams.SubItems[2].Text;
            textBox10.Text= exams.SubItems[3].Text;
            textBox5.Text = exams.SubItems[4].Text;


        }

        private void updateSA()
        {
            button1.Text = "Update";
            ListViewItem exams = ShortAnswerLV.SelectedItems[0];
            textBox9.Text = exams.Text;
            textBox8.Text = exams.SubItems[1].Text;
            pictureBox4.ImageLocation= exams.SubItems[2].Text;
            textBox12.Text = exams.SubItems[3].Text;
            textBox3.Text= exams.SubItems[4].Text;






        }




        private void clearAllMC()
        {
            textBoxQuizTitle.Text = null;
            textBox7.Text = null;            
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
            QuizFormat.Text = "Multiple Choice";
            NoItems.Text = MultipleChoiceLV.Items.Count.ToString();
            int Sum = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count ;
            Total.Text = Sum.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            trueORfalse.BringToFront();
            TrueOrFalseLV.BringToFront();
            QuizFormat.Text = "True/False";
            NoItems.Text = TrueOrFalseLV.Items.Count.ToString();
            int Sum = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
            Total.Text = Sum.ToString();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            shortAnswer.BringToFront();
            ShortAnswerLV.BringToFront();
            QuizFormat.Text = "Short Answer";
            NoItems.Text = ShortAnswerLV.Items.Count.ToString();
            int Sum = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
            Total.Text = Sum.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

          
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
        /*    
            if (bunifuDropdown6.selectedIndex == -1)
            {
                Dialogue.Show("Please Indicate Number Of Items", "", "Ok", "Cancel");
            }

            else
            { */

                if (textBox7.Text == "")
                {
                    label20.Visible = true; //MC
                bunifuDropdown2.Visible = true;
                    textBox11.Visible = true;


                    label17.Visible = true; //SA
                bunifuDropdown3.Visible = true;
                    textBox12.Visible = true;


                    label24.Visible = true; //TF
                bunifuDropdown4.Visible = true;
                    textBox10.Visible = true;

                    label5.Visible = false; //TimeLimitQuiz
                    textBox7.Visible = false;
                bunifuDropdown1.Visible = false;
                  
                }


                else
                {
                    label20.Visible = false; //MC
                bunifuDropdown2.Visible = false;
                textBox11.Visible = false;


                    label17.Visible = false; //SA
                bunifuDropdown3.Visible = false;
                textBox12.Visible = false;


                    label24.Visible = false; //TF
                bunifuDropdown4.Visible = false;
                textBox10.Visible = false;


                    label5.Visible = true; //TimeLimitQuiz
                    textBox7.Visible = true;
               
                    textBox7.Enabled = false;

                }
            /*  numOfItems = int.Parse(bunifuDropdown6.selectedValue); */

                currentNumOfItems = 1;   
            
                bunifuFlatButton5.Enabled = false;
                enable_fieldsMC();
                currentnumMC.Text= currentNumOfItems.ToString();
                CurrentnumSA.Text= currentNumOfItems.ToString();
                CurrentNumTF.Text= currentNumOfItems.ToString();
                MultipleChoiceLV.Enabled = true;
                ShortAnswerLV.Enabled = true;
                TrueOrFalseLV.Enabled = true;


       //     } 
            
        }


        private void bunifuImageButton3_Click(object sender, EventArgs e)//Refresh
        {
            DialogResult Result = Dialogue1.Show("Do You Wan't To Continue? \nResetting May Affect Questions and Answers You've Created.", "Confirmation", "Ok", "Cancel");
            if(Result == DialogResult.Yes)
            {

                label20.Visible = true; //MC
                bunifuDropdown2.Visible = true;
                textBox11.Visible = true;


                label17.Visible = true; //SA
                bunifuDropdown3.Visible = true;
                textBox12.Visible = true;


                label24.Visible = true; //TF
                bunifuDropdown4.Visible = true;
                textBox10.Visible = true;

                label5.Visible = true; //TimeLimitQuiz
                textBox7.Visible = true;
                
                textBox7.Enabled = true;


                Total.Text = "0";
                NoItems.Text = "0";
                QuizFormat.Text = "Multiple Choice";

                currentNumOfItems = 0;
                currentnumMC.Text = null;
                CurrentnumSA.Text = null;
                CurrentNumTF.Text = null;
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
                textBox7.Text = null;



            }



        }


        private void buttonNextQuestion_Click(object sender, EventArgs e)//for multiple choice next
        {

            switch (buttonNextQuestion.Text)
            {
                case "Next":

                    if (textBox7.Visible == false)
                    {


                        if (textBoxQuizQuestion.Text == "" || textBox2.Text == "" || textBox11.Text == "" || textBoxQuizChoiceA.Text == "" ||
                            textBoxQuizChoiceB.Text == "" || textBoxQuizChoiceC.Text == "" || textBoxQuizChoiceD.Text == "" || RightAnswer == null)
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {

                            ListViewItem exams4 = new ListViewItem();
                            exams4.Text = textBoxQuizQuestion.Text;
                            exams4.SubItems.Add(textBoxQuizChoiceA.Text);
                            exams4.SubItems.Add(textBoxQuizChoiceB.Text);
                            exams4.SubItems.Add(textBoxQuizChoiceC.Text);
                            exams4.SubItems.Add(textBoxQuizChoiceD.Text);
                            exams4.SubItems.Add(RightAnswer);
                            //
                            exams4.SubItems.Add(pictureBox3.ImageLocation);

                            exams4.SubItems.Add(textBox11.Text);
                            exams4.SubItems.Add(textBox2.Text);
                            //
                            MultipleChoiceLV.Items.Add(exams4);
                            currentNumOfItems++;

                            currentnumMC.Text = currentNumOfItems.ToString();
                            CurrentnumSA.Text = currentNumOfItems.ToString();
                            CurrentNumTF.Text = currentNumOfItems.ToString();
                            rightAnswer = null;
                            //
                            pictureBox3.ImageLocation = null;
                            //
                            resetAllMC();

                            NoItems.Text = MultipleChoiceLV.Items.Count.ToString();
                            int Sum2 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                            Total.Text = Sum2.ToString();



                        } //If TB 7=False

                    }

                    if(textBox7.Visible == true) // TB 7=True
                    {

                        if (textBoxQuizQuestion.Text == "" || textBox2.Text == "" || textBoxQuizChoiceA.Text == "" ||
                           textBoxQuizChoiceB.Text == "" || textBoxQuizChoiceC.Text == "" || textBoxQuizChoiceD.Text == "" || RightAnswer == null)
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {
      
                                ListViewItem exams4 = new ListViewItem();
                                exams4.Text = textBoxQuizQuestion.Text;
                                exams4.SubItems.Add(textBoxQuizChoiceA.Text);
                                exams4.SubItems.Add(textBoxQuizChoiceB.Text);
                                exams4.SubItems.Add(textBoxQuizChoiceC.Text);
                                exams4.SubItems.Add(textBoxQuizChoiceD.Text);
                                exams4.SubItems.Add(RightAnswer);
                            //
                            exams4.SubItems.Add(pictureBox3.ImageLocation);
                            exams4.SubItems.Add(textBox11.Text);
                            exams4.SubItems.Add(textBox2.Text);
                            //
                            MultipleChoiceLV.Items.Add(exams4);
                                currentNumOfItems++;

      
                                    currentnumMC.Text = currentNumOfItems.ToString();
                                    CurrentnumSA.Text = currentNumOfItems.ToString();
                                    CurrentNumTF.Text = currentNumOfItems.ToString();
                                    rightAnswer = null;
                                    resetAllMC();

                            NoItems.Text = MultipleChoiceLV.Items.Count.ToString();
                            int Sum2 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                            Total.Text = Sum2.ToString();
                        }

                    }

                    break;


                case "Update":
               
                        int listPosition = int.Parse(MultipleChoiceLV.SelectedIndices[0].ToString());
                        ListViewItem exams = new ListViewItem();
                        exams.Text = textBoxQuizQuestion.Text;
                        exams.SubItems.Add(textBoxQuizChoiceA.Text);
                        exams.SubItems.Add(textBoxQuizChoiceB.Text);
                        exams.SubItems.Add(textBoxQuizChoiceC.Text);
                        exams.SubItems.Add(textBoxQuizChoiceD.Text);
                        exams.SubItems.Add(RightAnswer);
                    //
                    exams.SubItems.Add(pictureBox3.ImageLocation);
                    exams.SubItems.Add(textBox11.Text);
                    exams.SubItems.Add(textBox2.Text);
                    //
                    MultipleChoiceLV.Items.RemoveAt(listPosition);
                        MultipleChoiceLV.Items.Insert(listPosition, exams);

                    int Sum1 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;

                        currentnumMC.Text = Convert.ToString(Sum1 + 1);
                        CurrentnumSA.Text = Convert.ToString(Sum1 + 1);
                        CurrentNumTF.Text = Convert.ToString(Sum1 + 1);
                        RightAnswer = null;
                        resetAllMC(); ;
                        buttonNextQuestion.Text = "Next";

                    NoItems.Text = MultipleChoiceLV.Items.Count.ToString();
                    int Sum = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                    Total.Text = Sum.ToString();

                    break;



            }
        }


             

        private void button2_Click(object sender, EventArgs e)//for true or false Next
        {
            switch (button2.Text)
            {
                case "Next":

                    if (textBox7.Visible == false)
                    {


                        if (textBox10.Text == "" || textBox13.Text == "" || textBox5.Text == "")
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {

                            ListViewItem exams2 = new ListViewItem();
                            exams2.Text = textBox13.Text;
                            exams2.SubItems.Add(bunifuDropdown5.selectedValue);
                            //
                            exams2.SubItems.Add(pictureBox5.ImageLocation);
                            exams2.SubItems.Add(textBox10.Text);
                            exams2.SubItems.Add(textBox5.Text);

                            //

                            TrueOrFalseLV.Items.Add(exams2);
                            currentNumOfItems++;

                            currentnumMC.Text = currentNumOfItems.ToString();
                            CurrentnumSA.Text = currentNumOfItems.ToString();
                            CurrentNumTF.Text = currentNumOfItems.ToString();


                            //
                            pictureBox5.ImageLocation = null;
                            //

                            resetAllTF();

                            NoItems.Text = TrueOrFalseLV.Items.Count.ToString();
                            int Sum2 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                            Total.Text = Sum2.ToString();
                        }


                    } //If TB 7=False



                    if (textBox7.Visible == true) // TB 7=True
                    {

                        if (textBox13.Text == "" || textBox5.Text == "")
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {

                            ListViewItem exams2 = new ListViewItem();
                            exams2.Text = textBox13.Text;
                            exams2.SubItems.Add(bunifuDropdown5.selectedValue);
                            //
                            exams2.SubItems.Add(pictureBox5.ImageLocation);
                            exams2.SubItems.Add(textBox10.Text);
                            exams2.SubItems.Add(textBox5.Text);
                            //
                            TrueOrFalseLV.Items.Add(exams2);
                            currentNumOfItems++;

                            currentnumMC.Text = currentNumOfItems.ToString();
                            CurrentnumSA.Text = currentNumOfItems.ToString();
                            CurrentNumTF.Text = currentNumOfItems.ToString();

                            //
                            pictureBox5.ImageLocation = null;
                            //

                            resetAllTF();

                            NoItems.Text = TrueOrFalseLV.Items.Count.ToString();
                            int Sum2 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                            Total.Text = Sum2.ToString();

                        }

                    }

                    break;


                case "Update":

                    int listPosition = int.Parse(TrueOrFalseLV.SelectedIndices[0].ToString());
                    ListViewItem exams1 = new ListViewItem();
                    exams1.Text = textBox13.Text;
                    exams1.SubItems.Add(bunifuDropdown5.selectedValue);
                    //
                    exams1.SubItems.Add(pictureBox5.ImageLocation);
                    exams1.SubItems.Add(textBox10.Text);
                    exams1.SubItems.Add(textBox5.Text);
                    //

                    TrueOrFalseLV.Items.RemoveAt(listPosition);
                    TrueOrFalseLV.Items.Insert(listPosition, exams1);
                    int Sum1 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;

                    currentnumMC.Text = Convert.ToString(Sum1 + 1);
                    CurrentnumSA.Text = Convert.ToString(Sum1 + 1);
                    CurrentNumTF.Text = Convert.ToString(Sum1 + 1);

                    resetAllTF(); ;
                    button2.Text = "Next";

                    NoItems.Text = TrueOrFalseLV.Items.Count.ToString();
                    int Sum = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                    Total.Text = Sum.ToString();

                    break;


            }


        }



        private void button1_Click(object sender, EventArgs e) //Short Answer
        {

            switch (button1.Text)
            {
                case "Next":

                    if (textBox7.Visible == false)
                    {


                        if (textBox9.Text == "" || textBox8.Text == "" || textBox3.Text == "" || textBox12.Text == "")
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {
                          
                            ListViewItem exams2 = new ListViewItem();
                            exams2.Text = textBox9.Text;
                            exams2.SubItems.Add(textBox8.Text);
                            //
                            exams2.SubItems.Add(pictureBox4.ImageLocation);

                            exams2.SubItems.Add(textBox12.Text);
                            exams2.SubItems.Add(textBox3.Text);
                            //
                            ShortAnswerLV.Items.Add(exams2);

                            currentNumOfItems++;

                            currentnumMC.Text = currentNumOfItems.ToString();
                            CurrentnumSA.Text = currentNumOfItems.ToString();
                            CurrentNumTF.Text = currentNumOfItems.ToString();


                            //
                            pictureBox4.ImageLocation = null;
                            //

                            resetAllSA();

                            NoItems.Text = ShortAnswerLV.Items.Count.ToString();
                            int Sum2 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                            Total.Text = Sum2.ToString();
                        }


                    } //If TB 7=False



                    if (textBox7.Visible == true) // TB 7=True
                    {

                        if (textBox9.Text == "" || textBox8.Text == "" || textBox3.Text == "")
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {

                            ListViewItem exams2 = new ListViewItem();
                            exams2.Text = textBox9.Text;
                            exams2.SubItems.Add(textBox8.Text);
                            //
                            exams2.SubItems.Add(pictureBox4.ImageLocation);
                            exams2.SubItems.Add(textBox12.Text);
                            exams2.SubItems.Add(textBox3.Text);
                            //
                            ShortAnswerLV.Items.Add(exams2);
                            currentNumOfItems++;

                            currentnumMC.Text = currentNumOfItems.ToString();
                            CurrentnumSA.Text = currentNumOfItems.ToString();
                            CurrentNumTF.Text = currentNumOfItems.ToString();

                            //
                            pictureBox4.ImageLocation = null;
                            //


                            resetAllSA();

                            NoItems.Text = ShortAnswerLV.Items.Count.ToString();
                            int Sum2 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                            Total.Text = Sum2.ToString();

                        }

                    }

                    break;


                case "Update":

                    int listPosition = int.Parse(ShortAnswerLV.SelectedIndices[0].ToString());
                    ListViewItem exams3 = new ListViewItem();
                    exams3.Text = textBox9.Text;
                    exams3.SubItems.Add(textBox8.Text);
                    //
                    exams3.SubItems.Add(pictureBox4.ImageLocation);
                    exams3.SubItems.Add(textBox12.Text);
                    exams3.SubItems.Add(textBox3.Text);
                    //

                    ShortAnswerLV.Items.RemoveAt(listPosition);
                    ShortAnswerLV.Items.Insert(listPosition, exams3);
                    int Sum1 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;

                    currentnumMC.Text = Convert.ToString(Sum1 + 1);
                    CurrentnumSA.Text = Convert.ToString(Sum1 + 1);
                    CurrentNumTF.Text = Convert.ToString(Sum1 + 1);

                    resetAllSA(); ;
                    button1.Text = "Next";

                    NoItems.Text = ShortAnswerLV.Items.Count.ToString();
                    int Sum = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                    Total.Text = Sum.ToString();

                    break;

                    
            }








        }
              
        /*************VALIDATORS*********************/

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


        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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


               
                
                    currentnumMC.Text = Convert.ToString(MultipleChoiceLV.SelectedItems[0].Index + 1);
                    updateMC();
               

            }      
                    
                    
                    
        }

       

    

        private void button3_Click(object sender, EventArgs e)
        {
           

            if (textBoxQuizTitle.Text == "")
            {
                Dialogue.Show("Please Complete All indicated Field Before You Proceed(Quiz Title)", "", "Ok", "Cancel");
            }
            else if (MultipleChoiceLV.Items.Count <= 0 && ShortAnswerLV.Items.Count <= 0 && TrueOrFalseLV.Items.Count <= 0)
            {
                Dialogue.Show("Quiz is Empty", "", "Ok", "Cancel");
            }
            else
            {
                DialogResult result = Dialogue1.Show("Saving This Quiz Means You are Done. Do you Wish to Continue?", "", "Ok", "Cancel");
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        con.Open();








                        String query = "INSERT INTO quizzes (quiz_title,quiz_time_limit,facilitator_id,date_created) VALUES ('" + textBoxQuizTitle.Text + "','" + textBox7.Text + "', '" + Program.user_id + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";//limit
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();


                       


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    con.Close();


                    try
                    {


                        con.Open();

                        SqlCommand cmd = new SqlCommand("select * from quizzes where quiz_title = '" + textBoxQuizTitle.Text + "' AND facilitator_id = '" + Program.user_id + "' ", con);


                        dr = cmd.ExecuteReader();


                        if (dr.Read() == true)
                        {
                            int examID = (int)dr[("quiz_id")];
                            for (int i = 0; i < MultipleChoiceLV.Items.Count; i++) // For Multiple Choice
                            {
                                ListViewItem exams = MultipleChoiceLV.Items[i];
                                try
                                {
                                    if (exams.SubItems[6].Text != "")
                                    {
                                        FileStream fileStream = new FileStream(exams.SubItems[6].Text, FileMode.Open, FileAccess.Read);
                                        BinaryReader binaryReader = new BinaryReader(fileStream);
                                        imgFile = binaryReader.ReadBytes((int)fileStream.Length);


                                        con2.Open();

                                        if (textBox7.Visible == true)
                                        {

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,answer_a,answer_b,answer_c,answer_d,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('Multiple Choice','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[5].Text + "','" + examID + "','" + exams.SubItems[8].Text + "', @IMG,'" + textBox7.Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                            sda.SelectCommand.Parameters.AddWithValue("@IMG", imgFile);
                                            sda.SelectCommand.ExecuteNonQuery();
                                        }

                                        else
                                        {

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,answer_a,answer_b,answer_c,answer_d,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('Multiple Choice','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[5].Text + "','" + examID + "','" + exams.SubItems[8].Text + "', @IMG,'" + exams.SubItems[7].Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                            sda.SelectCommand.Parameters.AddWithValue("@IMG", imgFile);
                                            sda.SelectCommand.ExecuteNonQuery();


                                        }

                                    }


                                    else
                                    {
                                        con2.Open();

                                        if (textBox7.Visible == true)
                                        {

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,answer_a,answer_b,answer_c,answer_d,correct_answer,quiz_id,points,QA_time_limit) VALUES ('Multiple Choice','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[5].Text + "','" + examID + "','" + exams.SubItems[8].Text + "','" + textBox7.Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                            sda.SelectCommand.ExecuteNonQuery();
                                            
                                        }


                                        else
                                        {
                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,answer_a,answer_b,answer_c,answer_d,correct_answer,quiz_id,points,QA_time_limit) VALUES ('Multiple Choice','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[5].Text + "','" + examID + "','" + exams.SubItems[8].Text + "','" + exams.SubItems[7].Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                            sda.SelectCommand.ExecuteNonQuery();
                                        }


                                    }

                                }

                                catch (Exception ex)
                                {
                                   MessageBox.Show(ex.Message);
                                }
                                con2.Close();

                            }





                            // // // // // // // // 

                            for (int i = 0; i < ShortAnswerLV.Items.Count; i++) //For Short Answers
                            {
                                ListViewItem exams = ShortAnswerLV.Items[i];
                                try
                                {
                                    if (exams.SubItems[2].Text != "")
                                    {
                                        FileStream fileStream = new FileStream(exams.SubItems[2].Text, FileMode.Open, FileAccess.Read);
                                        BinaryReader binaryReader = new BinaryReader(fileStream);
                                        imgFile = binaryReader.ReadBytes((int)fileStream.Length);



                                        con2.Open();

                                        if (textBox7.Visible == true)
                                        {

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('Short Answer','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "', @IMG,'" + textBox7.Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                            sda.SelectCommand.Parameters.AddWithValue("@IMG", imgFile);
                                            sda.SelectCommand.ExecuteNonQuery();

                                        }




                                        else
                                        {
                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('Short Answer','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "', @IMG,'" + exams.SubItems[3].Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                            sda.SelectCommand.Parameters.AddWithValue("@IMG", imgFile);
                                            sda.SelectCommand.ExecuteNonQuery();
                                        }


                                    }



                                    else
                                    {
                                        con2.Open();

                                        if (textBox7.Visible == true)
                                        {

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,QA_time_limit) VALUES ('Short Answer','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "','" + textBox7.Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.ExecuteNonQuery();
                                        }


                                        else
                                        {

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,QA_time_limit) VALUES ('Short Answer','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[3].Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.ExecuteNonQuery();
                                        }
                                    }


                                }

                                catch (Exception ex)
                                {
                                   MessageBox.Show(ex.Message);
                                }
                                con2.Close();

                            }


                            // /// // // // // // // 







                            // // // / // // / // / // 



                            for (int i = 0; i < TrueOrFalseLV.Items.Count; i++) //For True Or False
                            {
                                ListViewItem exams = TrueOrFalseLV.Items[i];
                                try
                                {
                                    if (exams.SubItems[2].Text != "")
                                    {
                                        FileStream fileStream = new FileStream(exams.SubItems[2].Text, FileMode.Open, FileAccess.Read);
                                        BinaryReader binaryReader = new BinaryReader(fileStream);
                                        imgFile = binaryReader.ReadBytes((int)fileStream.Length);



                                        con2.Open();

                                        if (textBox7.Visible == true)
                                        {

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('True/False','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "', @IMG,'" + textBox7.Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.Parameters.AddWithValue("@IMG", imgFile);
                                            sda.SelectCommand.ExecuteNonQuery();
                                        }


                                        else
                                        {
                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('True/False','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "', @IMG,'" + exams.SubItems[3].Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.Parameters.AddWithValue("@IMG", imgFile);
                                            sda.SelectCommand.ExecuteNonQuery();
                                        }
                                    }



                                    else
                                    {
                                        con2.Open();


                                        if (textBox7.Visible == true)
                                        {

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,QA_time_limit) VALUES ('True/False','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "','" + textBox7.Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.ExecuteNonQuery();
                                        }



                                        else
                                        {
                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,QA_time_limit) VALUES ('True/False','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[3].Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.ExecuteNonQuery();
                                        }

                                    }


                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                con2.Close();

                            }



                            // / // // / /// / // / // / // / / / / //

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
                    currentNumOfItems = 0;                    
                     bunifuFlatButton5.Enabled = true;
                    Dialogue.Show("Quiz Saved In the Database", "", "Ok", "Cancel");
                    this.Close();
                    //popop new form to launch or go to home and this.close


                }
            }







        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void TrueOrFalseLV_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TrueOrFalseLV.Items.Count != 0 && TrueOrFalseLV.SelectedItems.Count != 0)

            {


             
                
              
                    CurrentNumTF.Text = Convert.ToString(TrueOrFalseLV.SelectedItems[0].Index + 1);
                    updateTF();
              

            }



        }

        private void ShortAnswerLV_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ShortAnswerLV.Items.Count != 0 && ShortAnswerLV.SelectedItems.Count != 0)

            {





                CurrentnumSA.Text = Convert.ToString(ShortAnswerLV.SelectedItems[0].Index + 1);
                updateSA();


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
