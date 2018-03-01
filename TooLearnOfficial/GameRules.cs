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
    public partial class GameRules : Form
    {
        string GameType = LobbyParticipant.GameType;
        public GameRules()
        {
            InitializeComponent();
            
        }

        private void GameRules_Load(object sender, EventArgs e)
        {
            
            if(GameType=="QB")
            {
                bunifuCustomLabel3.Text = "Quiz Bee";
                bunifuCustomLabel2.Text= System.IO.File.ReadAllText(@"QuizBeeRules.txt");

            }

            else if(GameType == "PZ")
            {
                bunifuCustomLabel3.Text = "Picture Puzzle";
                bunifuCustomLabel2.Text = System.IO.File.ReadAllText(@"PicturePuzzleRules.txt");
            }
        }
    }
}
