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
    public partial class CreateMyQuiz : Form
    {
        public CreateMyQuiz()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Form QuizBee;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // QuizBee qb = new QuizBee();
            // qb.ShowDialog();
            

              if ((QuizBee == null) || (QuizBee.IsDisposed))
            {
                QuizBee = new QuizBee();

                QuizBee.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                QuizBee.BringToFront();
            }

        }

        private Form QuizPicturePuzzle;
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  QuizPicturePuzzle qpp = new QuizPicturePuzzle();
          //  qpp.ShowDialog();


            if ((QuizPicturePuzzle == null) || (QuizPicturePuzzle.IsDisposed))
            {
                QuizPicturePuzzle = new QuizPicturePuzzle();

                QuizPicturePuzzle.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                QuizPicturePuzzle.BringToFront();
            }

        }
    }
}
