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
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void Manual_Load(object sender, EventArgs e)
        {

        }




        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelUserCreateLogin1.Visible = true;
        }

        private void btnPrevious1_Click(object sender, EventArgs e)
        {
            panelUserCreateLogin1.Visible = false;
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            panelMenuFacilitator2.Visible = true;
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            panelMenuFacilitator2.Visible = false;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            panelFacilitatorAccount.Visible = true;
        }

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            panelFacilitatorAccount.Visible = false;
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            panelFacilitatorClassroom.Visible = true;            
        }

        private void btnPrevious4_Click(object sender, EventArgs e)
        {
            panelFacilitatorClassroom.Visible = false;
        }       

        private void btnNext4_Click_1(object sender, EventArgs e)
        {
            panelCreateClassroom.Visible = true;
        }

        private void btnPrevious5_Click(object sender, EventArgs e)
        {
            panelCreateClassroom.Visible = false;
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            panelChooseQuiz.Visible = true;
        }

        private void btnPreviious6_Click(object sender, EventArgs e)
        {
            panelChooseQuiz.Visible = false;
        }

        private void btnNext6_Click(object sender, EventArgs e)
        {
            panelPicturePuzzle.Visible = true;
        }

        private void btnPrevious7_Click(object sender, EventArgs e)
        {
            panelPicturePuzzle.Visible = false;
        }

        private void btnNext7_Click(object sender, EventArgs e)
        {
            panelQuizBee.Visible = true;
        }

        private void btnPrevious8_Click(object sender, EventArgs e)
        {
            panelQuizBee.Visible = false;
        }

        private void btnNext8_Click(object sender, EventArgs e)
        {
            panelQuizBank.Visible = true;
        }

        private void btnPrevious9_Click(object sender, EventArgs e)
        {
            panelQuizBank.Visible = false;
        }

        private void btnNext9_Click(object sender, EventArgs e)
        {
            panelClassGroup.Visible = true;
        }

        private void btnPrevious10_Click(object sender, EventArgs e)
        {
            panelClassGroup.Visible = false;
        }

        private void btnNext10_Click(object sender, EventArgs e)
        {
            panelEditProfile.Visible = true;
        }

        private void btnPrevious11_Click(object sender, EventArgs e)
        {
            panelEditProfile.Visible = false;
        }

        private void btnNext11_Click(object sender, EventArgs e)
        {
            panelScoreRecord.Visible = true;
        }

        private void btnPrevious12_Click(object sender, EventArgs e)
        {
            panelScoreRecord.Visible = false;
        }

        private void btnNext12_Click(object sender, EventArgs e)
        {
            panelScoreRanks.Visible = true;
        }

        private void btnPrevious13_Click(object sender, EventArgs e)
        {
            panelScoreRanks.Visible = false;
        }

        private void btnNext13_Click(object sender, EventArgs e)
        {
            panelAddParticipant.Visible = true;
        }

        private void btnPrevious14_Click(object sender, EventArgs e)
        {
            panelAddParticipant.Visible = false;
        }
    }
}
