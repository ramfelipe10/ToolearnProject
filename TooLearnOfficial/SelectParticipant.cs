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
    public partial class SelectParticipant : Form
    {

        public static string participant;

        public SelectParticipant()
        {
            InitializeComponent();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            participant = "PUBLIC";
            //  LobbyFacilitator LF = new LobbyFacilitator();
            //  LF.Show();
            //  LF.BringToFront();

            GameSettings GS = new GameSettings();
            GS.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            participant = "IP";
            SelectClassroom SC = new SelectClassroom();
            SC.Show();
            SC.BringToFront();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            participant = "GP";
            SelectClassroom SC = new SelectClassroom();
            SC.Show();
            SC.BringToFront();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
