namespace TooLearnOfficial
{
    partial class MainMenu2
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu2));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.timeOras = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.buttonManual = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMnu = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonAboutSystem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonJoinGame = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.settings1 = new TooLearnOfficial.User_Control.Settings();
            this.home1 = new TooLearnOfficial.User_Control_Facilitator.Home();
            this.aboutSystem1 = new TooLearnOfficial.User_Control.AboutSystem();
            this.accountParticipant1 = new TooLearnOfficial.User_Control_Participant.AccountParticipant();
            this.joinQuiz1 = new TooLearnOfficial.User_Control_Participant.JoinQuiz();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogosTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.SteelBlue;
            this.header.Controls.Add(this.bunifuCustomLabel2);
            this.header.Controls.Add(this.ButtonMinimize);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.buttonExit);
            this.LogoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1184, 26);
            this.header.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.LogosTransition.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(39, 3);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "TooLearn";
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.ButtonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.ButtonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.ButtonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMinimize.Image = global::TooLearnOfficial.Properties.Resources.Minimize_Window_48px;
            this.ButtonMinimize.ImageActive = null;
            this.ButtonMinimize.Location = new System.Drawing.Point(1140, 4);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(20, 20);
            this.ButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMinimize.TabIndex = 6;
            this.ButtonMinimize.TabStop = false;
            this.ButtonMinimize.Zoom = 20;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // pictureBox2
            // 
            this.LogosTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
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
            this.LogoTransition.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.buttonExit.Image = global::TooLearnOfficial.Properties.Resources.Close_Window_48px;
            this.buttonExit.ImageActive = null;
            this.buttonExit.Location = new System.Drawing.Point(1159, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonExit.TabIndex = 2;
            this.buttonExit.TabStop = false;
            this.buttonExit.Zoom = 20;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timeOras
            // 
            this.timeOras.AutoSize = true;
            this.LogosTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.timeOras.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOras.ForeColor = System.Drawing.SystemColors.Control;
            this.timeOras.Location = new System.Drawing.Point(60, 624);
            this.timeOras.Name = "timeOras";
            this.timeOras.Size = new System.Drawing.Size(50, 22);
            this.timeOras.TabIndex = 5;
            this.timeOras.Text = "Time";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.sidemenu.Controls.Add(this.buttonManual);
            this.sidemenu.Controls.Add(this.bunifuCustomLabel4);
            this.sidemenu.Controls.Add(this.bunifuCustomLabel5);
            this.sidemenu.Controls.Add(this.bunifuCustomLabel1);
            this.sidemenu.Controls.Add(this.label2);
            this.sidemenu.Controls.Add(this.buttonLogout);
            this.sidemenu.Controls.Add(this.btnMnu);
            this.sidemenu.Controls.Add(this.timeOras);
            this.sidemenu.Controls.Add(this.buttonAboutSystem);
            this.sidemenu.Controls.Add(this.buttonSettings);
            this.sidemenu.Controls.Add(this.buttonJoinGame);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.logo);
            this.LogoTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sidemenu.Location = new System.Drawing.Point(0, 26);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(239, 655);
            this.sidemenu.TabIndex = 3;
            // 
            // buttonManual
            // 
            this.buttonManual.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonManual.BorderRadius = 0;
            this.buttonManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonManual.ButtonText = "     Manual";
            this.buttonManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonManual, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonManual, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonManual, BunifuAnimatorNS.DecorationType.None);
            this.buttonManual.DisabledColor = System.Drawing.Color.Gray;
            this.buttonManual.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonManual.Iconimage = global::TooLearnOfficial.Properties.Resources.User_Manual_64px;
            this.buttonManual.Iconimage_right = null;
            this.buttonManual.Iconimage_right_Selected = null;
            this.buttonManual.Iconimage_Selected = null;
            this.buttonManual.IconMarginLeft = 0;
            this.buttonManual.IconMarginRight = 0;
            this.buttonManual.IconRightVisible = true;
            this.buttonManual.IconRightZoom = 0D;
            this.buttonManual.IconVisible = true;
            this.buttonManual.IconZoom = 70D;
            this.buttonManual.IsTab = true;
            this.buttonManual.Location = new System.Drawing.Point(0, 360);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonManual.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonManual.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonManual.selected = false;
            this.buttonManual.Size = new System.Drawing.Size(239, 45);
            this.buttonManual.TabIndex = 24;
            this.buttonManual.Text = "     Manual";
            this.buttonManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManual.Textcolor = System.Drawing.Color.White;
            this.buttonManual.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.LogosTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 218);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(43, 18);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "Quiz:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.LogosTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 290);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(49, 18);
            this.bunifuCustomLabel5.TabIndex = 22;
            this.bunifuCustomLabel5.Text = "Other:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.LogosTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 98);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(54, 18);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Profile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.LogosTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time :";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogout.BorderRadius = 0;
            this.buttonLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonLogout.ButtonText = "     Logout";
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonLogout, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonLogout, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonLogout, BunifuAnimatorNS.DecorationType.None);
            this.buttonLogout.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogout.Iconimage = global::TooLearnOfficial.Properties.Resources.Logout_Rounded_Left_64px;
            this.buttonLogout.Iconimage_right = null;
            this.buttonLogout.Iconimage_right_Selected = null;
            this.buttonLogout.Iconimage_Selected = null;
            this.buttonLogout.IconMarginLeft = 0;
            this.buttonLogout.IconMarginRight = 0;
            this.buttonLogout.IconRightVisible = true;
            this.buttonLogout.IconRightZoom = 0D;
            this.buttonLogout.IconVisible = true;
            this.buttonLogout.IconZoom = 70D;
            this.buttonLogout.IsTab = false;
            this.buttonLogout.Location = new System.Drawing.Point(0, 168);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogout.selected = false;
            this.buttonLogout.Size = new System.Drawing.Size(239, 45);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "     Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Textcolor = System.Drawing.Color.White;
            this.buttonLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // btnMnu
            // 
            this.btnMnu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMnu.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.btnMnu.Image = ((System.Drawing.Image)(resources.GetObject("btnMnu.Image")));
            this.btnMnu.ImageActive = null;
            this.btnMnu.Location = new System.Drawing.Point(201, 23);
            this.btnMnu.Name = "btnMnu";
            this.btnMnu.Size = new System.Drawing.Size(35, 35);
            this.btnMnu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMnu.TabIndex = 1;
            this.btnMnu.TabStop = false;
            this.btnMnu.Visible = false;
            this.btnMnu.Zoom = 10;
            // 
            // buttonAboutSystem
            // 
            this.buttonAboutSystem.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonAboutSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAboutSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAboutSystem.BorderRadius = 0;
            this.buttonAboutSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonAboutSystem.ButtonText = "     About";
            this.buttonAboutSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonAboutSystem, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonAboutSystem, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonAboutSystem, BunifuAnimatorNS.DecorationType.None);
            this.buttonAboutSystem.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAboutSystem.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAboutSystem.Iconimage = global::TooLearnOfficial.Properties.Resources.Info_50px;
            this.buttonAboutSystem.Iconimage_right = null;
            this.buttonAboutSystem.Iconimage_right_Selected = null;
            this.buttonAboutSystem.Iconimage_Selected = null;
            this.buttonAboutSystem.IconMarginLeft = 0;
            this.buttonAboutSystem.IconMarginRight = 0;
            this.buttonAboutSystem.IconRightVisible = true;
            this.buttonAboutSystem.IconRightZoom = 0D;
            this.buttonAboutSystem.IconVisible = true;
            this.buttonAboutSystem.IconZoom = 70D;
            this.buttonAboutSystem.IsTab = false;
            this.buttonAboutSystem.Location = new System.Drawing.Point(0, 407);
            this.buttonAboutSystem.Name = "buttonAboutSystem";
            this.buttonAboutSystem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAboutSystem.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonAboutSystem.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAboutSystem.selected = false;
            this.buttonAboutSystem.Size = new System.Drawing.Size(239, 45);
            this.buttonAboutSystem.TabIndex = 7;
            this.buttonAboutSystem.Text = "     About";
            this.buttonAboutSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutSystem.Textcolor = System.Drawing.Color.White;
            this.buttonAboutSystem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonAboutSystem.Click += new System.EventHandler(this.buttonAboutSystem_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.BorderRadius = 0;
            this.buttonSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonSettings.ButtonText = "     Settings";
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonSettings, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonSettings, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonSettings, BunifuAnimatorNS.DecorationType.None);
            this.buttonSettings.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSettings.Iconimage = global::TooLearnOfficial.Properties.Resources.Settings_52px;
            this.buttonSettings.Iconimage_right = null;
            this.buttonSettings.Iconimage_right_Selected = null;
            this.buttonSettings.Iconimage_Selected = null;
            this.buttonSettings.IconMarginLeft = 0;
            this.buttonSettings.IconMarginRight = 0;
            this.buttonSettings.IconRightVisible = true;
            this.buttonSettings.IconRightZoom = 0D;
            this.buttonSettings.IconVisible = true;
            this.buttonSettings.IconZoom = 70D;
            this.buttonSettings.IsTab = false;
            this.buttonSettings.Location = new System.Drawing.Point(0, 313);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSettings.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSettings.selected = false;
            this.buttonSettings.Size = new System.Drawing.Size(239, 45);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "     Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Textcolor = System.Drawing.Color.White;
            this.buttonSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonJoinGame
            // 
            this.buttonJoinGame.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonJoinGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonJoinGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJoinGame.BorderRadius = 0;
            this.buttonJoinGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonJoinGame.ButtonText = "     Join Quiz";
            this.buttonJoinGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonJoinGame, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonJoinGame, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonJoinGame, BunifuAnimatorNS.DecorationType.None);
            this.buttonJoinGame.DisabledColor = System.Drawing.Color.Gray;
            this.buttonJoinGame.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonJoinGame.Iconimage = global::TooLearnOfficial.Properties.Resources.Handshake_52px;
            this.buttonJoinGame.Iconimage_right = null;
            this.buttonJoinGame.Iconimage_right_Selected = null;
            this.buttonJoinGame.Iconimage_Selected = null;
            this.buttonJoinGame.IconMarginLeft = 0;
            this.buttonJoinGame.IconMarginRight = 0;
            this.buttonJoinGame.IconRightVisible = true;
            this.buttonJoinGame.IconRightZoom = 0D;
            this.buttonJoinGame.IconVisible = true;
            this.buttonJoinGame.IconZoom = 70D;
            this.buttonJoinGame.IsTab = false;
            this.buttonJoinGame.Location = new System.Drawing.Point(0, 241);
            this.buttonJoinGame.Name = "buttonJoinGame";
            this.buttonJoinGame.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonJoinGame.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonJoinGame.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonJoinGame.selected = false;
            this.buttonJoinGame.Size = new System.Drawing.Size(239, 45);
            this.buttonJoinGame.TabIndex = 5;
            this.buttonJoinGame.Text = "     Join Quiz";
            this.buttonJoinGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJoinGame.Textcolor = System.Drawing.Color.White;
            this.buttonJoinGame.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonJoinGame.Click += new System.EventHandler(this.buttonJoinGame_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "     My Account";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::TooLearnOfficial.Properties.Resources.User_48px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 121);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(239, 45);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "     My Account";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // logo
            // 
            this.LogosTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(17, 8);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(204, 67);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.LogoTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation3;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.LogosTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.settings1.Location = new System.Drawing.Point(360, 124);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(685, 370);
            this.settings1.TabIndex = 8;
            // 
            // home1
            // 
            this.home1.BackgroundImage = global::TooLearnOfficial.Properties.Resources.bg;
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogosTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1184, 681);
            this.home1.TabIndex = 4;
            // 
            // aboutSystem1
            // 
            this.aboutSystem1.BackColor = System.Drawing.Color.Gray;
            this.LogosTransition.SetDecoration(this.aboutSystem1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.aboutSystem1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.aboutSystem1, BunifuAnimatorNS.DecorationType.None);
            this.aboutSystem1.Location = new System.Drawing.Point(393, 141);
            this.aboutSystem1.Name = "aboutSystem1";
            this.aboutSystem1.Size = new System.Drawing.Size(685, 370);
            this.aboutSystem1.TabIndex = 5;
            // 
            // accountParticipant1
            // 
            this.accountParticipant1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.LogosTransition.SetDecoration(this.accountParticipant1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.accountParticipant1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.accountParticipant1, BunifuAnimatorNS.DecorationType.None);
            this.accountParticipant1.Location = new System.Drawing.Point(311, 97);
            this.accountParticipant1.Name = "accountParticipant1";
            this.accountParticipant1.Size = new System.Drawing.Size(794, 506);
            this.accountParticipant1.TabIndex = 6;
            // 
            // joinQuiz1
            // 
            this.joinQuiz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.LogosTransition.SetDecoration(this.joinQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.joinQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.joinQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.joinQuiz1.Location = new System.Drawing.Point(360, 124);
            this.joinQuiz1.Name = "joinQuiz1";
            this.joinQuiz1.Size = new System.Drawing.Size(685, 370);
            this.joinQuiz1.TabIndex = 7;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.PanelTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation2;
            // 
            // LogosTransition
            // 
            this.LogosTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.LogosTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogosTransition.DefaultAnimation = animation1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.aboutSystem1);
            this.Controls.Add(this.accountParticipant1);
            this.Controls.Add(this.joinQuiz1);
            this.Controls.Add(this.settings1);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu2_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu2_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.sidemenu.ResumeLayout(false);
            this.sidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton ButtonMinimize;
        private System.Windows.Forms.Label timeOras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton buttonExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuFlatButton buttonLogout;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAboutSystem;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSettings;
        private Bunifu.Framework.UI.BunifuFlatButton buttonJoinGame;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnMnu;
        private System.Windows.Forms.PictureBox logo;
        private BunifuAnimatorNS.BunifuTransition LogosTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private User_Control_Facilitator.Home home1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private User_Control.AboutSystem aboutSystem1;
        private User_Control_Participant.AccountParticipant accountParticipant1;
        private User_Control_Participant.JoinQuiz joinQuiz1;
        private User_Control.Settings settings1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonManual;
    }
}