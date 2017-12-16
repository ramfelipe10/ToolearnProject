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
    public partial class QuizMultipleChoice : Form
    {
        String rightAnswer;
        public QuizMultipleChoice()
        {
            InitializeComponent();
        }

        private void resetAll()
        {
            textBoxQuizQuestion.Text = null;
            textBoxQuizChoiceA.Text = null; textBoxQuizChoiceB.Text = null; textBoxQuizChoiceC.Text = null; textBoxQuizChoiceD.Text = null;
            checkBoxQuizCheckA.Checked = false; checkBoxQuizCheckB.Checked = false; checkBoxQuizCheckC.Checked = false; checkBoxQuizCheckD.Checked = false;
        }
        private void enableFields()
        {
            textBoxQuizQuestion.Enabled = true;
            textBoxQuizChoiceA.Enabled = true; textBoxQuizChoiceB.Enabled = true; textBoxQuizChoiceC.Enabled = true; textBoxQuizChoiceD.Enabled = true;
            checkBoxQuizCheckA.Enabled = true; checkBoxQuizCheckB.Enabled = true; checkBoxQuizCheckC.Enabled = true; checkBoxQuizCheckD.Enabled = true;
            dataGridViewInformation.Enabled = true;
        }
        private void disableFields()
        {
            textBoxQuizQuestion.Enabled = false;
            textBoxQuizChoiceA.Enabled = false; textBoxQuizChoiceB.Enabled = false; textBoxQuizChoiceC.Enabled = false; textBoxQuizChoiceD.Enabled = false;
            checkBoxQuizCheckA.Enabled = false; checkBoxQuizCheckB.Enabled = false; checkBoxQuizCheckC.Enabled = false; checkBoxQuizCheckD.Enabled = false;
        }
        private void QuizMultipleChoice_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuizTimeLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuizQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxQuizCheckA_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxQuizCheckB.Checked = false; checkBoxQuizCheckC.Checked = false; checkBoxQuizCheckD.Checked = false;
            rightAnswer = "A";
        }

        private void checkBoxQuizCheckB_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxQuizCheckA.Checked = false; checkBoxQuizCheckC.Checked = false; checkBoxQuizCheckD.Checked = false;
            rightAnswer = "B";
        }

        private void checkBoxQuizCheckC_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxQuizCheckA.Checked = false; checkBoxQuizCheckB.Checked = false; checkBoxQuizCheckD.Checked = false;
            rightAnswer = "C";
        }

        private void checkBoxQuizCheckD_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxQuizCheckA.Checked = false; checkBoxQuizCheckB.Checked = false; checkBoxQuizCheckC.Checked = false;
            rightAnswer = "D";
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            buttonNextQuestion.Text = "Update";
            //ListViewItem exams = lvExamsInfo.SelectedItems[0];
            //textBoxQuizQuestion.Text = exams.Text;
            //textBoxQuizChoiceA.Text = exams.SubItems[1].Text;
            //textBoxQuizChoiceB.Text = exams.SubItems[2].Text;
            //textBoxQuizChoiceC.Text = exams.SubItems[3].Text;
            //textBoxQuizChoiceD.Text = exams.SubItems[4].Text;
            /* switch (exams.SubItems[5].Text)
            {
                case "A":
                    rightAnswer = "A";
                    checkBoxQuizCheckA.Checked = true;
                    checkBoxQuizCheckB.Checked = false; checkBoxQuizCheckC.Checked = false; checkBoxQuizCheckD.Checked = false;
                    break;
                case "B":
                    rightAnswer = "B";
                    checkBoxQuizCheckB.Checked = true;
                    checkBoxQuizCheckA.Checked = false; checkBoxQuizCheckC.Checked = false; checkBoxQuizCheckD.Checked = false;
                    break;
                case "C":
                    rightAnswer = "C";
                    checkBoxQuizCheckC.Checked = true;
                    checkBoxQuizCheckA.Checked = false; checkBoxQuizCheckB.Checked = false; checkBoxQuizCheckD.Checked = false;
                    break;
                case "D":
                    rightAnswer = "D";
                    checkBoxQuizCheckD.Checked = true;
                    checkBoxQuizCheckA.Checked = false; checkBoxQuizCheckB.Checked = false; checkBoxQuizCheckC.Checked = false;
                    break;
                default:
                    break;
            }
            */
        }
    }
}
