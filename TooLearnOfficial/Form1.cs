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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void progressBar1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();

                this.Hide();

                ChooseUser cu = new ChooseUser();
                cu.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
