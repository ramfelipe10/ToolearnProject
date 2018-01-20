﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TooLearnOfficial.User_Control
{
    public partial class MyAccount : UserControl
    {
        public MyAccount()
        {
            InitializeComponent();
           
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            EditFacilitatorProfile EP = new EditFacilitatorProfile();
            EP.Show();
        }

        private void myquiz_Click(object sender, EventArgs e)
        {
            QuizBank QB = new QuizBank();
            QB.Show();
        }

        private void CreateQuiz_Click(object sender, EventArgs e)
        {
            CreateMyQuiz MQ = new CreateMyQuiz();
            MQ.Show();
        }

        private void MyClassroom_Click(object sender, EventArgs e)
        {
            MyClass C = new MyClass();
            C.Show();
        }

        private void ScoreRecord_Click(object sender, EventArgs e)
        {

        }
    }
}
