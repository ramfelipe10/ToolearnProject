namespace TooLearnOfficial
{
    partial class FacilitatorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacilitatorLogin));
            this.passbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TextboxUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ButtonFacilitatorCreateAccount = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LoginHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.LoginHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passbox
            // 
            this.passbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passbox.BackColor = System.Drawing.Color.LightGray;
            this.passbox.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.passbox.BorderColorIdle = System.Drawing.Color.Black;
            this.passbox.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.passbox.BorderThickness = 2;
            this.passbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passbox.ForeColor = System.Drawing.Color.Black;
            this.passbox.isPassword = true;
            this.passbox.Location = new System.Drawing.Point(30, 245);
            this.passbox.Margin = new System.Windows.Forms.Padding(4);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(288, 38);
            this.passbox.TabIndex = 4;
            this.passbox.Tag = "";
            this.passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passbox.OnValueChanged += new System.EventHandler(this.passbox_OnValueChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.TextboxUsername.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.TextboxUsername.BorderColorIdle = System.Drawing.Color.Black;
            this.TextboxUsername.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.TextboxUsername.BorderThickness = 2;
            this.TextboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxUsername.ForeColor = System.Drawing.Color.Black;
            this.TextboxUsername.isPassword = false;
            this.TextboxUsername.Location = new System.Drawing.Point(30, 170);
            this.TextboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.Size = new System.Drawing.Size(288, 38);
            this.TextboxUsername.TabIndex = 3;
            this.TextboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxUsername.OnValueChanged += new System.EventHandler(this.TextboxUsername_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(135, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(135, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::TooLearnOfficial.Properties.Resources.Eye_52px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(281, 252);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 22;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Visible = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // ButtonFacilitatorCreateAccount
            // 
            this.ButtonFacilitatorCreateAccount.ActiveBorderThickness = 1;
            this.ButtonFacilitatorCreateAccount.ActiveCornerRadius = 20;
            this.ButtonFacilitatorCreateAccount.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonFacilitatorCreateAccount.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonFacilitatorCreateAccount.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.ButtonFacilitatorCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonFacilitatorCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ButtonFacilitatorCreateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonFacilitatorCreateAccount.BackgroundImage")));
            this.ButtonFacilitatorCreateAccount.ButtonText = "Create Account";
            this.ButtonFacilitatorCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFacilitatorCreateAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFacilitatorCreateAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonFacilitatorCreateAccount.IdleBorderThickness = 1;
            this.ButtonFacilitatorCreateAccount.IdleCornerRadius = 1;
            this.ButtonFacilitatorCreateAccount.IdleFillColor = System.Drawing.Color.White;
            this.ButtonFacilitatorCreateAccount.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.ButtonFacilitatorCreateAccount.IdleLineColor = System.Drawing.Color.White;
            this.ButtonFacilitatorCreateAccount.Location = new System.Drawing.Point(113, 388);
            this.ButtonFacilitatorCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonFacilitatorCreateAccount.Name = "ButtonFacilitatorCreateAccount";
            this.ButtonFacilitatorCreateAccount.Size = new System.Drawing.Size(122, 33);
            this.ButtonFacilitatorCreateAccount.TabIndex = 7;
            this.ButtonFacilitatorCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonFacilitatorCreateAccount.Click += new System.EventHandler(this.ButtonFacilitatorCreateAccount_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Sign In";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(106, 344);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(137, 35);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // LoginHeader
            // 
            this.LoginHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginHeader.BackgroundImage")));
            this.LoginHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginHeader.Controls.Add(this.pictureBox2);
            this.LoginHeader.Controls.Add(this.bunifuCustomLabel1);
            this.LoginHeader.Controls.Add(this.bunifuImageButton2);
            this.LoginHeader.Controls.Add(this.bunifuImageButton3);
            this.LoginHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginHeader.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginHeader.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginHeader.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginHeader.Location = new System.Drawing.Point(0, 0);
            this.LoginHeader.Name = "LoginHeader";
            this.LoginHeader.Quality = 1;
            this.LoginHeader.Size = new System.Drawing.Size(355, 26);
            this.LoginHeader.TabIndex = 13;
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
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(827, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 10;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(801, 3);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 11;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TooLearnOfficial.Properties.Resources.toolearn_icon;
            this.pictureBox1.Location = new System.Drawing.Point(118, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FacilitatorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(355, 446);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.ButtonFacilitatorCreateAccount);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxUsername);
            this.Controls.Add(this.LoginHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FacilitatorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facilitator Login";
            this.Load += new System.EventHandler(this.FacilitatorLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.LoginHeader.ResumeLayout(false);
            this.LoginHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox passbox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel LoginHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonFacilitatorCreateAccount;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxUsername;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}