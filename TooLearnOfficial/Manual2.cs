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
            panelAddParticipant.Visible = true;
        }    

        private void btnPrevious1_Click_1(object sender, EventArgs e)
        {
            panelAddParticipant.Visible = false;
        }
        private void btnNext1_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = true;
        }
        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            panelMyAccount.Visible = true;
        }

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            panelMyAccount.Visible = false;
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {

        }
    }
}
