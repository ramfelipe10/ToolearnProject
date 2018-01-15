namespace TooLearnOfficial
{
    partial class PicturePuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicturePuzzle));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timeOras = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.bunifuCustomLabel2);
            this.header.Controls.Add(this.ButtonMinimize);
            this.header.Controls.Add(this.timeOras);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.buttonExit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1045, 27);
            this.header.TabIndex = 146;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(39, 3);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(202, 21);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Picture Puzzle - TooLearn ";
            // 
            // timeOras
            // 
            this.timeOras.AutoSize = true;
            this.timeOras.BackColor = System.Drawing.Color.Transparent;
            this.timeOras.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.timeOras.ForeColor = System.Drawing.SystemColors.Control;
            this.timeOras.Location = new System.Drawing.Point(83, 612);
            this.timeOras.Name = "timeOras";
            this.timeOras.Size = new System.Drawing.Size(50, 22);
            this.timeOras.TabIndex = 5;
            this.timeOras.Text = "Time";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::TooLearnOfficial.Properties.Resources.Minimize_Window_48px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1002, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 15;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::TooLearnOfficial.Properties.Resources.Close_Window_48px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1022, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 14;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.Image = global::TooLearnOfficial.Properties.Resources.Minimize_Window_48px;
            this.ButtonMinimize.ImageActive = null;
            this.ButtonMinimize.Location = new System.Drawing.Point(1139, 3);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(20, 20);
            this.ButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMinimize.TabIndex = 6;
            this.ButtonMinimize.TabStop = false;
            this.ButtonMinimize.Zoom = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TooLearnOfficial.Properties.Resources.toolearn_icon;
            this.pictureBox2.Location = new System.Drawing.Point(8, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Image = global::TooLearnOfficial.Properties.Resources.Close_Window_48px;
            this.buttonExit.ImageActive = null;
            this.buttonExit.Location = new System.Drawing.Point(1159, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonExit.TabIndex = 2;
            this.buttonExit.TabStop = false;
            this.buttonExit.Zoom = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 42);
            this.label1.TabIndex = 147;
            this.label1.Text = "Create Picture Puzzle Quiz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TooLearnOfficial.Properties.Resources._20916861_1628655903872405_932534712_n;
            this.pictureBox1.Location = new System.Drawing.Point(810, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PicturePuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1045, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PicturePuzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PicturePuzzle";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton ButtonMinimize;
        private System.Windows.Forms.Label timeOras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}