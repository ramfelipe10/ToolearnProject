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
    public partial class EditPuzzle : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlConnection con2 = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlDataReader dr;
        int currentNumOfItems, numOfItems;
        string RightAnswer;
        string imageLocation;
        string title = QuizPicturePuzzle.SetValueForText2;
        string Picture;
        string time_limit;       
        int PictureWidth;
        int PictureHeight;
        public static int Total;
       




        List<Panel> listPanel = new List<Panel>();


        public EditPuzzle()
        {
            InitializeComponent();            
            load_picture();
            slice_image();          
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void load_total()
        {

            Total = MultipleChoiceLV.Items.Count + TrueOrFalseLV.Items.Count + ShortAnswerLV.Items.Count;

            if (Total == 9)
            {
                buttonNextQuestion.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }

            else
            {
                buttonNextQuestion.Visible = true;
                button1.Visible = true;
                button2.Visible = true;

            }

        }

        void load_picture()
        {
            string QID = QuizBank.SetValueForText1;

            SqlDataAdapter adapt = new SqlDataAdapter("select puzzle_image from quizzes where quiz_id= '" + QID + "'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            Picture = dt.Rows[0][0].ToString();          

            splitPicture.Image = Image.FromFile(Picture);

            PictureWidth = splitPicture.Image.Width;
            PictureHeight = splitPicture.Image.Height;


        }
        void slice_image()
        {
            string QID = QuizBank.SetValueForText1;

            SqlDataAdapter adapt = new SqlDataAdapter("select puzzle_image from quizzes where quiz_id= '" + QID + "'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
           Picture= dt.Rows[0][0].ToString();
         

           

            var imgarray = new Image[9];

            var img = Image.FromFile(Picture, true); //Use ImageLocation Of Recent Upload

            for (int x = 0; x < 3; x++) //Row
            {
                for (int y = 0; y < 3; y++) //Column
                {
                    var index = x * 3 + y;

                    QuizPicturePuzzle CC = (QuizPicturePuzzle)Application.OpenForms["QuizPicturePuzzle"];


                    imgarray[index] = new Bitmap(PictureWidth / 3, PictureHeight / 3);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 67, 44), new Rectangle(x * (PictureWidth / 3),
                                     y * (PictureHeight / 3),
                                     PictureWidth / 3,
                                    PictureHeight / 3), GraphicsUnit.Pixel);
                    graphics.Dispose();

                }
            }




            pictureBox6.Image = imgarray[0];
            pictureBox7.Image = imgarray[1];
            pictureBox8.Image = imgarray[2];
            pictureBox9.Image = imgarray[3];
            pictureBox10.Image = imgarray[4];
            pictureBox11.Image = imgarray[5];
            pictureBox12.Image = imgarray[6];
            pictureBox13.Image = imgarray[7];
            pictureBox14.Image = imgarray[8];

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


        private void clearAllMC()
        {

            resetAllMC();
            disable_fieldsMC();
            MultipleChoiceLV.Items.Clear();
            ShortAnswerLV.Items.Clear();
            TrueOrFalseLV.Items.Clear();
            MultipleChoiceLV.Enabled = false;
            ShortAnswerLV.Enabled = false;
            TrueOrFalseLV.Enabled = false;

        }

        private void enable_fieldsMC()
        {

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


        private string get(string answer)
        {
            string RA = answer;
            string value = "";

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
            buttonNextQuestion.Visible = true;


            buttonNextQuestion.Text = "Update";
            ListViewItem exams = MultipleChoiceLV.SelectedItems[0];
            textBoxQuizQuestion.Text = exams.Text;
            textBoxQuizChoiceA.Text = exams.SubItems[1].Text;
            textBoxQuizChoiceB.Text = exams.SubItems[2].Text;
            textBoxQuizChoiceC.Text = exams.SubItems[3].Text;
            textBoxQuizChoiceD.Text = exams.SubItems[4].Text;
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
                    bunifuDropdown3.selectedIndex = 0;
                }

                else
                {
                    bunifuDropdown3.selectedIndex = 1;
                }


          
            textBox2.Text = exams.SubItems[8].Text;




        }

        private void updateTF()
        {
            button2.Visible = true;

            button2.Text = "Update";
            ListViewItem exams = TrueOrFalseLV.SelectedItems[0];
            textBox13.Text = exams.Text;
            if (exams.SubItems[1].Text == "True")
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
                textBox10.Text = sub;



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
                    bunifuDropdown2.selectedIndex = 0;
                }

                else
                {
                    bunifuDropdown2.selectedIndex = 1;
                }


          
            textBox5.Text = exams.SubItems[4].Text;


        }

        private void EditPuzzle_Load(object sender, EventArgs e)
        {
                  
            
            currentNumOfItems = 1;
            numOfItems = 9;

            listPanel.Add(MultipleChoice);
            listPanel.Add(trueORfalse);
            listPanel.Add(shortAnswer);



            string C_ID = QuizBank.SetValueForText1;



            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM quizzes WHERE quiz_id = '" + C_ID + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                if (!dr.IsDBNull(4))
               
                {

                    label17.Visible = false;
                    bunifuDropdown1.Visible = false;
                    textBox12.Visible = false;


                    label24.Visible = false;
                    bunifuDropdown2.Visible = false;
                    textBox10.Visible = false;


                    label20.Visible = false;
                    bunifuDropdown3.Visible = false;
                    textBox11.Visible = false;

                }

                else//else-if
                {
                    label17.Visible = true;
                    bunifuDropdown1.Visible = true;
                    textBox12.Visible = true;


                    label24.Visible = true;
                    bunifuDropdown2.Visible = true;
                    textBox10.Visible = true;


                    label20.Visible = true;
                    bunifuDropdown3.Visible = true;
                    textBox11.Visible = true;
                }


                try
                {
                    con2.Open();
                    SqlCommand cd = new SqlCommand("SELECT * FROM QuestionAnswers WHERE quiz_id = '" + C_ID + "' ", con2);
                    SqlDataReader d = cd.ExecuteReader();
                    while (d.Read() == true)
                    {
                        if ((string)d[("item_format")] == "Multiple Choice")
                        {

                            ListViewItem exams = new ListViewItem();
                            exams.Text = (string)d[("question")];
                            exams.SubItems.Add((string)d[("answer_a")]);
                            exams.SubItems.Add((string)d[("answer_b")]);
                            exams.SubItems.Add((string)d[("answer_c")]);
                            exams.SubItems.Add((string)d[("answer_d")]);
                            exams.SubItems.Add((string)d[("correct_answer")]);
                            exams.SubItems.Add((string)d[("image")]);                            
                            exams.SubItems.Add((string)d[("QA_time_limit")]);
                            exams.SubItems.Add(Convert.ToString((int)d[("points")]));
                            exams.SubItems.Add(Convert.ToString((int)d[("answer_id")]));
                            MultipleChoiceLV.Items.Add(exams);


                        }//end MC

                        else if ((string)d[("item_format")] == "Short Answer")
                        {

                            ListViewItem exams = new ListViewItem();
                            exams.Text = (string)d[("question")];
                            exams.SubItems.Add((string)d[("correct_answer")]);
                            exams.SubItems.Add((string)d[("image")]);                           
                            exams.SubItems.Add((string)d[("QA_time_limit")]);
                            exams.SubItems.Add(Convert.ToString((int)d[("points")]));
                            exams.SubItems.Add(Convert.ToString((int)d[("answer_id")]));
                            ShortAnswerLV.Items.Add(exams);


                        }//end MC

                        else if ((string)d[("item_format")] == "True/False")
                        {

                            ListViewItem exams = new ListViewItem();
                            exams.Text = (string)d[("question")];
                            exams.SubItems.Add((string)d[("correct_answer")]);
                            exams.SubItems.Add((string)d[("image")]);                            
                            exams.SubItems.Add((string)d[("QA_time_limit")]);
                            exams.SubItems.Add(Convert.ToString((int)d[("points")]));
                            exams.SubItems.Add(Convert.ToString((int)d[("answer_id")]));
                            TrueOrFalseLV.Items.Add(exams);


                        }//end MC






                    }//End While
                }// End try


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

           
         


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MultipleChoice.BringToFront();
            bunifuFlatButton2.selected = true;
            MultipleChoiceLV.BringToFront();
            QuizFormat.Text = "Multiple Choice";
            NoItems.Text = MultipleChoiceLV.Items.Count.ToString();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            shortAnswer.BringToFront();
            ShortAnswerLV.BringToFront();
            QuizFormat.Text = "Short Answer";
            NoItems.Text = ShortAnswerLV.Items.Count.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            trueORfalse.BringToFront();
            TrueOrFalseLV.BringToFront();
            QuizFormat.Text = "True/False";
            NoItems.Text = TrueOrFalseLV.Items.Count.ToString();

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
                    bunifuFlatButton5.Visible = true;

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

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            string TimeF;        

               

                    if (textBox11.Visible == false)

                    {

                        if (textBoxQuizQuestion.Text == "" || textBox2.Text == "" || textBoxQuizChoiceA.Text == "" ||
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


                            if (textBox11.Visible == false)
                            {
                                if (bunifuDropdown3.selectedIndex == 0)//Minutes
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
                            exams.SubItems.Add(MultipleChoiceLV.Items[listPosition].SubItems[9].Text);
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

                            load_total();

                    bunifuFlatButton1.Visible = true;

                }

                    }
                    else
                    {   //else
                        if (textBoxQuizQuestion.Text == "" || textBox2.Text == "" || textBox11.Text == "" || textBoxQuizChoiceA.Text == "" ||
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


                            if (textBox11.Visible == true)
                            {
                                if (bunifuDropdown3.selectedIndex == 0)//Minutes
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
                            exams.SubItems.Add(MultipleChoiceLV.Items[listPosition].SubItems[9].Text);
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

                            load_total();

                    bunifuFlatButton1.Visible = true;


                }

                    }
                   


          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TimeF;           


                    if (textBox10.Visible == false)

                    {

                if (textBox13.Text == "" || textBox5.Text == "")
                {
                    Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                }

                else
                        {

                            int listPosition = int.Parse(TrueOrFalseLV.SelectedIndices[0].ToString());
                            ListViewItem exams1 = new ListViewItem();
                            exams1.Text = textBox13.Text;
                            exams1.SubItems.Add(bunifuDropdown5.selectedValue);
                            //
                            exams1.SubItems.Add(pictureBox5.ImageLocation);
                            if (textBox10.Visible == false)
                            {

                                if (bunifuDropdown2.selectedIndex == 0)//Minutes
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
                                exams1.SubItems.Add(textBox10.Text);
                            }

                            exams1.SubItems.Add(textBox5.Text);
                            exams1.SubItems.Add(TrueOrFalseLV.Items[listPosition].SubItems[5].Text);
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


                            load_total();
                    bunifuFlatButton8.Visible = true;

                }
                    }


                    else 
                    {


                if (textBox10.Text == "" || textBox13.Text == "" || textBox5.Text == "")
                {
                    Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                }

                else
                {

                    int listPosition = int.Parse(TrueOrFalseLV.SelectedIndices[0].ToString());
                    ListViewItem exams1 = new ListViewItem();
                    exams1.Text = textBox13.Text;
                    exams1.SubItems.Add(bunifuDropdown5.selectedValue);
                    //
                    exams1.SubItems.Add(pictureBox5.ImageLocation);
                    if (textBox10.Visible == true)
                    {

                        if (bunifuDropdown2.selectedIndex == 0)//Minutes
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
                        exams1.SubItems.Add(textBox10.Text);
                    }

                    exams1.SubItems.Add(textBox5.Text);
                    exams1.SubItems.Add(TrueOrFalseLV.Items[listPosition].SubItems[5].Text);
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


                    load_total();
                    bunifuFlatButton8.Visible = true;


                }
            }




        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {

                RightAnswer = RightAnswer + ",A";
            }
            else
            {
                RightAnswer = RightAnswer.Replace(",A", "");
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
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
            if (MultipleChoiceLV.Items.Count != 0 && MultipleChoiceLV.SelectedItems.Count != 0)

            {




                currentnumMC.Text = Convert.ToString(MultipleChoiceLV.SelectedItems[0].Index + 1);
                updateMC();


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

        private void TrueOrFalseLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrueOrFalseLV.Items.Count != 0 && TrueOrFalseLV.SelectedItems.Count != 0)

            {





                CurrentNumTF.Text = Convert.ToString(TrueOrFalseLV.SelectedItems[0].Index + 1);
                updateTF();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*  if (MultipleChoiceLV.Items.Count <= 0 && ShortAnswerLV.Items.Count <= 0 && TrueOrFalseLV.Items.Count <= 0)
              {
                  Dialogue.Show("Quiz is Empty", "", "Ok", "Cancel");
              }

              else if (currentNumOfItems < numOfItems)
              {
                  Dialogue.Show("Quiz is Incomplete, must be 9 Questions", "", "Ok", "Cancel");
              } */

            if (button1.Text == "Update" || button2.Text == "Update" || buttonNextQuestion.Text == "Update")
            {

                Dialogue.Show("Update All Item First", "", "Ok", "Cancel");
            }

            else
            {
                DialogResult result = Dialogue1.Show("Quiz will be Updated. Do you Wish to Continue?", "", "Ok", "Cancel");
                if (result == DialogResult.Yes)
                {
                    int item = totalitems();
                    string totalscore = item.ToString();


                   try
                  {


                   



                        con.Close();// close muna

                        int examID = Convert.ToInt32(QuizBank.SetValueForText1);// ID OF QUIZ


                        con.Open();
                        String set = "UPDATE quizzes SET total_score='" + totalscore + "' WHERE quiz_id='" + examID + "' ";
                        SqlDataAdapter sd = new SqlDataAdapter(set, con);
                        sd.SelectCommand.ExecuteNonQuery();
                        con.Close();


                        SqlDataAdapter cmd = new SqlDataAdapter("select quiz_time_limit from quizzes where quiz_id = '" + examID + "' AND facilitator_id = '" + Program.user_id + "' ", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        string Time = dt.Rows[0][0].ToString();

                        string Time_limit_status;

                        if (Time == null || Time == "")
                        {
                            Time_limit_status = "Null";
                        }
                        else
                        {
                            Time_limit_status = "Active";
                        }




                        for (int i = 0; i < MultipleChoiceLV.Items.Count; i++) // For Multiple Choice
                        {
                            ListViewItem exams = MultipleChoiceLV.Items[i];
                            try
                            {

                                

                                if (Time_limit_status == "Null")
                                {





                                    con.Open();
                                    String query = "UPDATE QuestionAnswers SET item_format='Multiple Choice' ,game_type='Picture Puzzle',question='" + exams.Text + "',answer_a='" + exams.SubItems[1].Text + "',answer_b='" + exams.SubItems[2].Text + "',answer_c='" + exams.SubItems[3].Text + "',answer_d='" + exams.SubItems[4].Text + "',correct_answer='" + exams.SubItems[5].Text + "',quiz_id='" + examID + "',points='" + exams.SubItems[8].Text + "',image='" + exams.SubItems[6].Text + "',QA_time_limit='" + exams.SubItems[7].Text + "' WHERE answer_id='" + exams.SubItems[9].Text + "' ";
                                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();

                                }

                                else
                                {

                                    con.Open();
                                    String query = "UPDATE QuestionAnswers SET item_format='Multiple Choice' ,game_type='Picture Puzzle',question='" + exams.Text + "',answer_a='" + exams.SubItems[1].Text + "',answer_b='" + exams.SubItems[2].Text + "',answer_c='" + exams.SubItems[3].Text + "',answer_d='" + exams.SubItems[4].Text + "',correct_answer='" + exams.SubItems[5].Text + "',quiz_id='" + examID + "',points='" + exams.SubItems[8].Text + "',image='" + exams.SubItems[6].Text + "',QA_time_limit='" + Time + "' WHERE answer_id='" + exams.SubItems[9].Text + "' ";
                                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();


                                }




                            }

                            catch (Exception ex)
                            {
                                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");

                            }
                            

                        }





                        // // // // // // // // 

                        for (int i = 0; i < ShortAnswerLV.Items.Count; i++) //For Short Answers
                        {
                            ListViewItem exams = ShortAnswerLV.Items[i];
                            try
                            {

                              

                                if (Time_limit_status == "Null")
                                {




                                    con.Open();
                                    String query = "UPDATE QuestionAnswers SET item_format='Short Answer' ,game_type='Picture Puzzle',question='" + exams.Text + "',correct_answer='" + exams.SubItems[1].Text + "',quiz_id='" + examID + "',points='" + exams.SubItems[4].Text + "',image='" + exams.SubItems[2].Text + "',QA_time_limit='" + exams.SubItems[3].Text + "' WHERE answer_id='" + exams.SubItems[5].Text + "' ";
                                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();
                                }



                                else
                                {

                                    con.Open();
                                    String query = "UPDATE QuestionAnswers SET item_format='Short Answer' ,game_type='Picture Puzzle',question='" + exams.Text + "',correct_answer='" + exams.SubItems[1].Text + "',quiz_id='" + examID + "',points='" + exams.SubItems[4].Text + "',image='" + exams.SubItems[2].Text + "',QA_time_limit='" + Time + "' WHERE answer_id='" + exams.SubItems[5].Text + "' ";
                                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();

                                }


                            }

                            catch (Exception ex)
                            {
                                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");

                            }
                         

                        }


                        // /// // // // // // // 







                        // // // / // // / // / // 



                        for (int i = 0; i < TrueOrFalseLV.Items.Count; i++) //For True Or False
                        {
                            ListViewItem exams = TrueOrFalseLV.Items[i];
                            try
                            {

                             


                                if (Time_limit_status == "Null")
                                {





                                    con.Open();

                                    String query = "UPDATE QuestionAnswers SET item_format='True/False' ,game_type='Picture Puzzle',question='" + exams.Text + "',correct_answer='" + exams.SubItems[1].Text + "',quiz_id='" + examID + "',points='" + exams.SubItems[4].Text + "',image='" + exams.SubItems[2].Text + "',QA_time_limit='" + exams.SubItems[3].Text + "' WHERE answer_id='" + exams.SubItems[5].Text + "' ";
                                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();

                                }


                                else
                                {

                                    con.Open();

                                    String query = "UPDATE QuestionAnswers SET item_format='True/False' ,game_type='Picture Puzzle',question='" + exams.Text + "',correct_answer='" + exams.SubItems[1].Text + "',quiz_id='" + examID + "',points='" + exams.SubItems[4].Text + "',image='" + exams.SubItems[2].Text + "',QA_time_limit='" + Time + "' WHERE answer_id='" + exams.SubItems[5].Text + "' ";
                                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();


                                }


                            }
                            catch (Exception ex)
                            {
                                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");

                            }
                            

                        }



                        // / // // / /// / // / // / // / / / / //

                   }





                    catch (Exception ex)
                    {
                        Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");

                    } 



                    Dialogue.Show("Successfully Updated", "", "Ok", "Cancel");
                    this.Hide();

                }

            }

        }

        

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string TimeF;



            if (textBox12.Visible == false)

            {

                if (textBox9.Text == "" || textBox8.Text == "" || textBox3.Text == "")
                {
                    Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                }
                else
                {

                    int listPosition = int.Parse(ShortAnswerLV.SelectedIndices[0].ToString());
                    ListViewItem exams3 = new ListViewItem();
                    exams3.Text = textBox9.Text;
                    exams3.SubItems.Add(textBox8.Text);
                    //
                    exams3.SubItems.Add(pictureBox4.ImageLocation);


                    if (bunifuDropdown1.selectedIndex == 0)//Minutes
                    {
                        TimeF = textBox12.Text + "(Minutes)";
                    }

                    else
                    {
                        TimeF = textBox12.Text + "(Seconds)";
                    }


                    exams3.SubItems.Add(TimeF);



                    exams3.SubItems.Add(textBox3.Text);
                    exams3.SubItems.Add(ShortAnswerLV.Items[listPosition].SubItems[5].Text);
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

                    load_total();
                    bunifuFlatButton7.Visible = true;

                }
            }

            else
            {

                if (textBox9.Text == "" || textBox8.Text == "" || textBox3.Text == "" || textBox12.Text == "")
                {
                    Dialogue.Show("Please Fill out Blank Fields", "", "Ok", "Cancel");
                }

                else
                {

                    int listPosition = int.Parse(ShortAnswerLV.SelectedIndices[0].ToString());
                    ListViewItem exams3 = new ListViewItem();
                    exams3.Text = textBox9.Text;
                    exams3.SubItems.Add(textBox8.Text);
                    //
                    exams3.SubItems.Add(pictureBox4.ImageLocation);


                    if (bunifuDropdown1.selectedIndex == 0)//Minutes
                    {
                        TimeF = textBox12.Text + "(Minutes)";
                    }

                    else
                    {
                        TimeF = textBox12.Text + "(Seconds)";
                    }


                    exams3.SubItems.Add(TimeF);



                    exams3.SubItems.Add(textBox3.Text);
                    exams3.SubItems.Add(ShortAnswerLV.Items[listPosition].SubItems[5].Text);
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

                    load_total();
                    bunifuFlatButton7.Visible = true;

                }


            }




        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "";
            bunifuFlatButton1.Visible = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = "";
            bunifuFlatButton8.Visible = true;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = "";
            bunifuFlatButton7.Visible = true;
        }

        private void updateSA()
        {

            button1.Visible = true;

            button1.Text = "Update";
            ListViewItem exams = ShortAnswerLV.SelectedItems[0];
            textBox9.Text = exams.Text;
            textBox8.Text = exams.SubItems[1].Text;
            pictureBox4.ImageLocation = exams.SubItems[2].Text;
            if (pictureBox4.ImageLocation == "")
            {
                bunifuFlatButton7.Visible = true;
            }

            else
            {
                bunifuFlatButton7.Visible = false;
            }

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
                    bunifuDropdown1.selectedIndex = 0;
                }

                else
                {
                    bunifuDropdown1.selectedIndex = 1;
                }

          
            textBox3.Text = exams.SubItems[4].Text;

        }








        }
    }
