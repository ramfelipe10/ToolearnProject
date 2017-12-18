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
            Application.Exit();
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
    }
}
