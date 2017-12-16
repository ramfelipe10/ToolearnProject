﻿using System;
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

        private void ButtonMultipleChoice_Click(object sender, EventArgs e)
        {
            QuizMultipleChoice qmc = new QuizMultipleChoice();
            qmc.Show();
        }

        private void ButtonTrueOrFalse_Click(object sender, EventArgs e)
        {
            QuizTrueOrFalse qtor = new QuizTrueOrFalse();
            qtor.Show();
        }

        private void ButtonPicturePuzzle_Click(object sender, EventArgs e)
        {
            QuizPicturePuzzle qpp = new QuizPicturePuzzle();
            qpp.Show();
        }
    }
}
