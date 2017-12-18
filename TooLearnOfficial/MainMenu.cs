﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooLearnOfficial //commenting for git
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnMnu_Click(object sender, EventArgs e)
        {
            if(sidemenu.Width == 260)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 50;
                PanelTransition.ShowSync(sidemenu);
                LogoTransition.ShowSync(logos);

                LogosTransition.HideSync(logo);
                
            }
            else
            {
                LogoTransition.Hide(logos);

                
                LogoTransition.ShowSync(logo);

                sidemenu.Visible = false;
                sidemenu.Width = 260;
                PanelTransition.ShowSync(sidemenu);

            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            ChooseUser cu = new ChooseUser();
            cu.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateQuiz_Click(object sender, EventArgs e)
        {
            createQuiz1.BringToFront();

        }

        private void buttonMyQuiz_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timeOras.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settings1.BringToFront();
        }

        
    }
}
