namespace MainFrame_for_UI
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.ShopTitle = new System.Windows.Forms.Label();
            this.ShopTagline = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopTitle
            // 
            this.ShopTitle.AutoSize = true;
            this.ShopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.ShopTitle.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopTitle.Location = new System.Drawing.Point(37, 91);
            this.ShopTitle.Name = "ShopTitle";
            this.ShopTitle.Size = new System.Drawing.Size(321, 73);
            this.ShopTitle.TabIndex = 0;
            this.ShopTitle.Text = "ART SENSE";
            // 
            // ShopTagline
            // 
            this.ShopTagline.AutoSize = true;
            this.ShopTagline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.ShopTagline.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopTagline.Location = new System.Drawing.Point(37, 179);
            this.ShopTagline.Name = "ShopTagline";
            this.ShopTagline.Size = new System.Drawing.Size(627, 50);
            this.ShopTagline.TabIndex = 1;
            this.ShopTagline.Text = "We bring Life to what you draw!";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Location = new System.Drawing.Point(26, 243);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(197, 54);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Location = new System.Drawing.Point(50, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 330);
            this.panel1.TabIndex = 3;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShopTagline);
            this.Controls.Add(this.ShopTitle);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(962, 720);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShopTitle;
        private System.Windows.Forms.Label ShopTagline;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel panel1;
    }
}
