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
    public partial class Manual2 : Form
    {
        public Manual2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelMode.Visible = true;
        }    

        private void btnPrevious1_Click_1(object sender, EventArgs e)
        {
            panelMode.Visible = false;
        }
        private void btnNext1_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = true;
        }
        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = false;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
        }

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = true;
        }

        private void btnPrevious4_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            panelMyAccount.Visible = true;
        }

        private void btnPrevious5_Click(object sender, EventArgs e)
        {
            panelMyAccount.Visible = false;
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            panelClassroomEnrolled.Visible = true;
        }

        private void btnPrevious6_Click(object sender, EventArgs e)
        {
            panelClassroomEnrolled.Visible = false;
        }

        private void btnNext6_Click(object sender, EventArgs e)
        {
            panelEditProfile.Visible = true;
        }

        private void btnPrevious7_Click(object sender, EventArgs e)
        {
            panelEditProfile.Visible = false;
        }

        private void btnNext7_Click(object sender, EventArgs e)
        {
            panelJoinQuiz.Visible = true;
        }

        private void btnPrevious8_Click(object sender, EventArgs e)
        {
            panelJoinQuiz.Visible = false;
        }

        private void panelNext8_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
