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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu2));
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.timeOras = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMnu = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonAboutSystem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSubjectHandle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMyQuiz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCreateQuiz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.home1 = new TooLearnOfficial.User_Control_Facilitator.Home();
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
            this.timeOras.Location = new System.Drawing.Point(83, 612);
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
            this.sidemenu.Controls.Add(this.label2);
            this.sidemenu.Controls.Add(this.buttonLogout);
            this.sidemenu.Controls.Add(this.btnMnu);
            this.sidemenu.Controls.Add(this.timeOras);
            this.sidemenu.Controls.Add(this.buttonAboutSystem);
            this.sidemenu.Controls.Add(this.buttonSettings);
            this.sidemenu.Controls.Add(this.buttonSubjectHandle);
            this.sidemenu.Controls.Add(this.buttonMyQuiz);
            this.sidemenu.Controls.Add(this.buttonCreateQuiz);
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
            this.sidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.sidemenu_Paint);
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
            this.label2.Location = new System.Drawing.Point(28, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time :";
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
            this.buttonLogout.Location = new System.Drawing.Point(0, 403);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.OnHovercolor = System.Drawing.Color.DodgerBlue;
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
            this.btnMnu.Location = new System.Drawing.Point(201, 6);
            this.btnMnu.Name = "btnMnu";
            this.btnMnu.Size = new System.Drawing.Size(35, 35);
            this.btnMnu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMnu.TabIndex = 1;
            this.btnMnu.TabStop = false;
            this.btnMnu.Visible = false;
            this.btnMnu.Zoom = 10;
            this.btnMnu.Click += new System.EventHandler(this.btnMnu_Click);
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
            this.buttonAboutSystem.Location = new System.Drawing.Point(0, 356);
            this.buttonAboutSystem.Name = "buttonAboutSystem";
            this.buttonAboutSystem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAboutSystem.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonAboutSystem.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAboutSystem.selected = false;
            this.buttonAboutSystem.Size = new System.Drawing.Size(239, 45);
            this.buttonAboutSystem.TabIndex = 7;
            this.buttonAboutSystem.Text = "     About System";
            this.buttonAboutSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutSystem.Textcolor = System.Drawing.Color.White;
            this.buttonAboutSystem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
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
            this.buttonSettings.Location = new System.Drawing.Point(0, 309);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSettings.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSettings.selected = false;
            this.buttonSettings.Size = new System.Drawing.Size(239, 45);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "     Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Textcolor = System.Drawing.Color.White;
            this.buttonSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // buttonSubjectHandle
            // 
            this.buttonSubjectHandle.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonSubjectHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubjectHandle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubjectHandle.BorderRadius = 0;
            this.buttonSubjectHandle.ButtonText = "     Join Quiz";
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
            this.buttonSubjectHandle.Location = new System.Drawing.Point(0, 262);
            this.buttonSubjectHandle.Name = "buttonSubjectHandle";
            this.buttonSubjectHandle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubjectHandle.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonSubjectHandle.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSubjectHandle.selected = false;
            this.buttonSubjectHandle.Size = new System.Drawing.Size(239, 45);
            this.buttonSubjectHandle.TabIndex = 5;
            this.buttonSubjectHandle.Text = "     Join Quiz";
            this.buttonSubjectHandle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubjectHandle.Textcolor = System.Drawing.Color.White;
            this.buttonSubjectHandle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // buttonMyQuiz
            // 
            this.buttonMyQuiz.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonMyQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMyQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMyQuiz.BorderRadius = 0;
            this.buttonMyQuiz.ButtonText = "     Classroom Enrolled";
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
            this.buttonMyQuiz.Location = new System.Drawing.Point(0, 215);
            this.buttonMyQuiz.Name = "buttonMyQuiz";
            this.buttonMyQuiz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMyQuiz.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonMyQuiz.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMyQuiz.selected = false;
            this.buttonMyQuiz.Size = new System.Drawing.Size(239, 45);
            this.buttonMyQuiz.TabIndex = 4;
            this.buttonMyQuiz.Text = "     Classroom Enrolled";
            this.buttonMyQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyQuiz.Textcolor = System.Drawing.Color.White;
            this.buttonMyQuiz.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // buttonCreateQuiz
            // 
            this.buttonCreateQuiz.Activecolor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateQuiz.BorderRadius = 0;
            this.buttonCreateQuiz.ButtonText = "     Free Play";
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
            this.buttonCreateQuiz.Location = new System.Drawing.Point(0, 168);
            this.buttonCreateQuiz.Name = "buttonCreateQuiz";
            this.buttonCreateQuiz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateQuiz.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateQuiz.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCreateQuiz.selected = false;
            this.buttonCreateQuiz.Size = new System.Drawing.Size(239, 45);
            this.buttonCreateQuiz.TabIndex = 3;
            this.buttonCreateQuiz.Text = "     Free Play";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 121);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(239, 45);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "     My Account";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // logo
            // 
            this.LogosTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(17, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(204, 67);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.LogoTransition.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation6;
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogosTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(239, 26);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(945, 655);
            this.home1.TabIndex = 4;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.PanelTransition.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation5;
            // 
            // LogosTransition
            // 
            this.LogosTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.LogosTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.LogosTransition.DefaultAnimation = animation4;
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
            this.Controls.Add(this.home1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogosTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu2";
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
        private Bunifu.Framework.UI.BunifuFlatButton buttonSubjectHandle;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMyQuiz;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCreateQuiz;
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
    }
}