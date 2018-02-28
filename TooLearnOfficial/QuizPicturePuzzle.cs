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

        public static string SetValueForText2 = "", SetValueForText3 = "", time = "";
        public static int SetWidth, SetHeight;
     
       

        public QuizPicturePuzzle()
        {
            InitializeComponent();
        }

     
        private void splitPicture_Click(object sender, EventArgs e) //iclick ang picturebox para magbrowse kang mga image tapos ma automatic ma split
        {

            if (splitPicture.ImageLocation != null)
            {

               var imgarray = new Image[9];
                // var img = Image.FromFile(@"C:\Users\BOC\Documents\GitHub\ToolearnProject\TooLearnOfficial\TooLearn Pictures\After-Effects-and-Cinema-4D-Flat-Design-Animation-Tutorial.jpg", true); //change code to query image into database
                var img = Image.FromFile(imagesrc, true); //Use ImageLocation Of Recent Upload

                for (int x = 0; x < 3; x++) //Row
                {
                    for (int y = 0; y < 3; y++) //Column
                    {
                        var index = x * 3 + y;
                        imgarray[index] = new Bitmap(splitPicture.Image.Width / 3, splitPicture.Image.Height / 3);
                        var graphics = Graphics.FromImage(imgarray[index]);
                        graphics.DrawImage(img, new Rectangle(0, 0, 99, 81), new Rectangle(x * (splitPicture.Image.Width / 3),
                                         y * (splitPicture.Image.Height / 3),
                                         splitPicture.Image.Width / 3,
                                        splitPicture.Image.Height / 3), GraphicsUnit.Pixel);
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


                

               

            }


            else
            {
                Dialogue.Show("Please Upload Image!", "", "Ok", "Cancel");
            }

            


        }   

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    splitPicture.ImageLocation = imageLocation;
                    splitPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagesrc = imageLocation;
                    bunifuCustomLabel3.Visible = true;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void QuizPicturePuzzle_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

           
                       
            splitPicture.ImageLocation = null;
            bunifuCustomLabel3.Visible = false;



            splitPicture1.Image = null;
            splitPicture2.Image = null;
            splitPicture3.Image = null;
            splitPicture4.Image = null;
            splitPicture5.Image = null;
            splitPicture6.Image = null;
            splitPicture7.Image = null;
            splitPicture8.Image = null;
            splitPicture9.Image = null;

        }

        private void textBoxQuizTimeLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
           
                  
            if (splitPicture.ImageLocation == null || textBoxQuizTitle.Text=="" || string.IsNullOrWhiteSpace(textBoxQuizTitle.Text) && textBoxQuizTitle.Text.Length > 0)
            {
                Dialogue.Show("Please Fill All Fields", "", "Ok", "Cancel");

            }


            else
            {
                SetValueForText3 = splitPicture.ImageLocation;
                SetValueForText2 = textBoxQuizTitle.Text;
                if (textBoxQuizTimeLimit.Text != "" || textBoxQuizTimeLimit.Text != null)
                {
                    if (bunifuDropdown1.selectedIndex == 0)//Minutes
                    {
                        time = textBoxQuizTimeLimit.Text + "(Minutes)";
                    }

                    else
                    {
                        time = textBoxQuizTimeLimit.Text + "(Seconds)";
                    }
                }
                else
                {
                    time = textBoxQuizTimeLimit.Text;
                }

                SetWidth =splitPicture.Image.Width;
                SetHeight=splitPicture.Image.Height;

              
                this.Hide();
                PicturePuzzle pz = new PicturePuzzle();
                pz.Show();
            }
          

        }

       
       
    }
}
