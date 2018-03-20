using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TooLearnOfficial
{
    public partial class ScoreRecordParticipant : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public static string PN;
        public static string CR;

        public ScoreRecordParticipant()
        {
            InitializeComponent();
            this.score21.StatusUpdated += new EventHandler(MyEventHandlerFunction_StatusUpdated);
        }

        public void MyEventHandlerFunction_StatusUpdated(object sender, EventArgs e)
        {
            PN = score21.Data.ToString();
            CR = score21.Data1.ToString();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
