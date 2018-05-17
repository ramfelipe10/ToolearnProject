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
    public partial class Import : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

       public bool type;

        public Import()
        {
            InitializeComponent();
        }

        private void Import_Load(object sender, EventArgs e)
        {
            if (type == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select quiz_title from quizzes where facilitator_id= '" + Program.user_id + "' ", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count != 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        bunifuDropdown1.AddItem(data.Rows[i][0].ToString());
                    }
                    bunifuDropdown1.selectedIndex = 0;
                }

            }



            else
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select quiz_title from quizzes where facilitator_id= '" + Program.user_id + "' AND game_type='Picture Puzzle' ", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count != 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        bunifuDropdown1.AddItem(data.Rows[i][0].ToString());
                    }
                    bunifuDropdown1.selectedIndex = 0;
                }

            }
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (type == true)
            {
                QuizBee QB = (QuizBee)Application.OpenForms["QuizBee"];
                QB.ImportQA(bunifuDropdown1.selectedValue);
                this.Close();
            }

            else
            {
                PicturePuzzle PZ = (PicturePuzzle)Application.OpenForms["PicturePuzzle"];
                PZ.ImportQA(bunifuDropdown1.selectedValue);
                this.Close();
            }
        }

    }
}
