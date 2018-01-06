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
    public partial class MainMenu : Form
    {
        bool closing = true;

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
          /*  if(sidemenu.Width == 260)
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
         //   this.Close();  error nag loloop ning splash kaya unhandled

            ChooseUser cu = new ChooseUser();
            cu.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close(); //for the form closing event
        }

        private void buttonCreateQuiz_Click(object sender, EventArgs e)
        {
            createQuiz1.BringToFront();
            myQuiz1.Visible = false;
            classroomHandle1.Visible = false;
            createClassroom1.Visible = false;

        }

        private void buttonMyQuiz_Click(object sender, EventArgs e)
        {
            myQuiz1.Visible = true;
            classroomHandle1.Visible = false;
            myQuiz1.BringToFront();
            createClassroom1.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settings1.BringToFront();
            myQuiz1.Visible = false;
            classroomHandle1.Visible = false;
            createClassroom1.Visible = false;
        }

        private void buttonCreateClassroom_Click(object sender, EventArgs e)
        {
            createClassroom1.BringToFront();
            myQuiz1.Visible = false;
            classroomHandle1.Visible = false;
            createClassroom1.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            myAccount1.BringToFront();
            myQuiz1.Visible = false;
            classroomHandle1.Visible = false;
            createClassroom1.Visible = false;
        }

        private void buttonSubjectHandle_Click(object sender, EventArgs e)
        {
            classroomHandle1.Visible = true;
            myQuiz1.Visible = false;
            classroomHandle1.BringToFront();
            createClassroom1.Visible = false;
        }

        private void buttonAboutSystem_Click(object sender, EventArgs e)
        {
            aboutSystem1.BringToFront();
            myQuiz1.Visible = false;
            classroomHandle1.Visible = false;
            createClassroom1.Visible = false;
        }

        private void myQuiz1_Load(object sender, EventArgs e)
        {

        }

        private void createClassroom1_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
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
