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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextboxPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonFacilitatorCreateAccount = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Std Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxUsername.BackColor = System.Drawing.Color.White;
            this.TextboxUsername.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.TextboxUsername.BorderColorIdle = System.Drawing.Color.Black;
            this.TextboxUsername.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.TextboxUsername.BorderThickness = 2;
            this.TextboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxUsername.ForeColor = System.Drawing.Color.Black;
            this.TextboxUsername.isPassword = false;
            this.TextboxUsername.Location = new System.Drawing.Point(261, 227);
            this.TextboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.Size = new System.Drawing.Size(335, 44);
            this.TextboxUsername.TabIndex = 3;
            this.TextboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxPassword.BackColor = System.Drawing.Color.White;
            this.TextboxPassword.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.TextboxPassword.BorderColorIdle = System.Drawing.Color.Black;
            this.TextboxPassword.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.TextboxPassword.BorderThickness = 2;
            this.TextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxPassword.ForeColor = System.Drawing.Color.Black;
            this.TextboxPassword.isPassword = true;
            this.TextboxPassword.Location = new System.Drawing.Point(261, 305);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(335, 44);
            this.TextboxPassword.TabIndex = 4;
            this.TextboxPassword.Tag = "";
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.bunifuThinButton21);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonFacilitatorCreateAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(222, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 273);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "SIGN IN";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(73, 170);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(271, 41);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // ButtonFacilitatorCreateAccount
            // 
            this.ButtonFacilitatorCreateAccount.ActiveBorderThickness = 1;
            this.ButtonFacilitatorCreateAccount.ActiveCornerRadius = 20;
            this.ButtonFacilitatorCreateAccount.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonFacilitatorCreateAccount.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonFacilitatorCreateAccount.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.ButtonFacilitatorCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonFacilitatorCreateAccount.BackColor = System.Drawing.Color.White;
            this.ButtonFacilitatorCreateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonFacilitatorCreateAccount.BackgroundImage")));
            this.ButtonFacilitatorCreateAccount.ButtonText = "CREATE AN ACCOUNT";
            this.ButtonFacilitatorCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFacilitatorCreateAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFacilitatorCreateAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonFacilitatorCreateAccount.IdleBorderThickness = 1;
            this.ButtonFacilitatorCreateAccount.IdleCornerRadius = 1;
            this.ButtonFacilitatorCreateAccount.IdleFillColor = System.Drawing.Color.White;
            this.ButtonFacilitatorCreateAccount.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.ButtonFacilitatorCreateAccount.IdleLineColor = System.Drawing.Color.White;
            this.ButtonFacilitatorCreateAccount.Location = new System.Drawing.Point(73, 221);
            this.ButtonFacilitatorCreateAccount.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonFacilitatorCreateAccount.Name = "ButtonFacilitatorCreateAccount";
            this.ButtonFacilitatorCreateAccount.Size = new System.Drawing.Size(271, 41);
            this.ButtonFacilitatorCreateAccount.TabIndex = 7;
            this.ButtonFacilitatorCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonFacilitatorCreateAccount.Click += new System.EventHandler(this.ButtonFacilitatorCreateAccount_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FacilitatorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(850, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxUsername);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FacilitatorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facilitator Login";
            this.Load += new System.EventHandler(this.FacilitatorLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonFacilitatorCreateAccount;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}