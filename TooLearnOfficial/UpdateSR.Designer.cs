﻿namespace TooLearnOfficial
{
    partial class UpdateSR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DataGridViewGrade = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Update = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DataGridViewGrade
            // 
            this.DataGridViewGrade.AllowUserToAddRows = false;
            this.DataGridViewGrade.AllowUserToDeleteRows = false;
            this.DataGridViewGrade.AllowUserToResizeColumns = false;
            this.DataGridViewGrade.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewGrade.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewGrade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridViewGrade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewGrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewGrade.DoubleBuffered = true;
            this.DataGridViewGrade.EnableHeadersVisualStyles = false;
            this.DataGridViewGrade.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGridViewGrade.HeaderForeColor = System.Drawing.Color.Black;
            this.DataGridViewGrade.Location = new System.Drawing.Point(12, 23);
            this.DataGridViewGrade.Name = "DataGridViewGrade";
            this.DataGridViewGrade.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewGrade.RowHeadersVisible = false;
            this.DataGridViewGrade.Size = new System.Drawing.Size(796, 176);
            this.DataGridViewGrade.TabIndex = 20;
            // 
            // btn_Update
            // 
            this.btn_Update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update.BorderRadius = 5;
            this.btn_Update.ButtonText = "Update";
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Update.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Update.Iconimage = null;
            this.btn_Update.Iconimage_right = null;
            this.btn_Update.Iconimage_right_Selected = null;
            this.btn_Update.Iconimage_Selected = null;
            this.btn_Update.IconMarginLeft = 0;
            this.btn_Update.IconMarginRight = 0;
            this.btn_Update.IconRightVisible = true;
            this.btn_Update.IconRightZoom = 0D;
            this.btn_Update.IconVisible = true;
            this.btn_Update.IconZoom = 50D;
            this.btn_Update.IsTab = false;
            this.btn_Update.Location = new System.Drawing.Point(385, 205);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Update.selected = false;
            this.btn_Update.Size = new System.Drawing.Size(59, 28);
            this.btn_Update.TabIndex = 89;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Update.Textcolor = System.Drawing.Color.White;
            this.btn_Update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // UpdateSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(834, 354);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.DataGridViewGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateSR";
            this.Text = "UpdateSR";
            this.Load += new System.EventHandler(this.UpdateSR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridViewGrade;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Update;
    }
}