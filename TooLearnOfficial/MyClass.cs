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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TooLearnOfficial
{
    public partial class MyClass : Form
    {


       SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
       // SqlConnection con = new SqlConnection("Data Source='" + Program.source + "' ; Initial Catalog='" + Program.db + "'; User ID='" + Program.id + "';Password='" + Program.password + "'");
        public MyClass()
        {
            InitializeComponent();
            Load_Class();
        }


        void Load_Class()
        {

            try
            {
                comboBox1.Items.Clear();


                SqlCommand cmd = new SqlCommand("Select class_name from classrooms WHERE facilitator_id= '" + Program.user_id + "' ", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["class_name"]);
                }
                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }


        }


        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                            
                

                SqlDataAdapter sda = new SqlDataAdapter("select p_username AS 'Username',p_password AS 'Password',fullname AS 'Name' from participant p,classlist cl where p.participant_id=cl.participant_id AND class_id=(select class_id from classrooms where class_name = '" + comboBox1.SelectedItem + "' AND facilitator_id='" + Program.user_id + "') ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                SqlDataAdapter sad = new SqlDataAdapter("Select class_code from classrooms where class_name = '" + comboBox1.SelectedItem + "' ", con);
                DataTable data = new DataTable();
                sad.Fill(data);
                
                string code = data.Rows[0][0].ToString();

                label5.Text = code;
                label4.Visible = true;

                if (dt.Rows.Count == 0)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel2.Visible = true;
                    

                  

                }


                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = bs;
                    sda.Update(dt);
                    bunifuCustomLabel2.Visible = false;                  

                    bunifuCustomDataGrid1.ClearSelection();

                }

            }

            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }

           
        }

        private void MyClass_Load(object sender, EventArgs e)
        {
              
          

        }

        private void buttonCreateClassroom_Click(object sender, EventArgs e)
        {
            CreateMyClassroom Create = new CreateMyClassroom();
            Create.ShowDialog();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        
            Load_Class(); 
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Classroom.pdf", FileMode.Create));
            doc.Open();

            //Paragraph par = new Paragraph("First Line Using Paragraph");

            //doc.Add(par);

            PdfPTable table = new PdfPTable(bunifuCustomDataGrid1.Columns.Count);

            //add the headers from the DGV to the table
            for(int j = 0; j < bunifuCustomDataGrid1.Columns.Count; j++)
            {
                table.AddCell(new Phrase(bunifuCustomDataGrid1.Columns[j].HeaderText));
            }

            //flag the first row as a header
            table.HeaderRows = 1;

            //add the actual rows from the DGV to the table
            for(int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                for(int k = 0; k < bunifuCustomDataGrid1.Columns.Count; k++)
                {
                    if(bunifuCustomDataGrid1[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(bunifuCustomDataGrid1[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            doc.Close();
        }
    }
}
