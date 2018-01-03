using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooLearnOfficial.User_Control
{
    public partial class CreateQuiz : UserControl
    {
        public CreateQuiz()
        {
            InitializeComponent();
        }


       

        private void ButtonPicturePuzzle_Click(object sender, EventArgs e)
        {
            QuizPicturePuzzle qpp = new QuizPicturePuzzle();
            qpp.Show();
        }

        private void CreateQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
