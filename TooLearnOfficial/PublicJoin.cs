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
    public partial class PublicJoin : Form
    {
        int Time = 2;
        public PublicJoin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseUser CU = new ChooseUser();
            CU.Show();
        }

        private void buttonEnterGame_Click(object sender, EventArgs e)
        {

            timer1.Start();
           

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            bunifuMetroTextbox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            bunifuImageButton6.Visible = false;
            label3.Visible = false;
            IPBox.Visible = false;
            label1.Visible = false;
            buttonEnterGame.Visible = false;
            IPBox.Text = "";
            Time--;
            if (Time == 0)
            {
                timer1.Stop();
                pictureBox1.Visible = false;                
                panel1.Visible = true;
                bunifuImageButton6.Visible = true;
                label3.Visible = true;
                IPBox.Visible = true;
                label1.Visible = true;
                buttonEnterGame.Visible = true;
                Time = 2;
            }

        }
    }
}
