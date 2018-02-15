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

    public partial class GameSettings : Form
    {
       public static string Music;
       public static string IsRandom;
       public static string IsMusic;

        public GameSettings()
        {
            InitializeComponent();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            switch (bunifuDropdown1.selectedValue)
            {

                case "Wheel of Fortune":
                    Music = "Wheel of Fortune Theme Song.mp3";
                break;


                case "The Price Is Right":
                    Music = "The Price Is Right theme song.mp3";
                    break;


                case "Family Feud":
                    Music = "Family Feud Theme Song.mp3";
                    break;


                default:

                    break;


            }


            if (RandomBox.Checked == true)
            {

                IsRandom = "true";
            }

            else
            {
                IsRandom = "false";
            }

            if (MusicBox.Checked == true)
            {

                IsMusic = "true";
            }

            else
            {
                IsMusic = "false";
            }





            this.Hide();
            LobbyFacilitator LF = new LobbyFacilitator();
            LF.ShowDialog();
        }
    }
}
