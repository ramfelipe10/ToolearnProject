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

namespace TooLearnOfficial.User_Control_Participant
{
    public partial class AccountParticipant : UserControl
    {
        public AccountParticipant()
        {
            InitializeComponent();
           
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            EditParticipantProfile EP = new EditParticipantProfile();
            EP.ShowDialog();
        }

        private void MyClassroom_Click(object sender, EventArgs e)
        {
            MyClassParticipant MP = new MyClassParticipant();
            MP.ShowDialog();
        }
    }
}
