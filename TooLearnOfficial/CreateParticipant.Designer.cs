namespace TooLearnOfficial
{
    partial class CreateParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateParticipant));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonParticipantCreateAccount = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAvailableUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxReTypePassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Location = new System.Drawing.Point(269, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ButtonParticipantCreateAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelAvailableUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextboxReTypePassword);
            this.groupBox1.Controls.Add(this.TextboxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextboxPassword);
            this.groupBox1.Controls.Add(this.TextboxUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(222, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 335);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ButtonParticipantCreateAccount
            // 
            this.ButtonParticipantCreateAccount.ActiveBorderThickness = 1;
            this.ButtonParticipantCreateAccount.ActiveCornerRadius = 20;
            this.ButtonParticipantCreateAccount.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonParticipantCreateAccount.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonParticipantCreateAccount.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.ButtonParticipantCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonParticipantCreateAccount.BackColor = System.Drawing.Color.White;
            this.ButtonParticipantCreateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonParticipantCreateAccount.BackgroundImage")));
            this.ButtonParticipantCreateAccount.ButtonText = "CREATE AN ACCOUNT";
            this.ButtonParticipantCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonParticipantCreateAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonParticipantCreateAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonParticipantCreateAccount.IdleBorderThickness = 1;
            this.ButtonParticipantCreateAccount.IdleCornerRadius = 1;
            this.ButtonParticipantCreateAccount.IdleFillColor = System.Drawing.Color.White;
            this.ButtonParticipantCreateAccount.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.ButtonParticipantCreateAccount.IdleLineColor = System.Drawing.Color.White;
            this.ButtonParticipantCreateAccount.Location = new System.Drawing.Point(66, 285);
            this.ButtonParticipantCreateAccount.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonParticipantCreateAccount.Name = "ButtonParticipantCreateAccount";
            this.ButtonParticipantCreateAccount.Size = new System.Drawing.Size(271, 41);
            this.ButtonParticipantCreateAccount.TabIndex = 7;
            this.ButtonParticipantCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonParticipantCreateAccount.Click += new System.EventHandler(this.ButtonParticipantCreateAccount_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAvailableUsername
            // 
            this.labelAvailableUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAvailableUsername.AutoSize = true;
            this.labelAvailableUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelAvailableUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableUsername.Location = new System.Drawing.Point(140, 79);
            this.labelAvailableUsername.Name = "labelAvailableUsername";
            this.labelAvailableUsername.Size = new System.Drawing.Size(0, 24);
            this.labelAvailableUsername.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Re-Type Password:";
            // 
            // TextboxReTypePassword
            // 
            this.TextboxReTypePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxReTypePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxReTypePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxReTypePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxReTypePassword.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxReTypePassword.HintText = "";
            this.TextboxReTypePassword.isPassword = false;
            this.TextboxReTypePassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxReTypePassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxReTypePassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxReTypePassword.LineThickness = 3;
            this.TextboxReTypePassword.Location = new System.Drawing.Point(11, 243);
            this.TextboxReTypePassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxReTypePassword.Name = "TextboxReTypePassword";
            this.TextboxReTypePassword.Size = new System.Drawing.Size(379, 33);
            this.TextboxReTypePassword.TabIndex = 19;
            this.TextboxReTypePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxName
            // 
            this.TextboxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxName.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxName.HintText = "";
            this.TextboxName.isPassword = false;
            this.TextboxName.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxName.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxName.LineThickness = 3;
            this.TextboxName.Location = new System.Drawing.Point(11, 42);
            this.TextboxName.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.Size = new System.Drawing.Size(379, 33);
            this.TextboxName.TabIndex = 16;
            this.TextboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxPassword.HintText = "";
            this.TextboxPassword.isPassword = false;
            this.TextboxPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxPassword.LineThickness = 3;
            this.TextboxPassword.Location = new System.Drawing.Point(11, 176);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(379, 33);
            this.TextboxPassword.TabIndex = 18;
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxUsername.HintText = "";
            this.TextboxUsername.isPassword = false;
            this.TextboxUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxUsername.LineThickness = 3;
            this.TextboxUsername.Location = new System.Drawing.Point(11, 109);
            this.TextboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.Size = new System.Drawing.Size(379, 33);
            this.TextboxUsername.TabIndex = 17;
            this.TextboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxUsername.OnValueChanged += new System.EventHandler(this.TextboxUsername_OnValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CreateParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(850, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonParticipantCreateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAvailableUsername;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxReTypePassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxUsername;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}