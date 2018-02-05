namespace TooLearnOfficial
{
    partial class Manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.btnNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBoxSelectUser = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectUser)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.buttonMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.buttonExit);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 1;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(850, 26);
            this.bunifuGradientPanel1.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 21);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "User Manual";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Image = global::TooLearnOfficial.Properties.Resources.Minimize_Window_48px;
            this.buttonMinimize.ImageActive = null;
            this.buttonMinimize.Location = new System.Drawing.Point(807, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimize.TabIndex = 28;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Zoom = 10;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Image = global::TooLearnOfficial.Properties.Resources.Close_Window_48px;
            this.buttonExit.ImageActive = null;
            this.buttonExit.Location = new System.Drawing.Point(827, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonExit.TabIndex = 27;
            this.buttonExit.TabStop = false;
            this.buttonExit.Zoom = 10;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(445, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 37;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Image = global::TooLearnOfficial.Properties.Resources.bg;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(850, 500);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 39;
            this.pictureBoxBackground.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.BorderRadius = 3;
            this.btnNext.ButtonText = "NEXT";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledColor = System.Drawing.Color.Gray;
            this.btnNext.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNext.Iconimage = null;
            this.btnNext.Iconimage_right = null;
            this.btnNext.Iconimage_right_Selected = null;
            this.btnNext.Iconimage_Selected = null;
            this.btnNext.IconMarginLeft = 0;
            this.btnNext.IconMarginRight = 0;
            this.btnNext.IconRightVisible = true;
            this.btnNext.IconRightZoom = 0D;
            this.btnNext.IconVisible = true;
            this.btnNext.IconZoom = 90D;
            this.btnNext.IsTab = false;
            this.btnNext.Location = new System.Drawing.Point(762, 445);
            this.btnNext.Name = "btnNext";
            this.btnNext.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNext.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNext.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNext.selected = false;
            this.btnNext.Size = new System.Drawing.Size(76, 43);
            this.btnNext.TabIndex = 154;
            this.btnNext.Text = "NEXT";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Textcolor = System.Drawing.Color.White;
            this.btnNext.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBoxSelectUser
            // 
            this.pictureBoxSelectUser.BackColor = System.Drawing.Color.White;
            this.pictureBoxSelectUser.Location = new System.Drawing.Point(12, 41);
            this.pictureBoxSelectUser.Name = "pictureBoxSelectUser";
            this.pictureBoxSelectUser.Size = new System.Drawing.Size(826, 398);
            this.pictureBoxSelectUser.TabIndex = 155;
            this.pictureBoxSelectUser.TabStop = false;
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxSelectUser);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manual";
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.Manual_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton buttonMinimize;
        private Bunifu.Framework.UI.BunifuImageButton buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.PictureBox pictureBoxSelectUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnNext;
    }
}