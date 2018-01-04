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
    public partial class QuizBee : Form
    {


        List<Panel> listPanel = new List<Panel>();


        public QuizBee()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuizBee_Load(object sender, EventArgs e)
        {

            listPanel.Add(MultipleChoice);
            listPanel.Add(trueORfalse);
            listPanel.Add(shortAnswer);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MultipleChoice.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            trueORfalse.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            shortAnswer.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            String imageLocation = null;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";
                dialog.Filter = "jpg files(*.jpg)|*.jpg"; //ifilter lng ang jpg formats
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox3.ImageLocation = imageLocation;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }





    }
}
