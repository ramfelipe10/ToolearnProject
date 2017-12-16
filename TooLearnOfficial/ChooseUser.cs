﻿using System;
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
    public partial class ChooseUser : Form
    {
        public ChooseUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FacilitatorLogin fl = new FacilitatorLogin();
            fl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            ParticipantLogin pl = new ParticipantLogin();
            pl.Show();
        }
    }
}
