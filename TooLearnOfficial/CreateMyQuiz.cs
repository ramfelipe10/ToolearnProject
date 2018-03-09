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


       // private Form QuizBee;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        
             QuizBee qb = new QuizBee();
             qb.ShowDialog();
            


        }

       // private Form QuizPicturePuzzle;
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
       
           QuizPicturePuzzle qpp = new QuizPicturePuzzle();
            qpp.Show();


 

        }
    }
}
