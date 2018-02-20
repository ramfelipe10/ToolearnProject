using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TooLearnOfficial.User_Control
{
    public partial class MyAccount : UserControl
    {
        public MyAccount()
        {
            InitializeComponent();
           
        }

       


        private Form QuizBank;
        private Form MyClass;
        private Form CreateMyQuiz;
        private Form ScoreRecordFacilitator;
        private Form ClassGroup;
        private Form EditFacilitatorProfile;

        private void EditProfile_Click(object sender, EventArgs e)
        {
           // EditFacilitatorProfile EP = new EditFacilitatorProfile();
          //  EP.ShowDialog();


            if ((EditFacilitatorProfile == null) || (EditFacilitatorProfile.IsDisposed))
            {
                EditFacilitatorProfile = new EditFacilitatorProfile();
                
                EditFacilitatorProfile.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                EditFacilitatorProfile.BringToFront();
            }

        }


        private void myquiz_Click(object sender, EventArgs e)
        {
            //  QuizBank QB = new QuizBank();
            // QB.ShowDialog();

            if ((QuizBank == null) || (QuizBank.IsDisposed))
            {
                QuizBank = new QuizBank();
                //QuizBank.MdiParent = this;
                QuizBank.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                QuizBank.BringToFront();
            }

        }

        private void CreateQuiz_Click(object sender, EventArgs e)
        {
            //  CreateMyQuiz MQ = new CreateMyQuiz();
            // MQ.ShowDialog();

            if ((CreateMyQuiz == null) || (CreateMyQuiz.IsDisposed))
            {
                CreateMyQuiz = new CreateMyQuiz();                
                CreateMyQuiz.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                CreateMyQuiz.BringToFront();
            }



        }

        private void MyClassroom_Click(object sender, EventArgs e)
        {
           // MyClass C = new MyClass();
         //   C.ShowDialog();




            if ((MyClass == null) || (MyClass.IsDisposed))
            {
                MyClass = new MyClass();               
                MyClass.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                MyClass.BringToFront();
            }


        }

        private void ScoreRecord_Click(object sender, EventArgs e)
        {
         //   ScoreRecordFacilitator SRF = new ScoreRecordFacilitator();
         //   SRF.ShowDialog();




            if ((ScoreRecordFacilitator == null) || (ScoreRecordFacilitator.IsDisposed))
            {
                ScoreRecordFacilitator = new ScoreRecordFacilitator();                
                ScoreRecordFacilitator.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                ScoreRecordFacilitator.BringToFront();
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //ClassGroup CG = new ClassGroup();
            //CG.ShowDialog();



            if ((ClassGroup == null) || (ClassGroup.IsDisposed))
            {
                 ClassGroup = new ClassGroup();                
                ClassGroup.Show();
            }
            else
            {
                Dialogue.Show("One Instance of this Form is Allowed", "", "Ok", "Cancel");
                ClassGroup.BringToFront();
            }


        }
    }
}
