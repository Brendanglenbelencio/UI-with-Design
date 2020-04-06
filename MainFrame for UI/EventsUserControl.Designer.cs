namespace MainFrame_for_UI
{
    partial class EventsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsUserControl));
            this.EventsHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventsHeader
            // 
            this.EventsHeader.AutoSize = true;
            this.EventsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.EventsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.EventsHeader.Font = new System.Drawing.Font("Century Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EventsHeader.Location = new System.Drawing.Point(0, 0);
            this.EventsHeader.Name = "EventsHeader";
            this.EventsHeader.Size = new System.Drawing.Size(357, 53);
            this.EventsHeader.TabIndex = 2;
            this.EventsHeader.Text = "EVENTS SECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poster Making Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 279);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digital Art Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.label4.Location = new System.Drawing.Point(50, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Coming Soon...";
            // 
            // EventsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventsHeader);
            this.Name = "EventsUserControl";
            this.Size = new System.Drawing.Size(1051, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventsHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
