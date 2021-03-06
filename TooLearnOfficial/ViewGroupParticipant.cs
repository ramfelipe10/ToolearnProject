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

namespace TooLearnOfficial
{
    public partial class ViewGroupParticipant : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        string group = ClassGroup.SetValueForText2;
        string Class = ClassGroup.SetValueForText3;
        string ParticipantName;
        int ID;
        public ViewGroupParticipant()
        {
           InitializeComponent();        
           Load_Participant();
           Load_List();        
           
        
        }


        void Load_List()
        {

            try
            {


                SqlDataAdapter sad = new SqlDataAdapter("select class_id from classrooms where class_name = '" + Class + "' ", con);
                DataTable data = new DataTable();
                sad.Fill(data);

                int ClassID = Convert.ToInt32(data.Rows[0][0]);

                SqlDataAdapter s = new SqlDataAdapter("Select count(l_name) from participant p left join classlist cl on p.participant_id = cl.participant_id where cl.class_id = '" + ClassID + "' ", con);
                DataTable dt = new DataTable();
                s.Fill(dt);

                if (dt.Rows[0][0].ToString() == "0")
                {
                    bunifuFlatButton1.Visible = false;
                    bunifuFlatButton2.Visible = false;
                    Dialogue.Show("No Classroom Participant Found", "", "Ok", "Cancel");
                }

                else
                {

                    SqlCommand cmd = new SqlCommand("Select DISTINCT l_name from participant p left join classlist cl on p.participant_id =cl.participant_id where cl.class_id = '" + ClassID + "' ", con);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["l_name"]);

                    }
                    dr.Close();
                    con.Close();

                    grouptext.Text = group;
                    classtext.Text = Class;

                }

            }


            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }


        }
        
       void Load_Participant()
        {
               


            try
                   {

                SqlDataAdapter sad = new SqlDataAdapter("Select group_id from groups WHERE group_name = '" + group + "' ", con);
                DataTable data = new DataTable();
                sad.Fill(data);
                ID = Convert.ToInt32(data.Rows[0][0]);




                SqlDataAdapter sda = new SqlDataAdapter("Select fullname from participant p, grouplist gl WHERE p.participant_id = gl.participant_id AND gl.group_id= '" +ID+ "' ", con);
                       DataTable dt = new DataTable();
                       sda.Fill(dt);
                       BindingSource bs = new BindingSource();
                       bs.DataSource = dt;
                       bunifuCustomDataGrid1.DataSource = bs;
                       sda.Update(dt);

                    
                   }

                   catch (Exception ex)
                   {
                       Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
                   }

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();//Getting the Value From COMBO BOX


            if (selected == "")
            {
                Dialogue.Show("Invalid Input or Empty", "", "Ok", "Cancel");
            }

            else
            {
                SqlDataAdapter sad = new SqlDataAdapter("select participant_id from participant where l_name= '" + comboBox1.SelectedItem + "' ", con);
                DataTable data = new DataTable();
                sad.Fill(data);

                int ParticipantID = Convert.ToInt32(data.Rows[0][0]);


                con.Open();
                String query = "INSERT INTO grouplist (group_id,participant_id) VALUES ('" + ID + "','" + ParticipantID + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                int n = sda.SelectCommand.ExecuteNonQuery();

                con.Close();
                if (n > 0)
                {
                    Load_Participant();
                    bunifuCustomDataGrid1.ClearSelection();
                    Dialogue.Show("Inserted!", "", "Ok", "Cancel");


                }
                else
                {
                    Dialogue.Show("Failed!", "", "Ok", "Cancel");

                }

            }

        }

        private void ViewGroupParticipant_Load(object sender, EventArgs e)
        {

            bunifuCustomDataGrid1.ClearSelection();


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            try
            {

                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {





                    DialogResult result = Dialogue1.Show("Are You Sure?", "", "Ok", "Cancel");
                    if (result == DialogResult.Yes)
                    {

                        con.Open();

                        String q = "DELETE FROM grouplist WHERE participant_id=(select participant_id from participant where fullname= '" + ParticipantName + "')";
                        SqlDataAdapter s = new SqlDataAdapter(q, con);
                        int n = s.SelectCommand.ExecuteNonQuery();

                       
                        con.Close();
                        if (n > 0 )
                        {
                            Load_Participant();
                            bunifuCustomDataGrid1.ClearSelection();

                            Dialogue.Show("Successfully Deleted!", "", "Ok", "Cancel");

                        }

                        else
                        {
                            
                            Dialogue.Show("Fail to Delete!", "", "Ok", "Cancel");
                            bunifuCustomDataGrid1.ClearSelection();

                        }
                    }//end if result


                }

                else
                {
                    Dialogue.Show("Nothing Selected", "", "Ok", "Cancel");
                }


            }//try


            catch (Exception ex)
            {
                Dialogue.Show(" ' " + ex.Message.ToString() + "' ", "", "Ok", "Cancel");
            }
            

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)
            {
                ParticipantName = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();


            }
        }
    }
}
