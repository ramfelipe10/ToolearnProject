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
    public partial class QuizPicturePuzzle : Form
    {


        string imagesrc;

        public QuizPicturePuzzle()
        {
            InitializeComponent();
        }

     
        private void splitPicture_Click(object sender, EventArgs e) //iclick ang picturebox para magbrowse kang mga image tapos ma automatic ma split
        {
         var imgarray = new Image[9];
           // var img = Image.FromFile(@"C:\Users\BOC\Documents\GitHub\ToolearnProject\TooLearnOfficial\TooLearn Pictures\After-Effects-and-Cinema-4D-Flat-Design-Animation-Tutorial.jpg", true); //change code to query image into database
            var img = Image.FromFile(imagesrc, true); //Use ImageLocation Of Recent Upload

            for (int i = 0; i < 3; i++)
               {
                   for (int j = 0; j < 3; j++)
                   {
                       var index = i * 3 + j;
                       imgarray[index] = new Bitmap(104, 104);
                       var graphics = Graphics.FromImage(imgarray[index]);
                       graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(i * 150, j * 150, 150, 150), GraphicsUnit.Pixel);
                       graphics.Dispose();





                   }
               }


                        splitPicture1.Image = imgarray[0];
                        splitPicture2.Image = imgarray[1];
                        splitPicture3.Image = imgarray[2];
                        splitPicture4.Image = imgarray[3];
                        splitPicture5.Image = imgarray[4];
                        splitPicture6.Image = imgarray[5];
                        splitPicture7.Image = imgarray[6];
                        splitPicture8.Image = imgarray[7];
                        splitPicture9.Image = imgarray[8]; 

                        splitPicture1.SizeMode = PictureBoxSizeMode.Normal;
                        splitPicture2.SizeMode = PictureBoxSizeMode.Normal;
                        splitPicture3.SizeMode = PictureBoxSizeMode.Normal;
                        splitPicture4.SizeMode = PictureBoxSizeMode.Normal;
                        splitPicture5.SizeMode = PictureBoxSizeMode.Normal;
                        splitPicture6.SizeMode = PictureBoxSizeMode.Normal;
                        splitPicture7.SizeMode = PictureBoxSizeMode.Normal;
                        splitPicture8.SizeMode = PictureBoxSizeMode.Normal;
                        splitPicture9.SizeMode = PictureBoxSizeMode.Normal; 



        }

        private void button1_Click(object sender, EventArgs e) //ma upload ning image para maglaog sa database.
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";
                dialog.Filter = "jpg files(*.jpg)|*.jpg"; //ifilter lng ang jpg formats
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    splitPicture.ImageLocation = imageLocation;
                    splitPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    imagesrc = imageLocation;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitPicture1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
