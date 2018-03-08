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
    public partial class ScoreRecordFacilitator : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        

        public static string PN; 

        public ScoreRecordFacilitator()
        {
            InitializeComponent();

            this.score1.StatusUpdated += new EventHandler(MyEventHandlerFunction_StatusUpdated);

        }



        public void MyEventHandlerFunction_StatusUpdated(object sender, EventArgs e)
        {
            PN = score1.Data.ToString();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

           
            

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScoreRecordFacilitator_Load(object sender, EventArgs e)
        {
      

        }

     
    }
}
