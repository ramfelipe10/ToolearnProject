namespace TooLearnOfficial
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.logos = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonAboutSystem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSubjectHandle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMyQuiz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCreateQuiz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMnu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.timeOras = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogosTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.settings1 = new TooLearnOfficial.User_Control.Settings();
            this.createQuiz1 = new TooLearnOfficial.User_Control.CreateQuiz();
            this.buttonCreateClassroom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidemenu.Controls.Add(this.buttonCreateClassroom);
            this.sidemenu.Controls.Add(this.logos);
            this.sidemenu.Controls.Add(this.buttonLogout);
            this.sidemenu.Controls.Add(this.buttonAboutSystem);
            this.sidemenu.Controls.Add(this.buttonSettings);
            this.sidemenu.Controls.Add(this.buttonSubjectHandle);
            this.sidemenu.Controls.Add(this.buttonMyQuiz);
            this.sidemenu.Controls.Add(this.buttonCreateQuiz);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.btnMnu);
            this.sidemenu.Controls.Add(this.logo);
            this.LogoTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sidemenu.Location = new System.Drawing.Point(0, 35);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(246, 685);
            this.sidemenu.TabIndex = 0;
            this.sidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logos
            // 
            this.logos.BackColor = System.Drawing.Color.Transparent;
            this.LogosTransition.SetDecoration(this.logos, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.logos, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.logos, BunifuAnimatorNS.DecorationType.None);
            this.logos.Image = ((System.Drawing.Image)(resources.GetObject("logos.Image")));
            this.logos.Location = new System.Drawing.Point(4, 116);
            this.logos.Name = "logos";
            this.logos.Size = new System.Drawing.Size(45, 45);
            this.logos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logos.TabIndex = 9;
            this.logos.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogout.BorderRadius = 0;
            this.buttonLogout.ButtonText = "     Logout";
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonLogout, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonLogout, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonLogout, BunifuAnimatorNS.DecorationType.None);
            this.buttonLogout.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Iconimage")));
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
            this.buttonLogout.Location = new System.Drawing.Point(-3, 585);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogout.selected = false;
            this.buttonLogout.Size = new System.Drawing.Size(278, 48);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "     Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Textcolor = System.Drawing.Color.White;
            this.buttonLogout.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonAboutSystem
            // 
            this.buttonAboutSystem.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonAboutSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAboutSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAboutSystem.BorderRadius = 0;
            this.buttonAboutSystem.ButtonText = "     About System";
            this.buttonAboutSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonAboutSystem, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonAboutSystem, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonAboutSystem, BunifuAnimatorNS.DecorationType.None);
            this.buttonAboutSystem.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAboutSystem.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAboutSystem.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonAboutSystem.Iconimage")));
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
            this.buttonAboutSystem.Location = new System.Drawing.Point(-3, 535);
            this.buttonAboutSystem.Name = "buttonAboutSystem";
            this.buttonAboutSystem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAboutSystem.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonAboutSystem.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAboutSystem.selected = false;
            this.buttonAboutSystem.Size = new System.Drawing.Size(278, 48);
            this.buttonAboutSystem.TabIndex = 7;
            this.buttonAboutSystem.Text = "     About System";
            this.buttonAboutSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutSystem.Textcolor = System.Drawing.Color.White;
            this.buttonAboutSystem.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // buttonSettings
            // 
            this.buttonSettings.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.BorderRadius = 0;
            this.buttonSettings.ButtonText = "     Settings";
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonSettings, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonSettings, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonSettings, BunifuAnimatorNS.DecorationType.None);
            this.buttonSettings.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Iconimage")));
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
            this.buttonSettings.Location = new System.Drawing.Point(-3, 484);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSettings.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSettings.selected = false;
            this.buttonSettings.Size = new System.Drawing.Size(278, 48);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "     Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Textcolor = System.Drawing.Color.White;
            this.buttonSettings.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSubjectHandle
            // 
            this.buttonSubjectHandle.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonSubjectHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubjectHandle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubjectHandle.BorderRadius = 0;
            this.buttonSubjectHandle.ButtonText = "     Classroom Handle";
            this.buttonSubjectHandle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonSubjectHandle, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonSubjectHandle, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonSubjectHandle, BunifuAnimatorNS.DecorationType.None);
            this.buttonSubjectHandle.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSubjectHandle.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSubjectHandle.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonSubjectHandle.Iconimage")));
            this.buttonSubjectHandle.Iconimage_right = null;
            this.buttonSubjectHandle.Iconimage_right_Selected = null;
            this.buttonSubjectHandle.Iconimage_Selected = null;
            this.buttonSubjectHandle.IconMarginLeft = 0;
            this.buttonSubjectHandle.IconMarginRight = 0;
            this.buttonSubjectHandle.IconRightVisible = true;
            this.buttonSubjectHandle.IconRightZoom = 0D;
            this.buttonSubjectHandle.IconVisible = true;
            this.buttonSubjectHandle.IconZoom = 70D;
            this.buttonSubjectHandle.IsTab = false;
            this.buttonSubjectHandle.Location = new System.Drawing.Point(-3, 434);
            this.buttonSubjectHandle.Name = "buttonSubjectHandle";
            this.buttonSubjectHandle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubjectHandle.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonSubjectHandle.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSubjectHandle.selected = false;
            this.buttonSubjectHandle.Size = new System.Drawing.Size(278, 48);
            this.buttonSubjectHandle.TabIndex = 5;
            this.buttonSubjectHandle.Text = "     Classroom Handle";
            this.buttonSubjectHandle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubjectHandle.Textcolor = System.Drawing.Color.White;
            this.buttonSubjectHandle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // buttonMyQuiz
            // 
            this.buttonMyQuiz.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonMyQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMyQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMyQuiz.BorderRadius = 0;
            this.buttonMyQuiz.ButtonText = "     My Quiz";
            this.buttonMyQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonMyQuiz, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonMyQuiz, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonMyQuiz, BunifuAnimatorNS.DecorationType.None);
            this.buttonMyQuiz.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMyQuiz.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMyQuiz.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMyQuiz.Iconimage")));
            this.buttonMyQuiz.Iconimage_right = null;
            this.buttonMyQuiz.Iconimage_right_Selected = null;
            this.buttonMyQuiz.Iconimage_Selected = null;
            this.buttonMyQuiz.IconMarginLeft = 0;
            this.buttonMyQuiz.IconMarginRight = 0;
            this.buttonMyQuiz.IconRightVisible = true;
            this.buttonMyQuiz.IconRightZoom = 0D;
            this.buttonMyQuiz.IconVisible = true;
            this.buttonMyQuiz.IconZoom = 70D;
            this.buttonMyQuiz.IsTab = false;
            this.buttonMyQuiz.Location = new System.Drawing.Point(-3, 384);
            this.buttonMyQuiz.Name = "buttonMyQuiz";
            this.buttonMyQuiz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMyQuiz.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonMyQuiz.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMyQuiz.selected = false;
            this.buttonMyQuiz.Size = new System.Drawing.Size(278, 48);
            this.buttonMyQuiz.TabIndex = 4;
            this.buttonMyQuiz.Text = "     My Quiz";
            this.buttonMyQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyQuiz.Textcolor = System.Drawing.Color.White;
            this.buttonMyQuiz.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyQuiz.Click += new System.EventHandler(this.buttonMyQuiz_Click);
            // 
            // buttonCreateQuiz
            // 
            this.buttonCreateQuiz.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateQuiz.BorderRadius = 0;
            this.buttonCreateQuiz.ButtonText = "     Create Quiz";
            this.buttonCreateQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonCreateQuiz, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonCreateQuiz, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonCreateQuiz, BunifuAnimatorNS.DecorationType.None);
            this.buttonCreateQuiz.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCreateQuiz.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCreateQuiz.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonCreateQuiz.Iconimage")));
            this.buttonCreateQuiz.Iconimage_right = null;
            this.buttonCreateQuiz.Iconimage_right_Selected = null;
            this.buttonCreateQuiz.Iconimage_Selected = null;
            this.buttonCreateQuiz.IconMarginLeft = 0;
            this.buttonCreateQuiz.IconMarginRight = 0;
            this.buttonCreateQuiz.IconRightVisible = true;
            this.buttonCreateQuiz.IconRightZoom = 0D;
            this.buttonCreateQuiz.IconVisible = true;
            this.buttonCreateQuiz.IconZoom = 70D;
            this.buttonCreateQuiz.IsTab = false;
            this.buttonCreateQuiz.Location = new System.Drawing.Point(-3, 334);
            this.buttonCreateQuiz.Name = "buttonCreateQuiz";
            this.buttonCreateQuiz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateQuiz.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateQuiz.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCreateQuiz.selected = false;
            this.buttonCreateQuiz.Size = new System.Drawing.Size(278, 48);
            this.buttonCreateQuiz.TabIndex = 3;
            this.buttonCreateQuiz.Text = "     Create Quiz";
            this.buttonCreateQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateQuiz.Textcolor = System.Drawing.Color.White;
            this.buttonCreateQuiz.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateQuiz.Click += new System.EventHandler(this.buttonCreateQuiz_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     My Account";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-3, 234);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(278, 48);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "     My Account";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMnu.Location = new System.Drawing.Point(203, 27);
            this.btnMnu.Name = "btnMnu";
            this.btnMnu.Size = new System.Drawing.Size(35, 35);
            this.btnMnu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMnu.TabIndex = 1;
            this.btnMnu.TabStop = false;
            this.btnMnu.Zoom = 10;
            this.btnMnu.Click += new System.EventHandler(this.btnMnu_Click);
            // 
            // logo
            // 
            this.LogosTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(23, 93);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(215, 99);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DodgerBlue;
            this.header.Controls.Add(this.ButtonMinimize);
            this.header.Controls.Add(this.timeOras);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.buttonExit);
            this.LogoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 35);
            this.header.TabIndex = 1;
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.ButtonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.ButtonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.ButtonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMinimize.Image")));
            this.ButtonMinimize.ImageActive = null;
            this.ButtonMinimize.Location = new System.Drawing.Point(1136, 6);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(25, 25);
            this.ButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMinimize.TabIndex = 6;
            this.ButtonMinimize.TabStop = false;
            this.ButtonMinimize.Zoom = 20;
            this.ButtonMinimize.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // timeOras
            // 
            this.timeOras.AutoSize = true;
            this.LogosTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.timeOras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOras.Location = new System.Drawing.Point(566, 5);
            this.timeOras.Name = "timeOras";
            this.timeOras.Size = new System.Drawing.Size(56, 24);
            this.timeOras.TabIndex = 5;
            this.timeOras.Text = "Time";
            // 
            // pictureBox2
            // 
            this.LogosTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.LogosTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "TooLearn";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageActive = null;
            this.buttonExit.Location = new System.Drawing.Point(1167, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 25);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonExit.TabIndex = 2;
            this.buttonExit.TabStop = false;
            this.buttonExit.Zoom = 20;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation3;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
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
            this.LogosTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
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
            animation1.TransparencyCoeff = 1F;
            this.LogosTransition.DefaultAnimation = animation1;
            this.LogosTransition.TimeStep = -5F;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.Gray;
            this.LogosTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.settings1.Location = new System.Drawing.Point(265, 228);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(685, 370);
            this.settings1.TabIndex = 3;
            // 
            // createQuiz1
            // 
            this.createQuiz1.BackColor = System.Drawing.Color.Gray;
            this.LogosTransition.SetDecoration(this.createQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.createQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.createQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.createQuiz1.Location = new System.Drawing.Point(265, 228);
            this.createQuiz1.Name = "createQuiz1";
            this.createQuiz1.Size = new System.Drawing.Size(683, 371);
            this.createQuiz1.TabIndex = 2;
            // 
            // buttonCreateClassroom
            // 
            this.buttonCreateClassroom.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateClassroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateClassroom.BorderRadius = 0;
            this.buttonCreateClassroom.ButtonText = "     Create Classroom";
            this.buttonCreateClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonCreateClassroom, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonCreateClassroom, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonCreateClassroom, BunifuAnimatorNS.DecorationType.None);
            this.buttonCreateClassroom.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCreateClassroom.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCreateClassroom.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonCreateClassroom.Iconimage")));
            this.buttonCreateClassroom.Iconimage_right = null;
            this.buttonCreateClassroom.Iconimage_right_Selected = null;
            this.buttonCreateClassroom.Iconimage_Selected = null;
            this.buttonCreateClassroom.IconMarginLeft = 0;
            this.buttonCreateClassroom.IconMarginRight = 0;
            this.buttonCreateClassroom.IconRightVisible = true;
            this.buttonCreateClassroom.IconRightZoom = 0D;
            this.buttonCreateClassroom.IconVisible = true;
            this.buttonCreateClassroom.IconZoom = 70D;
            this.buttonCreateClassroom.IsTab = false;
            this.buttonCreateClassroom.Location = new System.Drawing.Point(-3, 284);
            this.buttonCreateClassroom.Name = "buttonCreateClassroom";
            this.buttonCreateClassroom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateClassroom.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateClassroom.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCreateClassroom.selected = false;
            this.buttonCreateClassroom.Size = new System.Drawing.Size(278, 48);
            this.buttonCreateClassroom.TabIndex = 10;
            this.buttonCreateClassroom.Text = "     Create Classroom";
            this.buttonCreateClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateClassroom.Textcolor = System.Drawing.Color.White;
            this.buttonCreateClassroom.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.createQuiz1);
            this.Controls.Add(this.header);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton buttonExit;
        private Bunifu.Framework.UI.BunifuFlatButton buttonLogout;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAboutSystem;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSettings;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSubjectHandle;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMyQuiz;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCreateQuiz;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnMnu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private System.Windows.Forms.PictureBox logos;
        private BunifuAnimatorNS.BunifuTransition LogosTransition;
        private System.Windows.Forms.Label timeOras;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton ButtonMinimize;
        private User_Control.CreateQuiz createQuiz1;
        private User_Control.Settings settings1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCreateClassroom;
    }
}