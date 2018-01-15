namespace TooLearnOfficial.User_Control
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.MyAccountEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fullname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Name:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Username:";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.password);
            this.bunifuGradientPanel1.Controls.Add(this.username);
            this.bunifuGradientPanel1.Controls.Add(this.MyAccountEdit);
            this.bunifuGradientPanel1.Controls.Add(this.fullname);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(20, 123);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(644, 228);
            this.bunifuGradientPanel1.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 76;
            this.label4.Text = "Password:";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Gainsboro;
            this.password.BorderColorFocused = System.Drawing.Color.SlateGray;
            this.password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.password.BorderThickness = 2;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Enabled = false;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.isPassword = true;
            this.password.Location = new System.Drawing.Point(181, 139);
            this.password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(273, 40);
            this.password.TabIndex = 75;
            this.password.Text = "Ramon Victor Felipe";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Gainsboro;
            this.username.BorderColorFocused = System.Drawing.Color.SlateGray;
            this.username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.username.BorderThickness = 2;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Enabled = false;
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.isPassword = false;
            this.username.Location = new System.Drawing.Point(181, 70);
            this.username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(273, 40);
            this.username.TabIndex = 74;
            this.username.Text = "Ramon Victor Felipe";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MyAccountEdit
            // 
            this.MyAccountEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.MyAccountEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.MyAccountEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MyAccountEdit.BorderRadius = 5;
            this.MyAccountEdit.ButtonText = "Edit";
            this.MyAccountEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyAccountEdit.DisabledColor = System.Drawing.Color.Gray;
            this.MyAccountEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.MyAccountEdit.Iconimage = global::TooLearnOfficial.Properties.Resources.Edit_Property_52px;
            this.MyAccountEdit.Iconimage_right = null;
            this.MyAccountEdit.Iconimage_right_Selected = null;
            this.MyAccountEdit.Iconimage_Selected = null;
            this.MyAccountEdit.IconMarginLeft = 0;
            this.MyAccountEdit.IconMarginRight = 0;
            this.MyAccountEdit.IconRightVisible = true;
            this.MyAccountEdit.IconRightZoom = 0D;
            this.MyAccountEdit.IconVisible = true;
            this.MyAccountEdit.IconZoom = 60D;
            this.MyAccountEdit.IsTab = false;
            this.MyAccountEdit.Location = new System.Drawing.Point(511, 174);
            this.MyAccountEdit.Name = "MyAccountEdit";
            this.MyAccountEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.MyAccountEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.MyAccountEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.MyAccountEdit.selected = false;
            this.MyAccountEdit.Size = new System.Drawing.Size(114, 34);
            this.MyAccountEdit.TabIndex = 73;
            this.MyAccountEdit.Text = "Edit";
            this.MyAccountEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyAccountEdit.Textcolor = System.Drawing.Color.White;
            this.MyAccountEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyAccountEdit.Click += new System.EventHandler(this.MyAccountEdit_Click);
            // 
            // fullname
            // 
            this.fullname.BackColor = System.Drawing.Color.Gainsboro;
            this.fullname.BorderColorFocused = System.Drawing.Color.SlateGray;
            this.fullname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullname.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.fullname.BorderThickness = 2;
            this.fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullname.Enabled = false;
            this.fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullname.isPassword = false;
            this.fullname.Location = new System.Drawing.Point(181, 5);
            this.fullname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(273, 40);
            this.fullname.TabIndex = 72;
            this.fullname.Text = "Ramon Victor Felipe";
            this.fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this.bunifuGradientPanel1;
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MyAccount";
            this.Size = new System.Drawing.Size(685, 370);
            this.Load += new System.EventHandler(this.MyAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuMetroTextbox fullname;
        private Bunifu.Framework.UI.BunifuFlatButton MyAccountEdit;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private Bunifu.Framework.UI.BunifuMetroTextbox username;
    }
}
