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
    public partial class MyQuiz : UserControl
    {
        public MyQuiz()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            LobbyFacilitator lf = new LobbyFacilitator();
            lf.Show();
        }
    }
}
