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
    public partial class MainMenu2 : Form
    {

        bool closing = true;


        public MainMenu2()
        {
            InitializeComponent();
        }

        private void btnMnu_Click(object sender, EventArgs e)
        {
           /* if (sidemenu.Width == 260)
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

            } */
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

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateQuiz_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            //   this.Close();  error nag loloop ning splash kaya unhandled

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
            scoreParticipant1.Visible = false;
            classroomEnrolled1.Visible = false;
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            accountParticipant1.BringToFront();
            scoreParticipant1.Visible = false;
            classroomEnrolled1.Visible = false;


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            scoreParticipant1.BringToFront();
            scoreParticipant1.Visible = true;
          
        }

        private void buttonMyQuiz_Click(object sender, EventArgs e)
        {
            classroomEnrolled1.BringToFront();
            classroomEnrolled1.Visible = true;

        }

        private void buttonJoinGame_Click(object sender, EventArgs e)
        {
            joinGame1.BringToFront();
            scoreParticipant1.Visible = false;
            classroomEnrolled1.Visible = false;
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




    }
}
