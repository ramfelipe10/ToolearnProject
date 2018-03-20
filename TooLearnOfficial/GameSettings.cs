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
       public static bool IsRandom;
       public static bool IsMusic;

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
                case "Merry Go":
                    Music = "Kevin MacLeodMerry Go.mp3";
                    break;

                case "Spinning Monkeys":
                    Music = "Kevin MacLeodMonkeys Spinning Monkeys.mp3";
                    break;

                case "Fluffing a Duck":
                    Music = "Kevin MacLeodFluffing a Duck.mp3";
                    break;

                case "Sneaky Snitch":
                    Music = "Kevin MacLeodSneaky Snitch.mp3";
                break;
                              
                                    


            }


            if (RandomBox.Checked == true)
            {

                IsRandom = true;
            }

            else
            {
                IsRandom = false;
            }

            if (MusicBox.Checked == true)
            {

                IsMusic = true;
            }

            else
            {
                IsMusic = false;
            }





            this.Hide();
            LobbyFacilitator LF = new LobbyFacilitator();
            LF.Show();
            
        }

        private void GameSettings_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectClassroom SC = new SelectClassroom();
            SC.Show();
        }
    }
}
