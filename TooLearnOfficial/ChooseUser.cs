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
    
    public partial class ChooseUser : Form
    {

        public static string Role;
        public ChooseUser()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FacilitatorLogin fl = new FacilitatorLogin();
            fl.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //  this.Hide();

            //   ParticipantSQLConnect con = new ParticipantSQLConnect();
            //  con.Show();


            panel1.Visible = true;


          //  ParticipantLogin pl = new ParticipantLogin();
           // pl.Show();
        }

       

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Role = "Individual";

            this.Hide();

             ParticipantSQLConnect con = new ParticipantSQLConnect();
            con.Show();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {

            Role = "Group";

            this.Hide();

            ParticipantSQLConnect con = new ParticipantSQLConnect();
            con.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {



            Role = "Public";


            this.Hide();
            PublicJoin PJ = new PublicJoin();
            PJ.Show();
        }

        
    }
}
