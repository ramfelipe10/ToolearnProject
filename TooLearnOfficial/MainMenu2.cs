using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TooLearnOfficial
{
    public partial class MainMenu2 : Form
    {

        bool closing = true;
        

        public MainMenu2()
        {
            InitializeComponent();
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timeOras.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
           this.Close(); // for form closing event
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void buttonLogout_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                
                ChooseUser cu = new ChooseUser();
                cu.Show();
           

        }

        private void MainMenu2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void buttonAboutSystem_Click(object sender, EventArgs e)
        {
            aboutSystem1.BringToFront();
            aboutSystem1.Visible=true;
            accountParticipant1.Visible = false;
            joinQuiz1.Visible = false;
            settings1.Visible = false;



        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            accountParticipant1.BringToFront();
            accountParticipant1.Visible = true;
            joinQuiz1.Visible = false;
            aboutSystem1.Visible = false;
            settings1.Visible = false;


        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settings1.BringToFront();
            settings1.Visible = true;
            aboutSystem1.Visible = false;
            accountParticipant1.Visible = false;
            joinQuiz1.Visible = false;

        }



        private void buttonJoinGame_Click(object sender, EventArgs e)
        {
            joinQuiz1.BringToFront();
            joinQuiz1.Visible = true;
            aboutSystem1.Visible = false;
            accountParticipant1.Visible = false;
            settings1.Visible = false;
        }

        private void MainMenu2_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (closing)
            {
                DialogResult result = Dialogue1.Show("Are you sure you want to Exit?", "", "Ok", "Cancel");
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
