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
       // byte[] imgFile = null;


        List<Panel> listPanel = new List<Panel>();


        public QuizBee()
        {
            InitializeComponent();
            SetDoubleBuffered(bunifuGradientPanel1);
            SetDoubleBuffered(MultipleChoice);
            SetDoubleBuffered(shortAnswer);
            SetDoubleBuffered(trueORfalse);
            SetDoubleBuffered(header);
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






        private int totalitems()
        {
            int sum = 0;
            foreach (ListViewItem li in MultipleChoiceLV.Items)
            {
                sum += int.Parse(li.SubItems[8].Text);
            }
            foreach (ListViewItem li in TrueOrFalseLV.Items)
            {
                sum += int.Parse(li.SubItems[4].Text);
            }
            foreach (ListViewItem li in ShortAnswerLV.Items)
            {
                sum += int.Parse(li.SubItems[4].Text);
            }

            return sum;
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

            bunifuDropdown2.Enabled = true;

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



        private string get(string answer)
        {
            string RA = answer;
            string value="";
           
            char[] answerchar = RA.ToArray();
            for (int i = 0; i < RA.Count(); i++)
            {
                if ((i % 2) == 0) 
                {
                    value += answerchar[i].ToString();
                }
               
            }

            return value;
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
            if (pictureBox3.ImageLocation == "")
            {
                bunifuFlatButton1.Visible = true;
            }

            else
            {
                bunifuFlatButton1.Visible = false;
            }

            string plain = get(exams.SubItems[5].Text);

            for (int i = 0; i < plain.Length; i++)
            {
                string each = plain[i].ToString();
                if (each == "A")
                {
                    RightAnswer = RightAnswer + ",A";
                    bunifuCheckbox1.Checked = true;

                }
                else if (each == "B")
                {
                    RightAnswer = RightAnswer + ",B";
                    bunifuCheckbox2.Checked = true;
                }

                else if (each == "C")
                {
                    RightAnswer = RightAnswer + ",C";
                    bunifuCheckbox3.Checked = true;

                }
                else
                {
                    RightAnswer = RightAnswer + ",D";

                    bunifuCheckbox4.Checked = true;
                }

            }



            if (textBox7.Visible == true)
            {
                label20.Visible = true; //MC
                bunifuDropdown2.Visible = true;
                textBox11.Visible = true;
            }

                //     if (textBox7.Visible == false)
                //     {

                string str = exams.SubItems[7].Text;
                int index = str.IndexOf('(');
                string sub;
                if (index >= 0)
                {
                    sub = str.Substring(0, index);



                }
                else
                {

                    sub = str;
                }

                textBox11.Text = sub;


                string cut = exams.SubItems[7].Text;
                int ind = cut.IndexOf('(');
                string form;
                if (ind >= 0)
                {
                    form = cut.Substring(ind + 1, 7);



                }
                else
                {

                    form = cut;
                }


                if (form == "Minutes")
                {
                    bunifuDropdown2.selectedIndex = 0;
                }

                else
                {
                    bunifuDropdown2.selectedIndex = 1;
                }



         //   }//end IF
       

            textBox2.Text = exams.SubItems[8].Text;

        }

        private void updateTF()
        {
            button2.Text = "Update";
            ListViewItem exams = TrueOrFalseLV.SelectedItems[0];
            textBox13.Text = exams.Text;


           if(exams.SubItems[1].Text == "True")
            {
                bunifuDropdown5.selectedIndex = 0;
            }

            else
            {
                bunifuDropdown5.selectedIndex = 1;
            }
            pictureBox5.ImageLocation = exams.SubItems[2].Text;
            if (pictureBox5.ImageLocation == "")
            {
                bunifuFlatButton8.Visible = true;
            }

            else
            {
                bunifuFlatButton8.Visible = false;
            }

            if (textBox7.Visible == true)
            {
            
                label24.Visible = true; //TF
                bunifuDropdown4.Visible = true;
                textBox10.Visible = true;
               
            }

            //     if (textBox7.Visible == false)
            //     {
            string str = exams.SubItems[3].Text;
            int index = str.IndexOf('(');
            string sub;
            if (index >= 0)
            {
                sub = str.Substring(0, index);



            }
            else
            {

                sub = str;
            }
            textBox10.Text= sub;

           

                string cut = exams.SubItems[3].Text;
                int ind = cut.IndexOf('(');
                string form;
                if (ind >= 0)
                {
                    form = cut.Substring(ind + 1, 7);



                }
                else
                {

                    form = cut;
                }


                if (form == "Minutes")
                {
                    bunifuDropdown4.selectedIndex = 0;
                }

                else
                {
                    bunifuDropdown4.selectedIndex = 1;
                }


        //    }//end IF

            textBox5.Text = exams.SubItems[4].Text;

        }

        private void updateSA()
        {
            button1.Text = "Update";
            ListViewItem exams = ShortAnswerLV.SelectedItems[0];
            textBox9.Text = exams.Text;
            textBox8.Text = exams.SubItems[1].Text;
            pictureBox4.ImageLocation= exams.SubItems[2].Text;
            if (pictureBox4.ImageLocation == "")
            {
                bunifuFlatButton7.Visible = true;
            }

            else
            {
                bunifuFlatButton7.Visible = false;
            }

            if (textBox7.Visible == true)
            {
                label17.Visible = true; //SA
                bunifuDropdown3.Visible = true;
                textBox12.Visible = true;                
            }

            //     if (textBox7.Visible == false)
            //     {
            string str = exams.SubItems[3].Text;
                int index = str.IndexOf('(');
                string sub;
                if (index >= 0)
                {
                    sub = str.Substring(0, index);



                }
                else
                {

                    sub = str;
                }

                textBox12.Text = sub;



                string cut = exams.SubItems[3].Text;
                int ind = cut.IndexOf('(');
                string form;
                if (ind >= 0)
                {
                    form = cut.Substring(ind + 1, 7);



                }
                else
                {

                    form = cut;
                }


                if (form == "Minutes")
                {
                    bunifuDropdown3.selectedIndex = 0;
                }

                else
                {
                    bunifuDropdown3.selectedIndex = 1;
                }

          //  }// end IF

            textBox3.Text = exams.SubItems[4].Text;

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

                    bunifuFlatButton1.Visible = false;
                    bunifuFlatButton6.Visible = true;


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

                    bunifuFlatButton7.Visible = false;
                    bunifuFlatButton9.Visible = true;

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

                    bunifuFlatButton8.Visible = false;
                    bunifuFlatButton10.Visible = true;


                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From quizzes Where quiz_title ='" + textBoxQuizTitle.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int check = Convert.ToInt32(dt.Rows[0][0].ToString());

            if (check >= 1)
            {

                Dialogue.Show("Quiz already exist, please use other Title", "", "Ok", "Cancel");
            }

            else
            {

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
                    bunifuDropdown1.Enabled = false;

                }


                currentNumOfItems = 1;

                bunifuFlatButton5.Enabled = false;
                enable_fieldsMC();
                currentnumMC.Text = currentNumOfItems.ToString();
                CurrentnumSA.Text = currentNumOfItems.ToString();
                CurrentNumTF.Text = currentNumOfItems.ToString();
                MultipleChoiceLV.Enabled = true;
                ShortAnswerLV.Enabled = true;
                TrueOrFalseLV.Enabled = true;

                bunifuFlatButton2.selected = true;

                textBoxQuizTitle.Enabled = false;

            }
            
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
                bunifuDropdown1.Visible = true;
                bunifuDropdown1.Enabled = true;
                
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




                
                bunifuFlatButton8.Visible = true;
                bunifuFlatButton1.Visible = true;
                bunifuFlatButton7.Visible = true;

                textBoxQuizTitle.Enabled = true;

            }



        }


        private void buttonNextQuestion_Click(object sender, EventArgs e)//for multiple choice next
        {
            string TimeF;

            switch (buttonNextQuestion.Text)
            {
                case "Next":

                    if (textBox7.Visible == false)
                    {


                        if (textBoxQuizQuestion.Text == "" || textBox2.Text == "" || textBox11.Text == "" || textBoxQuizChoiceA.Text == "" ||
                            textBoxQuizChoiceB.Text == "" || textBoxQuizChoiceC.Text == "" || textBoxQuizChoiceD.Text == "" || RightAnswer == null || RightAnswer == "")
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



                            /*    string s = "";
                                foreach(Control cc in this.Controls)
                                {
                                    if (cc is CheckBox)
                                    {
                                        CheckBox b = (CheckBox)cc;
                                        if (b.Checked)
                                        {
                                            s = b.Text + ", " + s;
                                        }
                                    }
                                } 

                            string s = RightAnswer;
                            if (s.StartsWith(","))
                            {
                                s = s.Substring(1);
                            }  

                            exams4.SubItems.Add(s); */
                            //  
                            RightAnswer=RightAnswer.TrimStart(',');
                            exams4.SubItems.Add(RightAnswer);

                            exams4.SubItems.Add(pictureBox3.ImageLocation);

                            
                            if(bunifuDropdown2.selectedIndex==0)//Minutes
                            {
                                TimeF = textBox11.Text + "(Minutes)";
                            }

                            else
                            {
                                TimeF = textBox11.Text + "(Seconds)";
                            }
                            exams4.SubItems.Add(TimeF);//TimeLimit

                            exams4.SubItems.Add(textBox2.Text);
                            //
                            MultipleChoiceLV.Items.Add(exams4);
                            currentNumOfItems++;

                            currentnumMC.Text = currentNumOfItems.ToString();
                            CurrentnumSA.Text = currentNumOfItems.ToString();
                            CurrentNumTF.Text = currentNumOfItems.ToString();
                            RightAnswer = null;///rightanswer
                            //
                            pictureBox3.ImageLocation = null;
                            //
                            resetAllMC();

                            NoItems.Text = MultipleChoiceLV.Items.Count.ToString();
                            int Sum2 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                            Total.Text = Sum2.ToString();

                            bunifuFlatButton1.Visible = true;

                        } //If TB 7=False

                    }

                 //   if(textBox7.Visible == true) // TB 7=True
                 else
                    {

                        if (textBoxQuizQuestion.Text == "" || textBox2.Text == "" || textBoxQuizChoiceA.Text == "" ||
                           textBoxQuizChoiceB.Text == "" || textBoxQuizChoiceC.Text == "" || textBoxQuizChoiceD.Text == "" || RightAnswer == null || RightAnswer == "")
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {
                            string TimeF2;


                                ListViewItem exams4 = new ListViewItem();
                                exams4.Text = textBoxQuizQuestion.Text;
                                exams4.SubItems.Add(textBoxQuizChoiceA.Text);
                                exams4.SubItems.Add(textBoxQuizChoiceB.Text);
                                exams4.SubItems.Add(textBoxQuizChoiceC.Text);
                                exams4.SubItems.Add(textBoxQuizChoiceD.Text);
                            RightAnswer = RightAnswer.TrimStart(',');
                            exams4.SubItems.Add(RightAnswer);
                            //
                            exams4.SubItems.Add(pictureBox3.ImageLocation);
                            // exams4.SubItems.Add(textBox11.Text);

                            if (bunifuDropdown1.selectedIndex == 0)//Minutes
                            {
                                TimeF2 = textBox7.Text + "(Minutes)";
                            }

                            else
                            {
                                TimeF2 = textBox7.Text + "(Seconds)";
                            }

                            exams4.SubItems.Add(TimeF2);

                            exams4.SubItems.Add(textBox2.Text);
                            //
                            MultipleChoiceLV.Items.Add(exams4);
                                currentNumOfItems++;

      
                                    currentnumMC.Text = currentNumOfItems.ToString();
                                    CurrentnumSA.Text = currentNumOfItems.ToString();
                                    CurrentNumTF.Text = currentNumOfItems.ToString();
                            RightAnswer = null;///rightanswer
                            resetAllMC();

                            NoItems.Text = MultipleChoiceLV.Items.Count.ToString();
                            int Sum2 = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;
                            Total.Text = Sum2.ToString();


                            bunifuFlatButton1.Visible = true;
                        }

                    }

                    break;


                case "Update":

                    if (textBox7.Visible == false)
                    {


                        if (textBoxQuizQuestion.Text == "" || textBox2.Text == "" || textBox11.Text == "" || textBoxQuizChoiceA.Text == "" ||
                                textBoxQuizChoiceB.Text == "" || textBoxQuizChoiceC.Text == "" || textBoxQuizChoiceD.Text == "" || RightAnswer == null || RightAnswer == "")
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {

                            int listPosition = int.Parse(MultipleChoiceLV.SelectedIndices[0].ToString());
                            ListViewItem exams = new ListViewItem();
                            exams.Text = textBoxQuizQuestion.Text;
                            exams.SubItems.Add(textBoxQuizChoiceA.Text);
                            exams.SubItems.Add(textBoxQuizChoiceB.Text);
                            exams.SubItems.Add(textBoxQuizChoiceC.Text);
                            exams.SubItems.Add(textBoxQuizChoiceD.Text);
                            RightAnswer = RightAnswer.TrimStart(',');
                            exams.SubItems.Add(RightAnswer);
                            //
                            exams.SubItems.Add(pictureBox3.ImageLocation);

                            if (textBox7.Visible == false)
                            {
                                if (bunifuDropdown2.selectedIndex == 0)//Minutes
                                {
                                    TimeF = textBox11.Text + "(Minutes)";
                                }

                                else
                                {
                                    TimeF = textBox11.Text + "(Seconds)";
                                }

                                exams.SubItems.Add(TimeF);


                            }



                            else
                            {
                                exams.SubItems.Add(textBox11.Text);

                            }
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

                            bunifuFlatButton1.Visible = true;
                        }//end else


                    }//end if


                    else
                    {
                        label20.Visible = false; //MC
                        bunifuDropdown2.Visible = false;
                        textBox11.Visible = false;



                        if (textBoxQuizQuestion.Text == "" || textBox2.Text == "" || textBoxQuizChoiceA.Text == "" ||
                               textBoxQuizChoiceB.Text == "" || textBoxQuizChoiceC.Text == "" || textBoxQuizChoiceD.Text == "" || RightAnswer == null)
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {

                            int listPosition = int.Parse(MultipleChoiceLV.SelectedIndices[0].ToString());
                            ListViewItem exams = new ListViewItem();
                            exams.Text = textBoxQuizQuestion.Text;
                            exams.SubItems.Add(textBoxQuizChoiceA.Text);
                            exams.SubItems.Add(textBoxQuizChoiceB.Text);
                            exams.SubItems.Add(textBoxQuizChoiceC.Text);
                            exams.SubItems.Add(textBoxQuizChoiceD.Text);
                            RightAnswer = RightAnswer.TrimStart(',');
                            exams.SubItems.Add(RightAnswer);
                            //
                            exams.SubItems.Add(pictureBox3.ImageLocation);

                            if (textBox7.Visible == false)
                            {
                                if (bunifuDropdown2.selectedIndex == 0)//Minutes
                                {
                                    TimeF = textBox11.Text + "(Minutes)";
                                }

                                else
                                {
                                    TimeF = textBox11.Text + "(Seconds)";
                                }

                                exams.SubItems.Add(TimeF);


                            }



                            else
                            {
                                if (bunifuDropdown2.selectedIndex == 0)//Minutes
                                {
                                    TimeF = textBox11.Text + "(Minutes)";
                                }

                                else
                                {
                                    TimeF = textBox11.Text + "(Seconds)";
                                }

                                exams.SubItems.Add(TimeF);


                                // exams.SubItems.Add(textBox11.Text);

                            }
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

                            bunifuFlatButton1.Visible = true;
                        }//end else



                    }

                    break;



            }
        }


             

        private void button2_Click(object sender, EventArgs e)//for true or false Next
        {
            string TimeF;
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

                            if (bunifuDropdown4.selectedIndex == 0)//Minutes
                            {
                                TimeF = textBox10.Text + "(Minutes)";
                            }

                            else
                            {
                                TimeF = textBox10.Text + "(Seconds)";
                            }

                            exams2.SubItems.Add(TimeF);//TimeLimit
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

                            bunifuFlatButton8.Visible = true;
                        }


                    } //If TB 7=False



                    //   if(textBox7.Visible == true) // TB 7=True
                    else { 

                        if (textBox13.Text == "" || textBox5.Text == "")
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {
                            string TimeF2;
                            ListViewItem exams2 = new ListViewItem();
                            exams2.Text = textBox13.Text;
                            exams2.SubItems.Add(bunifuDropdown5.selectedValue);
                            //
                            exams2.SubItems.Add(pictureBox5.ImageLocation);
                           // exams2.SubItems.Add(textBox10.Text);
                                                      

                            if (bunifuDropdown1.selectedIndex == 0)//Minutes
                            {
                                TimeF2 = textBox7.Text + "(Minutes)";
                            }

                            else
                            {
                                TimeF2 = textBox7.Text + "(Seconds)";
                            }

                            exams2.SubItems.Add(TimeF2);


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


                            bunifuFlatButton8.Visible = true;

                        }

                    }

                    break;


                case "Update":
                    if (textBox7.Visible == true)
                    {                                           
                    
                        label24.Visible = false; //TF
                        bunifuDropdown4.Visible = false;
                        textBox10.Visible = false;
                    }



                        int listPosition = int.Parse(TrueOrFalseLV.SelectedIndices[0].ToString());
                    ListViewItem exams1 = new ListViewItem();
                    exams1.Text = textBox13.Text;
                    exams1.SubItems.Add(bunifuDropdown5.selectedValue);
                    //
                    exams1.SubItems.Add(pictureBox5.ImageLocation);

                    if (textBox7.Visible == false)
                    {

                        if (bunifuDropdown4.selectedIndex == 0)//Minutes
                        {
                            TimeF = textBox10.Text + "(Minutes)";
                        }

                        else
                        {
                            TimeF = textBox10.Text + "(Seconds)";
                        }

                        exams1.SubItems.Add(TimeF);


                    }

                    else
                    {
                        if (bunifuDropdown4.selectedIndex == 0)//Minutes
                        {
                            TimeF = textBox10.Text + "(Minutes)";
                        }

                        else
                        {
                            TimeF = textBox10.Text + "(Seconds)";
                        }

                        exams1.SubItems.Add(TimeF);
                      //  exams1.SubItems.Add(textBox10.Text);
                    }


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


                    bunifuFlatButton8.Visible = true;

                    break;


            }


        }



        private void button1_Click(object sender, EventArgs e) //Short Answer
        {
            string TimeF;
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


                            if (bunifuDropdown3.selectedIndex == 0)//Minutes
                            {
                                TimeF = textBox12.Text + "(Minutes)";
                            }

                            else
                            {
                                TimeF = textBox12.Text + "(Seconds)";
                            }

                            exams2.SubItems.Add(TimeF);
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


                            bunifuFlatButton7.Visible = true;
                        }


                    } //If TB 7=False



                  //  if (textBox7.Visible == true) // TB 7=True
                  else
                    {

                        if (textBox9.Text == "" || textBox8.Text == "" || textBox3.Text == "")
                        {
                            Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                        }

                        else
                        {
                            string TimeF2;
                            ListViewItem exams2 = new ListViewItem();
                            exams2.Text = textBox9.Text;
                            exams2.SubItems.Add(textBox8.Text);
                            //
                            exams2.SubItems.Add(pictureBox4.ImageLocation);
                            //exams2.SubItems.Add(textBox12.Text);
                                                     

                            if (bunifuDropdown1.selectedIndex == 0)//Minutes
                            {
                                TimeF2 = textBox7.Text + "(Minutes)";
                            }

                            else
                            {
                                TimeF2 = textBox7.Text + "(Seconds)";
                            }

                            exams2.SubItems.Add(TimeF2);


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

                            bunifuFlatButton7.Visible = true;
                        }

                    }

                    break;


                case "Update":

                    if (textBox7.Visible == true)
                    {
                        label17.Visible = false; //SA
                        bunifuDropdown3.Visible = false;
                        textBox12.Visible = false;

                    }


                    int listPosition = int.Parse(ShortAnswerLV.SelectedIndices[0].ToString());
                    ListViewItem exams3 = new ListViewItem();
                    exams3.Text = textBox9.Text;
                    exams3.SubItems.Add(textBox8.Text);
                    //
                    exams3.SubItems.Add(pictureBox4.ImageLocation);

                    if (textBox7.Visible == false)
                    {

                        if (bunifuDropdown3.selectedIndex == 0)//Minutes
                        {
                            TimeF = textBox12.Text + "(Minutes)";
                        }

                        else
                        {
                            TimeF = textBox12.Text + "(Seconds)";
                        }


                        exams3.SubItems.Add(TimeF);


                    }



                    else
                    {

                        if (bunifuDropdown3.selectedIndex == 0)//Minutes
                        {
                            TimeF = textBox12.Text + "(Minutes)";
                        }

                        else
                        {
                            TimeF = textBox12.Text + "(Seconds)";
                        }


                        exams3.SubItems.Add(TimeF);


                        // exams3.SubItems.Add(textBox12.Text);
                    }
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

                    bunifuFlatButton7.Visible = true;

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
            /*  bunifuCheckbox2.Checked = false; bunifuCheckbox3.Checked = false; bunifuCheckbox4.Checked = false;
              RightAnswer = "A";  */
            if (bunifuCheckbox1.Checked == true)
            {

                RightAnswer = RightAnswer + ",A";
            }
            else
            {
                RightAnswer = RightAnswer.Replace(",A","");
            }

        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            /*  bunifuCheckbox1.Checked = false; bunifuCheckbox3.Checked = false; bunifuCheckbox4.Checked = false;
              RightAnswer = "B"; */
            if (bunifuCheckbox2.Checked == true)
            {
                RightAnswer = RightAnswer + ",B";
            }
            else
            {
                RightAnswer = RightAnswer.Replace(",B", "");
            }
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            /*  bunifuCheckbox1.Checked = false; bunifuCheckbox2.Checked = false; bunifuCheckbox4.Checked = false;
              RightAnswer = "C"; */
            if (bunifuCheckbox3.Checked == true)
            {
                RightAnswer = RightAnswer + ",C";
            }
            else
            {
                RightAnswer = RightAnswer.Replace(",C", "");
            }
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            /*  bunifuCheckbox1.Checked = false; bunifuCheckbox2.Checked = false; bunifuCheckbox3.Checked = false;
              RightAnswer = "D"; */
            if (bunifuCheckbox4.Checked == true)
            {
                RightAnswer = RightAnswer + ",D";
            }
            else
            {
                RightAnswer = RightAnswer.Replace(",D", "");
            }
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
            else if (button1.Text == "Update" || button2.Text == "Update" || buttonNextQuestion.Text == "Update")
            {

                Dialogue.Show("Update All Item First", "", "Ok", "Cancel");
            }

            else
            {
                DialogResult result = Dialogue1.Show("Saving This Quiz Means You are Done. Do you Wish to Continue?", "", "Ok", "Cancel");
                if (result == DialogResult.Yes)
                {
                    int item = totalitems();
                    string totalscore = item.ToString();

                    try
                    {

                       


                        con.Open();



                        if (textBox7.Visible == true)
                        {

                            string Time;

                            if (bunifuDropdown1.selectedIndex == 0)
                            {
                               
                                Time = textBox7.Text + "(Minutes)";

                            }

                            else
                            {
                                Time = textBox7.Text + "(Seconds)";
                            }



                            String query = "INSERT INTO quizzes (total_score,game_type,quiz_title,quiz_time_limit,facilitator_id,date_created) VALUES ('" + totalscore + "','Quiz Bee','" + textBoxQuizTitle.Text + "', '" + Time + "', '" + Program.user_id + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";//limit
                            SqlDataAdapter sda = new SqlDataAdapter(query, con);
                            sda.SelectCommand.ExecuteNonQuery();


                        }




                        else
                        {

                            String query = "INSERT INTO quizzes (total_score,game_type,quiz_title,facilitator_id,date_created) VALUES ('" + totalscore + "','Quiz Bee','" + textBoxQuizTitle.Text + "', '" + Program.user_id + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";//limit
                            SqlDataAdapter sda = new SqlDataAdapter(query, con);
                            sda.SelectCommand.ExecuteNonQuery();

                        }


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
                                  /*  if (exams.SubItems[6].Text != "")
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
                                    {  */
                                        con2.Open();

                                /*        if (textBox7.Visible == true)
                                        {

                                        string Time;

                                      if (bunifuDropdown1.selectedIndex == 0)
                                      {
                                            // Time = (Convert.ToInt32(textBox7.Text) * 60).ToString();
                                            Time = textBox7.Text + "(Minutes)";
                                            
                                        }

                                        else
                                        {
                                            Time = textBox7.Text + "(Seconds)";
                                        }


                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,answer_a,answer_b,answer_c,answer_d,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('Multiple Choice','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[5].Text + "','" + examID + "','" + exams.SubItems[8].Text + "','" + exams.SubItems[6].Text + "','" + Time + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                            sda.SelectCommand.ExecuteNonQuery();
                                            
                                        }


                                        else
                                        {   */


                                        String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,answer_a,answer_b,answer_c,answer_d,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('Multiple Choice','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[5].Text + "','" + examID + "','" + exams.SubItems[8].Text + "','" + exams.SubItems[6].Text + "','" + exams.SubItems[7].Text + "')";
                                        SqlDataAdapter sda = new SqlDataAdapter(query, con2);
                                        sda.SelectCommand.ExecuteNonQuery();




                                  //  }

                                                                            


                            

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
                                  /*  if (exams.SubItems[2].Text != "")
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
                                    { */
                                        con2.Open();

                                /*        if (textBox7.Visible == true)
                                        {

                                        string Time;

                                        if (bunifuDropdown1.selectedIndex == 0)
                                        {
                                            // Time = (Convert.ToInt32(textBox7.Text) * 60).ToString();
                                            Time = textBox7.Text + "(Minutes)";

                                        }

                                        else
                                        {
                                            Time = textBox7.Text + "(Seconds)";
                                        }



                                        String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('Short Answer','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[2].Text + "','" + Time + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.ExecuteNonQuery();
                                        }


                                        else
                                        { */

                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('Short Answer','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.ExecuteNonQuery();
                                     //   }
                               


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
                                 /*   if (exams.SubItems[2].Text != "")
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
                                    {  */
                                        con2.Open();


                                    /*    if (textBox7.Visible == true)
                                        {

                                        string Time;

                                        if (bunifuDropdown1.selectedIndex == 0)
                                        {
                                            // Time = (Convert.ToInt32(textBox7.Text) * 60).ToString();
                                            Time = textBox7.Text + "(Minutes)";

                                        }

                                        else
                                        {
                                            Time = textBox7.Text + "(Seconds)";
                                        }



                                        String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('True/False','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[2].Text + "','" + Time + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.ExecuteNonQuery();
                                        }



                                        else
                                        {  */
                                            String query = "INSERT INTO QuestionAnswers(item_format,game_type,question,correct_answer,quiz_id,points,image,QA_time_limit) VALUES ('True/False','Quiz Bee','" + exams.Text + "','" + exams.SubItems[1].Text + "','" + examID + "','" + exams.SubItems[4].Text + "','" + exams.SubItems[2].Text + "','" + exams.SubItems[3].Text + "')";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con2);

                                            sda.SelectCommand.ExecuteNonQuery();
                                     //   }
                               


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

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "";
            bunifuFlatButton1.Visible = true;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = "";
            bunifuFlatButton7.Visible = true;
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = "";
            bunifuFlatButton8.Visible = true;
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
