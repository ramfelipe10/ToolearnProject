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
    public partial class SecondSecurityINDI : Form
    {
        SqlConnection con = new SqlConnection("Data Source='" + Program.source + "' ; Initial Catalog='" + Program.db + "'; User ID='" + Program.id + "';Password='" + Program.password + "'");
        public SecondSecurityINDI()
        {
            InitializeComponent();
        }

        private void buttonEnterGame_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@PIN";
            param.Value = bunifuMetroTextbox1.Text;
            SqlCommand sda = new SqlCommand("Select count(*) From SERVER Where PIN=@PIN COLLATE SQL_Latin1_General_CP1_CS_AS ",con);
            sda.Parameters.Add(param);
            Int32 count = (Int32)sda.ExecuteScalar();

            con.Close();
            if (count == 0)
            {
                Dialogue.Show("Access Denied", "", "Ok", "Cancel");
            }
            else
            {
                this.Hide();
                ParticipantLogin PL = new ParticipantLogin();
                PL.Show();
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            ParticipantSQLConnect PL = new ParticipantSQLConnect();
            PL.Show();
        }
    }
}
