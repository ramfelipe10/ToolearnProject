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
    public partial class MainMenu : Form
    {
        bool closing = true;

        public MainMenu()
        {
            InitializeComponent();
            
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }
           
                   
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close(); //for the form closing event
        }

            

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("hh:mm tt");
        }

       

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settings1.BringToFront();
            myAccount1.Visible = false;
            addPAccount1.Visible = false;

        }

       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            myAccount1.BringToFront();
            myAccount1.Visible = true;
            addPAccount1.Visible = false;

        }



        private void buttonLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = Dialogue1.Show("Are You Sure?", "", "Ok", "Cancel");
            if (result == DialogResult.Yes)
            {
                this.Hide();
                //   this.Close();  error nag loloop ning splash kaya unhandled

                ChooseUser cu = new ChooseUser();
                cu.Show();
            }
                   

            
            
            
        }


        private void buttonAboutSystem_Click(object sender, EventArgs e)
        {
            aboutSystem1.BringToFront();
            myAccount1.Visible = false;
            addPAccount1.Visible = false;
        }

             

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (closing)
            {
                DialogResult result = Dialogue1.Show("Are you sure you want to Exit?", "", "Ok", "Cancel");
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

       // private Form AddParticipantAccount;

        private void CreateParticipantA_Click(object sender, EventArgs e)
        {
            // AddParticipantAccount pa = new AddParticipantAccount();
            //  pa.ShowDialog();


            /*  if ((AddParticipantAccount == null) || (AddParticipantAccount.IsDisposed))
              {
                  AddParticipantAccount = new AddParticipantAccount();

                  AddParticipantAccount.Show();
              }
              else
              {
                  Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                  AddParticipantAccount.BringToFront();
              } */


            addPAccount1.BringToFront();
            myAccount1.Visible = false;
            addPAccount1.Visible = true;




        }
        private Form Manual;
        private void buttonManual_Click(object sender, EventArgs e)
        {
          //Manual m = new Manual();
         // m.ShowDialog();



            if ((Manual == null) || (Manual.IsDisposed))
            {
                Manual = new Manual();

                Manual.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                Manual.BringToFront();
            }


        }
    }
}
