﻿namespace TooLearnOfficial
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
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateClassroom = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.timeOras = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.createClassroom1 = new TooLearnOfficial.User_Control_Facilitator.CreateClassroom();
            this.aboutSystem1 = new TooLearnOfficial.User_Control.AboutSystem();
            this.settings1 = new TooLearnOfficial.User_Control.Settings();
            this.createQuiz1 = new TooLearnOfficial.User_Control.CreateQuiz();
            this.classroomHandle1 = new TooLearnOfficial.User_Control.ClassroomHandle();
            this.myAccount1 = new TooLearnOfficial.User_Control.MyAccount();
            this.myQuiz1 = new TooLearnOfficial.User_Control.MyQuiz();
            this.home1 = new TooLearnOfficial.User_Control_Facilitator.Home();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogosTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidemenu.SuspendLayout();
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
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.sidemenu.Controls.Add(this.bunifuFlatButton2);
            this.sidemenu.Controls.Add(this.bunifuCustomLabel5);
            this.sidemenu.Controls.Add(this.bunifuCustomLabel3);
            this.sidemenu.Controls.Add(this.bunifuCustomLabel4);
            this.sidemenu.Controls.Add(this.bunifuCustomLabel1);
            this.sidemenu.Controls.Add(this.label1);
            this.sidemenu.Controls.Add(this.label2);
            this.sidemenu.Controls.Add(this.buttonCreateClassroom);
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
            this.sidemenu.Location = new System.Drawing.Point(0, 27);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(239, 654);
            this.sidemenu.TabIndex = 0;
            this.sidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton2.ButtonText = "     Score Record";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::TooLearnOfficial.Properties.Resources.Report_Card_48px;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 327);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(239, 45);
            this.bunifuFlatButton2.TabIndex = 22;
            this.bunifuFlatButton2.Text = "     Score Record";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.LogosTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 502);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(50, 20);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "Other:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.LogosTransition.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 213);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 20);
            this.bunifuCustomLabel3.TabIndex = 19;
            this.bunifuCustomLabel3.Text = "Classroom:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.LogosTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 380);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(44, 20);
            this.bunifuCustomLabel4.TabIndex = 20;
            this.bunifuCustomLabel4.Text = "Quiz:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.LogosTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 90);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(54, 20);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Profile:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.LogosTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time";
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
            this.label2.Location = new System.Drawing.Point(4, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time :";
            // 
            // buttonCreateClassroom
            // 
            this.buttonCreateClassroom.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateClassroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateClassroom.BorderRadius = 0;
            this.buttonCreateClassroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonCreateClassroom.ButtonText = "     Create Classroom";
            this.buttonCreateClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonCreateClassroom, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonCreateClassroom, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonCreateClassroom, BunifuAnimatorNS.DecorationType.None);
            this.buttonCreateClassroom.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCreateClassroom.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCreateClassroom.Iconimage = global::TooLearnOfficial.Properties.Resources.Create_52px;
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
            this.buttonCreateClassroom.Location = new System.Drawing.Point(0, 235);
            this.buttonCreateClassroom.Name = "buttonCreateClassroom";
            this.buttonCreateClassroom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateClassroom.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonCreateClassroom.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCreateClassroom.selected = false;
            this.buttonCreateClassroom.Size = new System.Drawing.Size(239, 45);
            this.buttonCreateClassroom.TabIndex = 10;
            this.buttonCreateClassroom.Text = "     Create Classroom";
            this.buttonCreateClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateClassroom.Textcolor = System.Drawing.Color.White;
            this.buttonCreateClassroom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonCreateClassroom.Click += new System.EventHandler(this.buttonCreateClassroom_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Activecolor = System.Drawing.Color.DodgerBlue;
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
            this.buttonLogout.Location = new System.Drawing.Point(0, 159);
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
            // buttonAboutSystem
            // 
            this.buttonAboutSystem.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonAboutSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAboutSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAboutSystem.BorderRadius = 0;
            this.buttonAboutSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonAboutSystem.ButtonText = "     About System";
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
            this.buttonAboutSystem.Location = new System.Drawing.Point(0, 571);
            this.buttonAboutSystem.Name = "buttonAboutSystem";
            this.buttonAboutSystem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAboutSystem.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonAboutSystem.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAboutSystem.selected = false;
            this.buttonAboutSystem.Size = new System.Drawing.Size(239, 45);
            this.buttonAboutSystem.TabIndex = 7;
            this.buttonAboutSystem.Text = "     About System";
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
            this.buttonSettings.Location = new System.Drawing.Point(0, 524);
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
            // buttonSubjectHandle
            // 
            this.buttonSubjectHandle.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonSubjectHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubjectHandle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubjectHandle.BorderRadius = 0;
            this.buttonSubjectHandle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonSubjectHandle.ButtonText = "     Classroom Handled";
            this.buttonSubjectHandle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonSubjectHandle, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonSubjectHandle, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonSubjectHandle, BunifuAnimatorNS.DecorationType.None);
            this.buttonSubjectHandle.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSubjectHandle.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSubjectHandle.Iconimage = global::TooLearnOfficial.Properties.Resources.Classroom_50px;
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
            this.buttonSubjectHandle.Location = new System.Drawing.Point(0, 281);
            this.buttonSubjectHandle.Name = "buttonSubjectHandle";
            this.buttonSubjectHandle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubjectHandle.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonSubjectHandle.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSubjectHandle.selected = false;
            this.buttonSubjectHandle.Size = new System.Drawing.Size(239, 45);
            this.buttonSubjectHandle.TabIndex = 5;
            this.buttonSubjectHandle.Text = "     Classroom Handled";
            this.buttonSubjectHandle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubjectHandle.Textcolor = System.Drawing.Color.White;
            this.buttonSubjectHandle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonSubjectHandle.Click += new System.EventHandler(this.buttonSubjectHandle_Click);
            // 
            // buttonMyQuiz
            // 
            this.buttonMyQuiz.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonMyQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMyQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMyQuiz.BorderRadius = 0;
            this.buttonMyQuiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonMyQuiz.ButtonText = "     Quiz Bank";
            this.buttonMyQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonMyQuiz, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonMyQuiz, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonMyQuiz, BunifuAnimatorNS.DecorationType.None);
            this.buttonMyQuiz.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMyQuiz.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMyQuiz.Iconimage = global::TooLearnOfficial.Properties.Resources.Database_52px;
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
            this.buttonMyQuiz.Location = new System.Drawing.Point(0, 449);
            this.buttonMyQuiz.Name = "buttonMyQuiz";
            this.buttonMyQuiz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMyQuiz.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonMyQuiz.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMyQuiz.selected = false;
            this.buttonMyQuiz.Size = new System.Drawing.Size(239, 45);
            this.buttonMyQuiz.TabIndex = 4;
            this.buttonMyQuiz.Text = "     Quiz Bank";
            this.buttonMyQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyQuiz.Textcolor = System.Drawing.Color.White;
            this.buttonMyQuiz.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonMyQuiz.Click += new System.EventHandler(this.buttonMyQuiz_Click);
            // 
            // buttonCreateQuiz
            // 
            this.buttonCreateQuiz.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateQuiz.BorderRadius = 0;
            this.buttonCreateQuiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonCreateQuiz.ButtonText = "     Create Quiz";
            this.buttonCreateQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogosTransition.SetDecoration(this.buttonCreateQuiz, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.buttonCreateQuiz, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.buttonCreateQuiz, BunifuAnimatorNS.DecorationType.None);
            this.buttonCreateQuiz.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCreateQuiz.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCreateQuiz.Iconimage = global::TooLearnOfficial.Properties.Resources.Create_52px;
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
            this.buttonCreateQuiz.Location = new System.Drawing.Point(0, 403);
            this.buttonCreateQuiz.Name = "buttonCreateQuiz";
            this.buttonCreateQuiz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateQuiz.OnHovercolor = System.Drawing.Color.DimGray;
            this.buttonCreateQuiz.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCreateQuiz.selected = false;
            this.buttonCreateQuiz.Size = new System.Drawing.Size(239, 45);
            this.buttonCreateQuiz.TabIndex = 3;
            this.buttonCreateQuiz.Text = "     Create Quiz";
            this.buttonCreateQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateQuiz.Textcolor = System.Drawing.Color.White;
            this.buttonCreateQuiz.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonCreateQuiz.Click += new System.EventHandler(this.buttonCreateQuiz_Click);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 113);
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
            this.btnMnu.Click += new System.EventHandler(this.btnMnu_Click);
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
            // header
            // 
            this.header.BackColor = System.Drawing.Color.SteelBlue;
            this.header.Controls.Add(this.bunifuCustomLabel2);
            this.header.Controls.Add(this.ButtonMinimize);
            this.header.Controls.Add(this.timeOras);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.buttonExit);
            this.LogoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1184, 27);
            this.header.TabIndex = 1;
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
            this.bunifuCustomLabel2.TabIndex = 13;
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
            this.ButtonMinimize.Location = new System.Drawing.Point(1139, 3);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(20, 20);
            this.ButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMinimize.TabIndex = 6;
            this.ButtonMinimize.TabStop = false;
            this.ButtonMinimize.Zoom = 20;
            this.ButtonMinimize.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // timeOras
            // 
            this.timeOras.AutoSize = true;
            this.timeOras.BackColor = System.Drawing.Color.Transparent;
            this.LogosTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.timeOras, BunifuAnimatorNS.DecorationType.None);
            this.timeOras.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.timeOras.ForeColor = System.Drawing.SystemColors.Control;
            this.timeOras.Location = new System.Drawing.Point(83, 612);
            this.timeOras.Name = "timeOras";
            this.timeOras.Size = new System.Drawing.Size(50, 22);
            this.timeOras.TabIndex = 5;
            this.timeOras.Text = "Time";
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
            this.buttonExit.Location = new System.Drawing.Point(1159, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
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
            // createClassroom1
            // 
            this.createClassroom1.BackColor = System.Drawing.Color.Gray;
            this.LogosTransition.SetDecoration(this.createClassroom1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.createClassroom1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.createClassroom1, BunifuAnimatorNS.DecorationType.None);
            this.createClassroom1.Location = new System.Drawing.Point(393, 141);
            this.createClassroom1.Name = "createClassroom1";
            this.createClassroom1.Size = new System.Drawing.Size(685, 370);
            this.createClassroom1.TabIndex = 14;
            this.createClassroom1.Load += new System.EventHandler(this.createClassroom1_Load);
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
            this.aboutSystem1.TabIndex = 17;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.Gray;
            this.LogosTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.settings1.Location = new System.Drawing.Point(393, 141);
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
            this.createQuiz1.Location = new System.Drawing.Point(393, 141);
            this.createQuiz1.Name = "createQuiz1";
            this.createQuiz1.Size = new System.Drawing.Size(683, 371);
            this.createQuiz1.TabIndex = 2;
            // 
            // classroomHandle1
            // 
            this.classroomHandle1.BackColor = System.Drawing.Color.Gray;
            this.LogosTransition.SetDecoration(this.classroomHandle1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.classroomHandle1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.classroomHandle1, BunifuAnimatorNS.DecorationType.None);
            this.classroomHandle1.Location = new System.Drawing.Point(311, 97);
            this.classroomHandle1.Name = "classroomHandle1";
            this.classroomHandle1.Size = new System.Drawing.Size(794, 506);
            this.classroomHandle1.TabIndex = 16;
            // 
            // myAccount1
            // 
            this.myAccount1.BackColor = System.Drawing.Color.Gray;
            this.LogosTransition.SetDecoration(this.myAccount1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.myAccount1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.myAccount1, BunifuAnimatorNS.DecorationType.None);
            this.myAccount1.Location = new System.Drawing.Point(393, 141);
            this.myAccount1.Name = "myAccount1";
            this.myAccount1.Size = new System.Drawing.Size(685, 370);
            this.myAccount1.TabIndex = 15;
            // 
            // myQuiz1
            // 
            this.myQuiz1.BackColor = System.Drawing.Color.Gray;
            this.LogosTransition.SetDecoration(this.myQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.myQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.myQuiz1, BunifuAnimatorNS.DecorationType.None);
            this.myQuiz1.Location = new System.Drawing.Point(255, 44);
            this.myQuiz1.Name = "myQuiz1";
            this.myQuiz1.Size = new System.Drawing.Size(913, 611);
            this.myQuiz1.TabIndex = 13;
            this.myQuiz1.Load += new System.EventHandler(this.myQuiz1_Load);
            // 
            // home1
            // 
            this.home1.BackgroundImage = global::TooLearnOfficial.Properties.Resources.bg;
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogosTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(239, 27);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(945, 654);
            this.home1.TabIndex = 4;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.Controls.Add(this.createClassroom1);
            this.Controls.Add(this.aboutSystem1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.createQuiz1);
            this.Controls.Add(this.classroomHandle1);
            this.Controls.Add(this.myAccount1);
            this.Controls.Add(this.myQuiz1);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.sidemenu.ResumeLayout(false);
            this.sidemenu.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogosTransition;
        private System.Windows.Forms.Label timeOras;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton ButtonMinimize;
        private User_Control.CreateQuiz createQuiz1;
        private User_Control.Settings settings1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCreateClassroom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private User_Control_Facilitator.Home home1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private User_Control.MyQuiz myQuiz1;
        private User_Control_Facilitator.CreateClassroom createClassroom1;
        private User_Control.MyAccount myAccount1;
        private User_Control.ClassroomHandle classroomHandle1;
        private User_Control.AboutSystem aboutSystem1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}