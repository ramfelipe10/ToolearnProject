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

        private void btnNext4_Click(object sender, EventArgs e)
        {

        }
    }
}
