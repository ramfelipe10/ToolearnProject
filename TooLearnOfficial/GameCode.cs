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
    public partial class GameCode : Form
    {
        public GameCode()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameCode_Load(object sender, EventArgs e)
        {

            char[] letters = "q1we2rty3uio4pas5dfgh6jklz7x8cv9bnm0".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 9; i++) //i < # depends how long the password
            {
                randomString += letters[r.Next(0, 34)].ToString();
            }

            code.Text=randomString;
            MessageBox.Show(randomString);
        }

     

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            LobbyFacilitator LF = new LobbyFacilitator();
            LF.Show();
        }
    }
}