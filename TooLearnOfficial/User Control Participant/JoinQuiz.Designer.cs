namespace TooLearnOfficial.User_Control_Participant
{
    partial class JoinQuiz
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinQuiz));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonEnterGame = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // buttonEnterGame
            // 
            this.buttonEnterGame.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonEnterGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonEnterGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEnterGame.BorderRadius = 0;
            this.buttonEnterGame.ButtonText = "ENTER";
            this.buttonEnterGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterGame.DisabledColor = System.Drawing.Color.Gray;
            this.buttonEnterGame.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonEnterGame.Iconimage = null;
            this.buttonEnterGame.Iconimage_right = null;
            this.buttonEnterGame.Iconimage_right_Selected = null;
            this.buttonEnterGame.Iconimage_Selected = null;
            this.buttonEnterGame.IconMarginLeft = 0;
            this.buttonEnterGame.IconMarginRight = 0;
            this.buttonEnterGame.IconRightVisible = true;
            this.buttonEnterGame.IconRightZoom = 0D;
            this.buttonEnterGame.IconVisible = true;
            this.buttonEnterGame.IconZoom = 90D;
            this.buttonEnterGame.IsTab = false;
            this.buttonEnterGame.Location = new System.Drawing.Point(239, 248);
            this.buttonEnterGame.Name = "buttonEnterGame";
            this.buttonEnterGame.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonEnterGame.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonEnterGame.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonEnterGame.selected = false;
            this.buttonEnterGame.Size = new System.Drawing.Size(191, 38);
            this.buttonEnterGame.TabIndex = 78;
            this.buttonEnterGame.Text = "ENTER";
            this.buttonEnterGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEnterGame.Textcolor = System.Drawing.Color.White;
            this.buttonEnterGame.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnterGame.Click += new System.EventHandler(this.buttonEnterGame_Click);
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BackColor = System.Drawing.Color.LightGray;
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(141, 197);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(370, 44);
            this.bunifuMetroTextbox1.TabIndex = 77;
            this.bunifuMetroTextbox1.Text = "Game PIN";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 42);
            this.label1.TabIndex = 75;
            this.label1.Text = "Join Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // JoinQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.buttonEnterGame);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "JoinQuiz";
            this.Size = new System.Drawing.Size(685, 370);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonEnterGame;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
