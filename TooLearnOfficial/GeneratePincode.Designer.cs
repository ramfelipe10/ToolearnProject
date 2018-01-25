namespace TooLearnOfficial
{
    partial class GeneratePincode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePincode));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPincode = new System.Windows.Forms.TextBox();
            this.ButtonGeneratePincode = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 42);
            this.label1.TabIndex = 68;
            this.label1.Text = "Generate Pincode";
            // 
            // textBoxPincode
            // 
            this.textBoxPincode.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPincode.Location = new System.Drawing.Point(195, 166);
            this.textBoxPincode.Name = "textBoxPincode";
            this.textBoxPincode.Size = new System.Drawing.Size(271, 41);
            this.textBoxPincode.TabIndex = 70;
            this.textBoxPincode.TextChanged += new System.EventHandler(this.textBoxPincode_TextChanged);
            // 
            // ButtonGeneratePincode
            // 
            this.ButtonGeneratePincode.ActiveBorderThickness = 1;
            this.ButtonGeneratePincode.ActiveCornerRadius = 20;
            this.ButtonGeneratePincode.ActiveFillColor = System.Drawing.Color.White;
            this.ButtonGeneratePincode.ActiveForecolor = System.Drawing.Color.DodgerBlue;
            this.ButtonGeneratePincode.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGeneratePincode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonGeneratePincode.BackColor = System.Drawing.Color.Gray;
            this.ButtonGeneratePincode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGeneratePincode.BackgroundImage")));
            this.ButtonGeneratePincode.ButtonText = "GENERATE PINCODE";
            this.ButtonGeneratePincode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGeneratePincode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGeneratePincode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGeneratePincode.IdleBorderThickness = 1;
            this.ButtonGeneratePincode.IdleCornerRadius = 1;
            this.ButtonGeneratePincode.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGeneratePincode.IdleForecolor = System.Drawing.Color.White;
            this.ButtonGeneratePincode.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGeneratePincode.Location = new System.Drawing.Point(195, 215);
            this.ButtonGeneratePincode.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonGeneratePincode.Name = "ButtonGeneratePincode";
            this.ButtonGeneratePincode.Size = new System.Drawing.Size(271, 41);
            this.ButtonGeneratePincode.TabIndex = 71;
            this.ButtonGeneratePincode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonGeneratePincode.Click += new System.EventHandler(this.ButtonGeneratePincode_Click);
            // 
            // GeneratePincode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(685, 370);
            this.Controls.Add(this.ButtonGeneratePincode);
            this.Controls.Add(this.textBoxPincode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneratePincode";
            this.Text = "GeneratePincode";
            this.Load += new System.EventHandler(this.GeneratePincode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPincode;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonGeneratePincode;
    }
}