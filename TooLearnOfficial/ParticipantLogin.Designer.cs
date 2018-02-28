namespace TooLearnOfficial
{
    partial class ParticipantLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantLogin));
            this.TextboxPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LoginHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ButtonParticipantCreateAccount = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonParticipantSignIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.TextboxUsername = new System.Windows.Forms.TextBox();
            this.LoginHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.TextboxPassword.BorderColorFocused = System.Drawing.Color.Black;
            this.TextboxPassword.BorderColorIdle = System.Drawing.Color.White;
            this.TextboxPassword.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.TextboxPassword.BorderThickness = 2;
            this.TextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxPassword.ForeColor = System.Drawing.Color.White;
            this.TextboxPassword.isPassword = true;
            this.TextboxPassword.Location = new System.Drawing.Point(38, 249);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(288, 38);
            this.TextboxPassword.TabIndex = 4;
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextboxPassword.OnValueChanged += new System.EventHandler(this.TextboxPassword_OnValueChanged);
            this.TextboxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxPassword_KeyDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(140, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(140, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.LoginHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LoginHeader
            // 
            this.LoginHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginHeader.BackgroundImage")));
            this.LoginHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginHeader.Controls.Add(this.bunifuImageButton4);
            this.LoginHeader.Controls.Add(this.pictureBox2);
            this.LoginHeader.Controls.Add(this.bunifuImageButton5);
            this.LoginHeader.Controls.Add(this.bunifuCustomLabel1);
            this.LoginHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginHeader.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginHeader.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginHeader.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginHeader.Location = new System.Drawing.Point(0, 0);
            this.LoginHeader.Name = "LoginHeader";
            this.LoginHeader.Quality = 1;
            this.LoginHeader.Size = new System.Drawing.Size(355, 26);
            this.LoginHeader.TabIndex = 25;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = global::TooLearnOfficial.Properties.Resources.Minimize_Window_48px;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(312, 4);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 24;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = global::TooLearnOfficial.Properties.Resources.Close_Window_48px;
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(332, 4);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 23;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(51, 21);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Login";
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Image = global::TooLearnOfficial.Properties.Resources.Back_Arrow_64px;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(12, 32);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(38, 36);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton6.TabIndex = 26;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TooLearnOfficial.Properties.Resources.toolearn_icon;
            this.pictureBox3.Location = new System.Drawing.Point(118, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // ButtonParticipantCreateAccount
            // 
            this.ButtonParticipantCreateAccount.ActiveBorderThickness = 1;
            this.ButtonParticipantCreateAccount.ActiveCornerRadius = 20;
            this.ButtonParticipantCreateAccount.ActiveFillColor = System.Drawing.Color.Transparent;
            this.ButtonParticipantCreateAccount.ActiveForecolor = System.Drawing.Color.Gray;
            this.ButtonParticipantCreateAccount.ActiveLineColor = System.Drawing.Color.Transparent;
            this.ButtonParticipantCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonParticipantCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ButtonParticipantCreateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonParticipantCreateAccount.BackgroundImage")));
            this.ButtonParticipantCreateAccount.ButtonText = "Create Account";
            this.ButtonParticipantCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonParticipantCreateAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ButtonParticipantCreateAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonParticipantCreateAccount.IdleBorderThickness = 1;
            this.ButtonParticipantCreateAccount.IdleCornerRadius = 20;
            this.ButtonParticipantCreateAccount.IdleFillColor = System.Drawing.Color.Transparent;
            this.ButtonParticipantCreateAccount.IdleForecolor = System.Drawing.Color.White;
            this.ButtonParticipantCreateAccount.IdleLineColor = System.Drawing.Color.Transparent;
            this.ButtonParticipantCreateAccount.Location = new System.Drawing.Point(115, 374);
            this.ButtonParticipantCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonParticipantCreateAccount.Name = "ButtonParticipantCreateAccount";
            this.ButtonParticipantCreateAccount.Size = new System.Drawing.Size(122, 33);
            this.ButtonParticipantCreateAccount.TabIndex = 7;
            this.ButtonParticipantCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonParticipantCreateAccount.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // ButtonParticipantSignIn
            // 
            this.ButtonParticipantSignIn.ActiveBorderThickness = 1;
            this.ButtonParticipantSignIn.ActiveCornerRadius = 20;
            this.ButtonParticipantSignIn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonParticipantSignIn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.ButtonParticipantSignIn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.ButtonParticipantSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonParticipantSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ButtonParticipantSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonParticipantSignIn.BackgroundImage")));
            this.ButtonParticipantSignIn.ButtonText = "Sign In";
            this.ButtonParticipantSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonParticipantSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonParticipantSignIn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonParticipantSignIn.IdleBorderThickness = 1;
            this.ButtonParticipantSignIn.IdleCornerRadius = 20;
            this.ButtonParticipantSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.ButtonParticipantSignIn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.ButtonParticipantSignIn.IdleLineColor = System.Drawing.Color.Transparent;
            this.ButtonParticipantSignIn.Location = new System.Drawing.Point(106, 330);
            this.ButtonParticipantSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonParticipantSignIn.Name = "ButtonParticipantSignIn";
            this.ButtonParticipantSignIn.Size = new System.Drawing.Size(137, 35);
            this.ButtonParticipantSignIn.TabIndex = 8;
            this.ButtonParticipantSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonParticipantSignIn.Click += new System.EventHandler(this.ButtonParticipantSignIn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::TooLearnOfficial.Properties.Resources.Eye_52px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(291, 254);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 29;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Visible = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextboxUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.TextboxUsername.Font = new System.Drawing.Font("Century Gothic", 18.5F);
            this.TextboxUsername.ForeColor = System.Drawing.Color.White;
            this.TextboxUsername.Location = new System.Drawing.Point(38, 168);
            this.TextboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.Size = new System.Drawing.Size(288, 38);
            this.TextboxUsername.TabIndex = 30;
            this.TextboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ParticipantLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(355, 446);
            this.Controls.Add(this.TextboxUsername);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton6);
            this.Controls.Add(this.LoginHeader);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ButtonParticipantCreateAccount);
            this.Controls.Add(this.ButtonParticipantSignIn);
            this.Controls.Add(this.TextboxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ParticipantLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.ParticipantLogin_Load);
            this.LoginHeader.ResumeLayout(false);
            this.LoginHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonParticipantSignIn;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonParticipantCreateAccount;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuGradientPanel LoginHeader;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private System.Windows.Forms.TextBox TextboxUsername;
    }
}