namespace TooLearnOfficial
{
    partial class GameRulesFacilitator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRulesFacilitator));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(307, 24);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(296, 48);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "GameType";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(37, 198);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(41, 16);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Rules";
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextQuestion.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNextQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonNextQuestion.Location = new System.Drawing.Point(783, 430);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(84, 34);
            this.buttonNextQuestion.TabIndex = 140;
            this.buttonNextQuestion.Text = "Start";
            this.buttonNextQuestion.UseVisualStyleBackColor = false;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // GameRulesFacilitator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(910, 479);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameRulesFacilitator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameRulesFacilitator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameRulesFacilitator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button buttonNextQuestion;
    }
}