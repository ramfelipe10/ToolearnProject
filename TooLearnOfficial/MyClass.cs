﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.OleDb;

using System.Text.RegularExpressions;

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

        ////EXPORT TO EXCEL
        //private void ToExcel(DataGridView dGV, string filename)
        //{
        //    string stOutput = "";
        //    string sHeaders = "";
        //    for(int j = 0; j < dGV.Columns.Count; j++)            
        //        sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
        //        stOutput += sHeaders + "\r\n";

        //    for(int i = 0; i < dGV.RowCount-1; i++)
        //    {
        //        string stline = "";
        //        for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
        //            stline = stline.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
        //        stOutput += stline + "\r\n";
        //    }

        //    Encoding utf16 = Encoding.GetEncoding(1254);
        //    byte[] output = utf16.GetBytes(stOutput);
        //    FileStream fs = new FileStream(filename, FileMode.Create);
        //    BinaryWriter bw = new BinaryWriter(fs);
        //    bw.Write(output, 0, output.Length);
        //    bw.Flush();
        //    bw.Close();
        //    fs.Close();
            
        //}



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
            if (comboBox1.SelectedItem == null)
            {
                Dialogue.Show("Please Select Class First", "", "Ok", "Cancel");
            }
            else
            {
                exporttopdf(bunifuCustomDataGrid1, comboBox1.SelectedItem.ToString());
            }

        }
        public void exporttopdf(DataGridView dgv, string filename)
        {

            // IMAGE TOOLEARN
            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("toolearns.png");
            //
            PNG.ScaleToFit(150f, 150f);
            PNG.Alignment = Element.ALIGN_CENTER;
            //
            //PNG.Border = iTextSharp.text.Rectangle.BOX;
            //PNG.BorderColor = iTextSharp.text.BaseColor.GRAY;
            //PNG.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
            //PNG.BorderWidth = 5f;

            // IMAGE ADNU
            //iTextSharp.text.Image ADNU = iTextSharp.text.Image.GetInstance("ADNU.png");
            ////
            //ADNU.ScaleToFit(150f, 150f);
            //ADNU.Alignment = Element.ALIGN_RIGHT;
            //
            //ADNU.Border = iTextSharp.text.Rectangle.BOX;
            //ADNU.BorderColor = iTextSharp.text.BaseColor.GRAY;
            //PNG.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
            //ADNU.BorderWidth = 5f;

            //Chunk c1 = new Chunk("TOOLEARN APPLICATION", FontFactory.GetFont("Times New Roman"));
            //c1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
            //c1.Font.SetStyle(0);
            //c1.Font.Size = 14;

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgv.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);

            //Add Header
            foreach(DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);  
                cell.HorizontalAlignment = Element.ALIGN_CENTER;                
                pdftable.AddCell(cell);
            }

            //Add Datarow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString()));
                }
            }
            var sfd = new SaveFileDialog();
            sfd.FileName = filename;
            sfd.Filter = "Pdf File |*.pdf";
            //sfd.DefaultExt = "pdf";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(sfd.FileName,FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(PNG);
                    //pdfdoc.Add(ADNU);
                    // pdfdoc.Add(c1);
                    pdfdoc.Add(pdftable);                    
                    pdfdoc.Close();
                    stream.Close();
                }
                Dialogue.Show("PDF SAVED", "", "Ok", "Cancel");
            }

        }

        private void btn_csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "myclasslist.csv";
            //sfd.Filter = "Excel Document (*.xls)|*.xls";
            //sfd.FileName = "myclasslist.xls";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                writeCSV(bunifuCustomDataGrid1, sfd.FileName);
            }
        }
            public void writeCSV(DataGridView gridIn, string outputFile)
            {
                //test to see if the DataGridView has any rows
                if (gridIn.RowCount > 0)
                {
                    string value = "";
                    DataGridViewRow dr = new DataGridViewRow();
                    StreamWriter swOut = new StreamWriter(outputFile);

                    //write header rows to csv
                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }
                        swOut.Write(gridIn.Columns[i].HeaderText);
                    }

                    swOut.WriteLine();

                    //write DataGridView rows to csv
                    for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                    {
                        if (j > 0)
                        {
                            swOut.WriteLine();
                        }

                        dr = gridIn.Rows[j];

                        for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                swOut.Write(",");
                            }

                            value = dr.Cells[i].Value.ToString();
                            //replace comma's with spaces
                            value = value.Replace(',', ' ');
                            //replace embedded newlines with spaces
                            value = value.Replace(Environment.NewLine, " ");

                            swOut.Write(value);
                        }
                    }
                    swOut.Close();
                }
            }       
     } 
}
