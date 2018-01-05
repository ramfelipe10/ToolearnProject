using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooLearnOfficial
{
    public partial class QuizBee : Form
    {


        List<Panel> listPanel = new List<Panel>();


        public QuizBee()
        {
            InitializeComponent();
        }

        private void enable_fields() {

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
            enable_fields();


            
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)//for multiple choice next
        {

            //Lisview
            ListViewItem exams = new ListViewItem();
            exams.Text = textBoxQuizQuestion.Text;
            exams.SubItems.Add(textBoxQuizChoiceA.Text);
            exams.SubItems.Add(textBoxQuizChoiceB.Text);
            exams.SubItems.Add(textBoxQuizChoiceC.Text);
            exams.SubItems.Add(textBoxQuizChoiceD.Text);
            exams.SubItems.Add(textBoxQuizChoiceC.Text);
            MultipleChoiceLV.Items.Add(exams);


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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
